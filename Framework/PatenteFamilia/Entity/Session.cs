using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PatenteFamilia.Entity
{
    public class Session
    {
        private static string user;
        public static string GetUser()
        {
            return user;
        }

        public static void LogIn(string username)
        {
            user = username;
        }
    }
}
