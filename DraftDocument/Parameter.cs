using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DraftDocument
{
    public class Parameter
    {
        public eParameterType Type { get; set; }
        public string Name { get; set; }

        public Parameter(eParameterType Type, string Name) 
        {
            this.Type = Type;
            this.Name = Name;
        }


    }
}
