using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Авторизация
{
    class Accounts
    {
        private static Accounts instance;

        static List<accounts> AccountsDB = new List<accounts>();

        public void AddAccount(string login, string password)
        {
            accounts acc = new accounts(login, password);
            AccountsDB.Add(acc);
        }
        public List<accounts> GetAccounts()
        {
            return AccountsDB;
        }
        public Accounts()
        {
        }
        public static Accounts getInstance()
        {
            if (instance == null)
            {
                instance = new Accounts();
            }
            return instance;
        }
    }
}
