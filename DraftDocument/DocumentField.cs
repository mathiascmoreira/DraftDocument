using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftDocument
{
    public class DocumentField
    {

        public DocumentField(string value, string name)
        {
            this.Value = value;
            this.Name = name;
        }

        public string Value { get; set; }

        public string Name { get; set; }
    }
}
