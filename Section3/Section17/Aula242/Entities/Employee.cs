using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17.Aula242.Entities
{
    /*
        +------------------+
        |     Employee     |
        +------------------|
        | - name: String   |
        | - email: String  |
        | - salary: Double |
        +------------------+
    */
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
