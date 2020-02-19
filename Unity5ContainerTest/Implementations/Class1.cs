using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class ImplementationN : InterfaceN
    {
        public string GetString()
        {
            return "Hello world!";
        }
    }
}
