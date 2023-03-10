using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest
{
    enum eTName : int { _user }
    class Config
    {
        public static string Database = "mes_khh";
        public static string Server = "192.168.0.3";
        public static string UserID = "edu";
        public static string UserPassword = "1234";

        public static string[] Tables = { "user" };

        public static DataSet user_ds = null;
    }
}
