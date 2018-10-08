using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ATM
    {
        private int bill20sLeft;
        private AccountList accounts;
        public ATM(string jsonFilename)
        {
            bill20sLeft = 500;
            accounts = new AccountList(jsonFilename);
    
        }
        public void TakeOut(int number)
        {
            if (bill20sLeft - number >= 0)
            {
                bill20sLeft -= number;
            }
            else
            {
                Console.WriteLine("Insufficient Bills");
            }
        }
        public AccountList GetDatabase()
        {
            return accounts;
        }

  
    }
}
