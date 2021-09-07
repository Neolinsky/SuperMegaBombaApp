using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSuperBombaApp
{

    class User
    {
        public static string Login;
        public static string Password;

        public User (string password, string login)
        {
            Login = login;
            Password = password;
        }
            
    }
}
