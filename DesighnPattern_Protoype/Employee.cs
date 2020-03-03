using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesighnPattern_Protoype
{
    class Employee : IProto<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;           
        }

        public override string ToString()
        {
            return $"Id : {Id} Name : {Name} Age : {Age} Salary : {Salary}";
        }

        public Employee Clone()
        {
            Employee employee = new Employee(this.Id, this.Name, this.Age, this.Salary);
            return employee;
        }
    }
}
