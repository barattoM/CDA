using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks
{
    public class DatabaseConnection
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Database { get; set; }
        public string Port { get; set; }
        public string Ssl { get; set; }


        public DatabaseConnection(string server, string user, string database, string port, string ssl)
        {
            this.Server = server;
            this.User = user;
            this.Database = database;
            this.Port = port;
            this.Ssl = ssl;
        }
    }
}
