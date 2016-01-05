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
        public Document()
        {
            this.Fields = new List<DocumentField>();
        }
        internal string Text { get; set; }
        internal List<DocumentField> Fields { get; set; }

        public void AddField(string value, string name){
            Fields.Add(new DocumentField(value, name));
        }

        public void ShowDraftEditor(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DraftEditor(Fields));
        }
       
    }
}
