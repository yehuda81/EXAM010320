using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IControl
    {        
        void StartDriving();        
        void EndDriving();
        void Speed();
        void Slow();
        void TurnRight();
        void TurnLeft();        
    }
}
