using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class CarLimitedControl : ILimitedControl
    {
        public CarLimitedControl()
        {
        }

        public string ShowGasState()
        {
            ILimitedControl limitedControl = new CarControl();
            return limitedControl.ShowGasState();
        }

        public string ShowLocation()
        {
            ILimitedControl limitedControl = new CarControl();
            return limitedControl.ShowLocation();
        }       

       
    }
}
