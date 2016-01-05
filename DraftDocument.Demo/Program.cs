using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftDocument.Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var contrato = new Contrato();
            contrato.Id = 12;
            contrato.Proposal = "venda";

            Document documento = new Document();
            documento.AddField(contrato.Id.ToString(), "Id");
            documento.AddField(contrato.Proposal, "Proposal");
            documento.AddField(contrato.Id.ToString(), "Id");
            documento.AddField(contrato.Proposal, "Proposal");
            documento.AddField(contrato.Id.ToString(), "Id");
            documento.AddField(contrato.Proposal, "Proposal");
            documento.AddField(contrato.Id.ToString(), "Id");
            documento.AddField(contrato.Id.ToString(), "Id");
            documento.AddField(contrato.Proposal, "Proposal");
            
           

            documento.ShowDraftEditor();                
            
        }
    }
}
