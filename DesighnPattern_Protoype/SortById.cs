using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class SortById : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Id == 0 || y.Id == 0)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.Id.CompareTo(y.Id);
        }
    }
}
