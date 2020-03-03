using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class Factory : IProto<Factory>
    {
        public Employee e1 { get; set; }
        public Employee e2 { get; set; }
        public Employee e3 { get; set; }
        public Employee e4 { get; set; }

        public List<Employee> employees; 
        public Factory(Employee e1, Employee e2, Employee e3, Employee e4)
        {
            this.e1 = e1;
            this.e2 = e2;
            this.e3 = e3;
            this.e4 = e4;
            employees = new List<Employee>()
            {
                e1,e2,e3,e4
            };
        }

        public Factory Clone()
        {
            Factory result = new Factory(e1.Clone(), e2.Clone(), e3.Clone(), e4.Clone());
            return result;
        }
    }
}
