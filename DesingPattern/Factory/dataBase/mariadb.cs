using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Factory.dataBase
{
    public class mariadb : IConnection
    {
        private String host;
        private String port;
        private String username;
        private String password;


        public mariadb()
        {
            this.host = "localhost";
            this.port = "5433";
            this.username = "admin";
            this.password = "admin";
        }

        void IConnection.connect()
        {
            Console.WriteLine("the user has connect with mariadb");
        }

        void IConnection.disconnect()
        {
            Console.WriteLine("the user has disconect with mariadb");
        }
    }
}
