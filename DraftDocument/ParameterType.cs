using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftDocument
{
   
    public class ParameterType
    {
        public static string GetName(eParameterType parameter)
        {
            string Name = String.Empty; ;

            switch (parameter)
            {                
                case eParameterType.eDate:
                    Name = "DATE";
                    break;
                case eParameterType.eString:
                    Name = "MERGEFIELD";
                    break;
                default:
                    Name = "MERGEFIELD";
                    break;
            }
            return Name;
        }
    }

    public enum eParameterType
    {       
        eDate = 0,
        eString = 1
    }
}
