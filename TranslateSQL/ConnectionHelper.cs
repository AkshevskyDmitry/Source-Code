using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TranslateSQL
{
    public class ConnectionHelper
    {
        private static string serverName = "SQLEXPRESS";
        private static string databaseName = "TestDB";
        public static string ConnectionString
        {
            get
            {
                return $@"Data Source = .\{ServerName}; Initial Catalog = {DatabaseName}; Integrated Security = True";
            }
        }

        public static string ServerName
        {
            get
            {
                return serverName;
            }
            set
            {
                serverName = value;
            }
        }

        public static string DatabaseName
        {
            get
            {
                return databaseName;
            }
            set
            {
                databaseName = value;
            }
        }
    }
}
