using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp3
{
    public class AccountList
    {
        private readonly string acctFile;

        public AccountList(string s)
        {
            this.acctFile = s;
        }

        public Account FindAcct(string acctNum) {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), acctFile);
            string json = File.ReadAllText(path);
            List<Account> accts = JsonConvert.DeserializeObject<List<Account>>(json);
            foreach(Account a in accts) {
                if (a.CardNum.Equals(acctNum)){
                    return a;
                }
            }
            return null;
        }

        public void UpdateAcct(Account acct) {
            string json = File.ReadAllText(acctFile);
            List<Account> entries = JsonConvert.DeserializeObject<List<Account>>(json);
            Account toRemove = new Account();
            foreach (Account a in entries)
            {
                if (a.CardNum.Equals(acct.CardNum))
                {
                    toRemove = a;
                }
            }
            entries.Remove(toRemove);
            entries.Add(acct);

            string newJSON = JsonConvert.SerializeObject(entries.ToArray(), Formatting.Indented);
            File.WriteAllText(acctFile, newJSON);
        }
    }
}
