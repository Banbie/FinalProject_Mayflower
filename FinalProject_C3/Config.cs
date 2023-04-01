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
        public static string Database = "mayflower";
        public static string Server = "192.168.0.3";
        //public static string Server = "localhost";
        public static string UserID = "edu";
        //public static string UserID = "root";
        public static string UserPassword = "1234";

        public static string[] Tables = { "tb_user" };

        public static DataSet user_ds = null;
    }
}
