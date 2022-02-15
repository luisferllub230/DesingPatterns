using DesingPattern.Prototype;
using DesingPattern.Singleton;
<<<<<<< HEAD
using DesingPattern.Strategy;
=======
>>>>>>> main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern
{
    internal class ejecutor 
    {
        
<<<<<<< HEAD

        static void Main(string[] args)
        {
            //sin();
            //proto();
            stra();
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
        static void sin()
=======
        static void Main(string[] args) 
>>>>>>> main
        {
            //sin();
            //proto();
        }

        //only for prototype
        static void proto() 
        {
            Cars honda = new Cars() { doors = 2, motor = "v8"};
            Cars honda_fake = (Cars)honda.Clone();
            honda_fake.motor = "v5";
            Console.WriteLine("this car has "+honda.doors+" door/s and has a "+honda.motor+" motor");
            Console.WriteLine("this car has "+honda_fake.doors+" door/s and has a "+honda_fake.motor+" motor");
            Console.WriteLine("are theres cars the same?:{0}",honda == honda_fake);
        }

        //only for singleton
        static void sin() {
            var v = testSingleton.instance;
            Console.WriteLine(v.message);
            v.message = "hi";
            var f = testSingleton.instance;
            Console.WriteLine(f.message);
        }

    }

}


