using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftDocument.Events
{
   public delegate void CloseHandle(object sender, CloseArg args);
   public delegate void AddParameterHandle(object sender, Parameter parameter);
}
