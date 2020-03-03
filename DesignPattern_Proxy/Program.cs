using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CarControl control = new CarControl();
            Console.WriteLine("GasState: " + control.ShowGasState()); 
            Console.WriteLine("Location: " + control.ShowLocation()); 
        }
    }
}
