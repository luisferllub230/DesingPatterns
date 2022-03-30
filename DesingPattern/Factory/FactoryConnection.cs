using DesingPattern.Factory.dataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Factory
{
    internal class FactoryConnection
    {
        public IConnection Connection(String DB){

            if (DB == null) {
                return new ConnectionClean();
            }
            else if (DB == "SQLSERVER") {
                return new SqlServer();
            }
            else if (DB == "MYSQL")
            {
                return new MySql();
            }
            else if (DB == "MARIADB")
            {
                return new mariadb();
            }

            return new ConnectionClean();
        }
    }
}
