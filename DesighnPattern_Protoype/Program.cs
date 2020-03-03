using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class Program
    {
        static void Main(string[] args)
        {          
            Factory originalfactory = new Factory
                (            
                 new Employee(1, "Yehuda", 39, 20000),
                new Employee(2, "Sivan", 35, 30000),
                new Employee(3, "Lior", 2, 10000),
                new Employee(4, "Shachar", 0, 5000)
                );
            Factory copyfactory = originalfactory.Clone();
            ShareSecretData(copyfactory);
            foreach (var e in originalfactory.employees)
            {
                Console.WriteLine(e);
            }
        }

        static void ShareSecretData(Factory p)
        {
            Console.WriteLine("Register Employee");
            p.employees[2].Salary = 50000;
            if (p.employees.Count < 2)
            {                
                SortById sortById = new SortById();
                p.employees.Sort(sortById);
            }
            else if (p.employees.Count < 4)
            {
                SortByName sortByName = new SortByName();
                p.employees.Sort(sortByName);
            }
            else
            {
                SortBySalary sortBySalary = new SortBySalary();
                p.employees.Sort(sortBySalary);
            }
            foreach (var e in p.employees)
            {
                Console.WriteLine(e);
            }
        }
       
    }
}
