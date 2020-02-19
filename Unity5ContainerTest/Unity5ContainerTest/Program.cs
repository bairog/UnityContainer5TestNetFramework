using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using Interfaces;

namespace Unity5ContainerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer().LoadConfiguration();

            var type = container.Resolve<InterfaceN>();

            Console.WriteLine(type.GetString());
            Console.ReadKey();
        }
    }
}
