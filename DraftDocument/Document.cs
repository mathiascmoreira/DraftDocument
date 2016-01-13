using DevExpress.XtraRichEdit;
using DraftDocument.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftDocument
{
    public class Document
    {
        public event CloseHandle OnCloseEditor;
        public event AddParameterHandle OnAddParameter;

        DraftEditor _editor;
        public Document()
        {
            this.Parameters = new List<Parameter>();
            this.Lines = new List<object>();
            this.Text = String.Empty;

            _editor = new DraftEditor(this);
            _editor.FormClosed += _editor_FormClosed;
        }

        void _editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OnCloseEditor != null)
            {
                OnCloseEditor(this, new CloseArg { Text = this.Text });
            }
        }

        public string Text { get; set; }

        public List<Object> Lines { get; set; }

        List<Parameter> Parameters { get; set; }
        
        public void AddParameter(eParameterType type, string name)
        {
            if (Parameters.Exists(c => c.Name == name))
                throw new Exception("Parametro já existe");

            var param = new Parameter(type, name);
            Parameters.Add(param);
            SetEventAddParam(param);
        }

        private void SetEventAddParam(Parameter param)
        {
            if (OnAddParameter != null)
                OnAddParameter(this, param);
        }

        public void AddLine(Object line)
        {
            Lines.Add(line);
        }

        public IList<Parameter> GetParameters()
        {
            return Parameters.AsReadOnly();
        }

        public Parameter GetParameterByName(string name)
        {
            return Parameters.Where(c => c.Name == name).FirstOrDefault();
        }

        public void ShowEditor() 
        {
            _editor.Show();
        }

    }  
}
