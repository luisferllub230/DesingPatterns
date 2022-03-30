using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Factory
{
    public class ConnectionClean : IConnection
    {
        private String host;
        private String port;
        private String username;
        private String password;


        public ConnectionClean()
        {
            this.host = "clean";
            this.port = "clean";
            this.username = "clean";
            this.password = "clean";
        }

        void IConnection.connect()
        {
            Console.WriteLine("clean C");
        }

        void IConnection.disconnect()
        {
            Console.WriteLine("clean D");
        }
    }
}
