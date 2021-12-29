using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string name, string ITIN) : base(name, ITIN, 2000)
        {
        }

        public override double PayBonus()
        {
            return Wage * 0.20;
        }
        public override void WageIncrease()//This Function Calculates total Amount of the Wage Increasy for an Employee 
        {
            Wage *= 1.1;
        }

    }
}
