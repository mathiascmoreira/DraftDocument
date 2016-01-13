using DraftDocument;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrafDocument.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.OnCloseEditor += doc_OnCloseEditor;
            doc.Text = "Texto do documento";


            doc.AddParameter(eParameterType.eString, "Id");
            doc.AddParameter(eParameterType.eString, "Proposal");
            doc.AddParameter(eParameterType.eString, "Partner");
            doc.AddParameter(eParameterType.eDate, "Date");

            Contrato c1 = new Contrato(1, "VENDA", "JOAO", DateTime.Now);
            Contrato c2 = new Contrato(2, "ALUGUEL", "MATHIAS", DateTime.Now);
            Contrato c3 = new Contrato(3, "CONSTRUCÃO", "MOISES", DateTime.Now);
            Contrato c4 = new Contrato(4, "ALUGUEL", "MATHEUS", DateTime.Now);
            Contrato c5 = new Contrato(5, "VENDA", "VICTOR", DateTime.Now);

            doc.AddLine(c1);
            doc.AddLine(c2);
            doc.AddLine(c3);
            doc.AddLine(c4);
            doc.AddLine(c5);

            doc.Text = "Exemplo de texto";

            doc.ShowEditor();                 
        }

        void doc_OnCloseEditor(object sender, DraftDocument.Events.CloseArg args)
        {
            
        }
    }
}
