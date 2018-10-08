using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            AccountList a = new AccountList("accounts.json");
            //Account acct = a.FindAcct("123456781234");

            a.UpdateAcct(new Account("123456781234","1234",5,false,25.5));
        }
    }
}
