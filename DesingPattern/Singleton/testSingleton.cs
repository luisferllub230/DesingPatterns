using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Singleton
{
    internal class testSingleton
    {
        //this is the instance
        private static testSingleton? _instance;
        private static readonly object _door = new object();
        public String message = "";

        protected testSingleton() 
        {
            this.message = "hello world";
        }

        //method
        public static testSingleton instance 
        {
            get 
            {
                if (_instance == null) 
                {
                    lock (_door) 
                    {
                        if (_instance == null)
                        {
                            _instance = new testSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
