using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Factory
{
    internal interface IConnection
    {
        public void connect();
        public void disconnect();
    }
}
