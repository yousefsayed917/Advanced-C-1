using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public Employee(int Id, string Name, int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Salary : {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (this.Salary > other?.Salary)
                return 1;
            if (this.Salary < other?.Salary)
                return -1;
            else
                return 0;
        }
    }
}
