using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CarControl : IControl, ILimitedControl
    {
        public void EndDriving()
        {
            Console.WriteLine("End Driving");
        }

        public string ShowGasState()
        {
            return new Random().Next(1000).ToString();
        }

        public string ShowLocation()
        {
            return "5165351656.0002";
        }
        public void Slow()
        {
            Console.WriteLine("Getting slow..");
        }

        public void Speed()
        {
            Console.WriteLine("Getting faster..");
        }

        public void StartDriving()
        {
            Console.WriteLine("Let's start driving");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Turn Left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Turn Right");
        }

       
    }
}
