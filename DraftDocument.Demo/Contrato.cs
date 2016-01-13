using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftDocument.Demo
{
    public class Contrato
    {
        public int Id;
        public string Proposal;
        public string Partner;
        public DateTime DataCadastro;

        public Contrato(int Id, string Proposal, string Partner, DateTime DataCadastro)
        {
            this.Id = Id;
            this.Proposal = Proposal;
            this.Partner = Partner;
            this.DataCadastro = DataCadastro;
        }
    }
}
