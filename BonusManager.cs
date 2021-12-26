using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Employees;
namespace ByteBank
{
    public class BonusManager
    {
        private double _TotalBonusPaid;

        public void BonusRegister(Employee Employee)
        {
            _TotalBonusPaid += Employee.PayBonus();
        }

        public double GetTotalBonusPaid()
        {
            return _TotalBonusPaid;
        }
    }
}
