using System;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public class Account
    {
        public string CardNum { get; set; }
        public string Pin { get; set; }
        public double LastTimeAccessed { get; set; }
        public bool IsLocked { get; set; }
        public double Balance { get; set; }

        public Account(string c, string p, double t, bool l, double b)
        {
            this.CardNum = c;
            this.Pin = p;
            this.LastTimeAccessed = t;
            this.IsLocked = l;
            this.Balance = b;
        }
        public Account() {
            this.CardNum = "";
            this.Pin = "";
            this.LastTimeAccessed = 0.0;
            this.IsLocked = false;
            this.Balance = 0.0;
        }

        // Unlock the account
        public void Lock() {
            this.IsLocked = true;
        }

        // Lock the account
        public void Unlock() {
            this.IsLocked = false;
        }

        // Add specified amount to account balance
        public void Deposit(double x) {
            this.Balance += x;
        }

        // Subtract specified amount from account balance
        public void Withdraw(double x) {
            this.Balance -= x;
        }
    }
}
