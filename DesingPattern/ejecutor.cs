using DesingPattern.Prototype;
using DesingPattern.Singleton;
using DesingPattern.Strategy;
using DesingPattern.Factory;
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
            //sin();
            //proto();
            //stra();
            factory();
        }

        //only for Strategy
        static void stra()
        {
            Contexto m1 = new Contexto();
            m1.conquer();
            m1.dinnerContext();
            m1.eyesContext(); 
        }

        //only for prototype
        static void proto()
        {
            Cars honda = new Cars() { doors = 2, motor = "v8" };
            Cars honda_fake = (Cars)honda.Clone();
            honda_fake.motor = "v5";
            Console.WriteLine("this car has " + honda.doors + " door/s and has a " + honda.motor + " motor");
            Console.WriteLine("this car has " + honda_fake.doors + " door/s and has a " + honda_fake.motor + " motor");
            Console.WriteLine("are theres cars the same?:{0}", honda == honda_fake);
        }

        //only for singleton
        static void sin() {
            var v = testSingleton.instance;
            Console.WriteLine(v.message);
            v.message = "hi";
            var f = testSingleton.instance;
            Console.WriteLine(f.message);
        }


        //only for factory
        static void factory() {
            FactoryConnection factory = new FactoryConnection();
            IConnection ss = factory.Connection("SQLSERVER");
            ss.connect();
            ss.disconnect();

            IConnection ms = factory.Connection("MYSQL");
            ms.connect();
            ms.disconnect();

            IConnection cl = factory.Connection("");
            cl.connect();
            cl.disconnect();

            IConnection md = factory.Connection("MARIADB");
            md.connect();
            md.disconnect();
        }

    }

}


