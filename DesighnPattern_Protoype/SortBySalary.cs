using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class SortBySalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Salary == 0 || y.Salary == 0)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
