using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public class Director : Employee
    {
        public Director(string name, string ITIN, double wage) : base(name, ITIN, wage)
        {
        }

        public override double PayBonus()
        {
            return Wage;
        }
    }
}
