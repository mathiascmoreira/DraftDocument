using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftDocument
{
    public partial class DraftEditor : Form
    {
        List<DocumentField> _fields;
        bool customDragDropTarget = false;
        private Graphics richEditGraphics = null;

        DocumentPosition pos;
        const int maxPos = 100;


        public DraftEditor(List<DocumentField> fields)
        {
            _fields = fields;
            InitializeComponent();
            CreatePanelDraggableFields();
            InitializeTextControl();
            InitializeTableLayoutPanel();
        }

        private void InitializeTableLayoutPanel()
        {
            groupBoxFields.AllowDrop = true;
            groupBoxFields.DragEnter += groupBoxFields_DragEnter;
            tableLayoutPanel.DragEnter += groupBoxFields_DragEnter;
        }

        private void InitializeTextControl()
        {
            textControl.ContentChanged += richEditControlAccounting_ContentChanged;
            textControl.DragDrop += richEditControlAccounting_DragDrop;
            textControl.DragEnter += groupBoxFields_DragEnter;
            textControl.DragOver += richEditControlAccounting_DragOver;
        }

        private void richEditControlAccounting_ContentChanged(object sender, EventArgs e)
        {
            if (((RichEditControl)sender).Text.Length > maxPos)
            {
                pos = textControl.Document.CaretPosition;                
            }
        }

        private void richEditControlAccounting_DragDrop(object sender, DragEventArgs e)
        {
            var text = e.Data.GetData(DataFormats.Text).ToString();
            if (!string.IsNullOrEmpty(text))
            {
                var range = textControl.Document.InsertText(textControl.Document.CaretPosition, text);
                DevExpress.XtraRichEdit.API.Native.Document doc = textControl.Document;

                CharacterProperties cp = doc.BeginUpdateCharacters(range);
                cp.FontName = "Arial";
                cp.FontSize = 11;
                cp.ForeColor = Color.Black;
                cp.BackColor = Color.SkyBlue;
                cp.Underline = UnderlineType.DoubleWave;
                cp.UnderlineColor = Color.White;
                doc.EndUpdateCharacters(cp);

                var rangeSpace = textControl.Document.InsertText(textControl.Document.CaretPosition, " ");
                CharacterProperties cpNormal = doc.BeginUpdateCharacters(rangeSpace);
                cpNormal.FontName = "Arial";
                cpNormal.FontSize = 11;
                cpNormal.ForeColor = Color.Black;
                cpNormal.BackColor = Color.White;
                doc.EndUpdateCharacters(cpNormal);
            }
        }

        private void richEditControlAccounting_DragOver(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            Point docPoint = Units.PixelsToDocuments(textControl.PointToClient(System.Windows.Forms.Form.MousePosition),
                textControl.DpiX, textControl.DpiY);

            DocumentPosition pos = textControl.GetPositionFromPoint(docPoint);

            if (pos == null)
                return;

            Rectangle rect = Units.DocumentsToPixels(textControl.GetBoundsFromPosition(pos),
               textControl.DpiX, textControl.DpiY);

            textControl.Document.CaretPosition = pos;

            if (richEditGraphics == null)
                richEditGraphics = textControl.CreateGraphics();

            rect.Width = 2;
            textControl.Refresh();
            richEditGraphics.FillRectangle(Brushes.Blue, rect);
            textControl.ScrollToCaret();
        }

        private void groupBoxFields_DragEnter(object sender, DragEventArgs e)
        {

            if (!e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Copy;
            // string str = e.Data.GetData(typeof(String)) as String;

            // SetCursorCustom(str);
        }

        private void CreatePanelDraggableFields()
        {
         var listPanels = new List<PanelControl>();
            foreach (var field in _fields)
            {
                var label = GetLabelControl(field);
                
                label.Dock = DockStyle.Fill;
                var panel = new PanelControl();
                panel.AutoSize = true;
                panel.Height = 20;
                panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                panel.Controls.Add(label);
                this.tableLayoutPanel.Controls.Add(panel);
                
                listPanels.Add(panel);
            }
         
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.AutoSize = true;

            ResizeControls(listPanels);            
        }

        void ResizeControls(List<PanelControl> panelList)
        {
            var maxSize = panelList.Max(c => c.Width);
            foreach (var item in panelList)
            {
                var panel = (item as PanelControl);

                panel.AutoSize = false;
                panel.Width = maxSize;

                var label = panel.Controls[0] as LabelControl;
                label.AutoSizeMode = LabelAutoSizeMode.None;
                label.Dock = DockStyle.Fill;
                label.ImageAlignToText = ImageAlignToText.TopCenter;
            }
        }

        private LabelControl GetLabelControl(DocumentField field)
        {
            var label = new LabelControl()
            {
                Size = new Size(120, 23),
                Text = field.Name,
                Tag = string.Format("[{0}]", field.Value),
                AllowDrop = true
            };

            label.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            label.Appearance.BackColor = Color.SkyBlue;
            label.Appearance.BackColor2 = Color.White;
            label.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            label.Font = new Font(label.Font, FontStyle.Bold);


            label.Padding = new Padding(2);
            label.DragDrop += label_DragDrop;
            label.MouseDown += label_MouseDown;
            label.GiveFeedback += label_GiveFeedback;
            label.ContextMenu = GetContextMenu(label.Tag);
            return label;
        }

        private System.Windows.Forms.ContextMenu GetContextMenu(Object tag)
        {
            var context = new System.Windows.Forms.ContextMenu();

            context.MenuItems.Add("Inserir na posição do cursor", new EventHandler((object sender, EventArgs e) =>
            {

                textControl.Document.InsertText(textControl.Document.CaretPosition, tag.ToString());
            }));
            context.MenuItems[context.MenuItems.Count - 1].MergeType = MenuMerge.Add;

            context.MenuItems.Add("Remover todas as ocorrências", new EventHandler((object sender, EventArgs e) =>
            {

                textControl.Document.ReplaceAll(tag.ToString(), "", SearchOptions.None);
            }));
            context.MenuItems[context.MenuItems.Count - 1].MergeType = MenuMerge.Add;

            return context;
        }

        private void label_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = e.Effect != DragDropEffects.Copy;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                return;

            customDragDropTarget = true;

            DragDropEffects dde1 = DoDragDrop((sender as LabelControl).Tag, DragDropEffects.Copy);

            customDragDropTarget = false;
        }

        private void label_DragDrop(object sender, DragEventArgs e)
        {
            (sender as LabelControl).DoDragDrop((sender as LabelControl).Tag, DragDropEffects.Copy);
        }
      
    }
}
