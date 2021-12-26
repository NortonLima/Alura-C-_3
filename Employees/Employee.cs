using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;

namespace ByteBank.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string ITIN { get; set; }
        public double Wage { get; set; }

        public Employee(string name, string ITIN, double wage)//Creating constructor
        {
            this.Name = name;
            this.ITIN = ITIN;
            this.Wage = wage;
        }

         public virtual double PayBonus()//This Function calculate and pay the anual bonus for employees
        {
            return Wage * 0.10;
        }

    }
}
