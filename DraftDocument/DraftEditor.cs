using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftDocument
{
    internal partial class DraftEditor : Form
    {
        Document _document;

        internal DraftEditor(Document doc)
        {
            InitializeComponent();

            _document = doc;
            InitializeDocument(doc);

            InitializeDataSource();

            AddParametersToComboBox();
        }

        private void InitializeDocument(Document doc)
        {
           
            richEditControl.Text = _document.Text;
            doc.OnAddParameter += doc_OnAddParameter;
        }

        void doc_OnAddParameter(object sender, Parameter parameter)
        {
            AddParametersToComboBox();
        }

        private void InitializeDataSource()
        {
            richEditControl.Options.MailMerge.DataSource = _document.Lines;
            richEditControl.Options.MailMerge.ViewMergedData = true;
        }

        private void AddParametersToComboBox()
        {
            comboBoxParameters.Items.Clear();
            var parameters = _document.GetParameters();
            foreach (var parameter in parameters)
            {
                this.comboBoxParameters.Items.Add(parameter.Name);
            }
            if (parameters.Count > 0)
                comboBoxParameters.SelectedIndex = 0;
        }

        private void ShowAllFieldsCodes()
        {
            ShowAllFieldCodesCommand command = new ShowAllFieldCodesCommand(richEditControl);
            command.Execute();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione o Arquivo";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richEditControl.Document.LoadDocument(openFileDialog.FileName, DocumentFormat.Undefined);
            }

            tabControl.SelectedTabPageIndex = 0;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewCommand Command = new PrintPreviewCommand(richEditControlResult);
            Command.Execute();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var document = richEditControl.Document;
            document.BeginUpdate();
            document.Fields.Add(document.CaretPosition, string.Format(" {0} {1} ",
                ParameterType.GetName(_document.GetParameterByName(comboBoxParameters.Text).Type), comboBoxParameters.Text));
            document.Fields.Update();
            document.EndUpdate();

            ShowAllFieldsCodes();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPageIndex = 0;
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            MailMergeOptions myMergeOptions = richEditControl.Document.CreateMailMergeOptions();
            myMergeOptions.FirstRecordIndex = 0;
            myMergeOptions.LastRecordIndex = _document.Lines.Count - 1;
            myMergeOptions.MergeMode = MergeMode.NewSection;

            richEditControl.Document.MailMerge(myMergeOptions, richEditControlResult.Document);

            tabControl.SelectedTabPageIndex = 1;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Exportar Arquivo";
            saveFileDialog.Filter = "Rtf File|*.rtf";
            saveFileDialog.ShowDialog();

            richEditControlResult.SaveDocument(saveFileDialog.FileName, DocumentFormat.Rtf);
        }

        private void DraftEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _document.Text = richEditControl.Document.RtfText ;
        }
    }
}
