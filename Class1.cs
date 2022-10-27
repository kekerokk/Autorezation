using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Авторизация
{
    public struct accounts
    {
        public string login;
        public string password;

        public accounts(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
