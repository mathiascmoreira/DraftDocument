using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrafDocument.Demo
{
   public class Contrato
    {
       public Contrato(int id, string name, string name2, DateTime date)
       {
           this.Id = id;
           this.Proposal = name;
           this.Partner = name2;
           this.Date = date;
       }

       public DateTime Date { get; set; }

       public string Partner { get; set; }

       public string Proposal { get; set; }

       public int Id { get; set; }
    }
}
