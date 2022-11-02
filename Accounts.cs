using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authorization;

namespace Авторизация
{
    class Accounts
    {
        private static Accounts instance;

        static List<accounts> AccountsDB = new List<accounts>();
        private AccountsDataBaseEntities db;

        public void AddAccount(string login, string password)
        {
            db = new AccountsDataBaseEntities();
            accounts acc = new accounts(login, password);
            AccountsDB.Add(acc);
            Table account = new Table();
            account.password = password;
            account.login = login;
            
            db.Table.Add(account);
            db.SaveChanges();
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
