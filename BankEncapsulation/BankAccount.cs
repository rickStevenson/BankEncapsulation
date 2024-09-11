using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;

        public double Deposit( double deposit)
        {
            return _balance += deposit;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
