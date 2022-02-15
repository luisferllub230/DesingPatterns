using DesingPattern.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern
{
    internal class ejecutor
    {
        static void Main(string[] args) 
        {
            var v = testSingleton.instance;
            Console.WriteLine(v.message);
            v.message = "hi";
            var f = testSingleton.instance;
            Console.WriteLine(f.message);
        }
    }
}
