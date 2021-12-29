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
        public double Wage { get; protected set; }
        public static int NumberOfEmployees { get; private set; }
        public Employee(string name, string ITIN, double wage)//Creating constructor
        {
            this.Name = name;
            this.ITIN = ITIN;
            this.Wage = wage;

            NumberOfEmployees++;
        }

        public virtual double PayBonus()//This Function calculates and pay the anual bonus for employees
        {
            return Wage * 0.10;
        }
        public virtual void WageIncrease()//This Function Calculates total Amount of the Wage Increasy for an Employee 
        {
            Wage *= 1.10;
        }

        public virtual int GetNumberOfEmployees()
        {
            return NumberOfEmployees;
        }//This Function Returns the Number of Employees in this Company
    }
}
