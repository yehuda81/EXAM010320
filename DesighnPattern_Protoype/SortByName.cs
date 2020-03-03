using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Name == null || y.Name == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.Name.CompareTo(y.Name);
        }
    }
}
