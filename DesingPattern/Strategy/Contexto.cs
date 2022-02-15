using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Strategy
{
    internal class Contexto
    {
        private love men;

        public Contexto() 
        {
            //Strategy default
            this.men = new StrategyEye();
        }

        public void eyesContext() 
        {
            this.men = new StrategyEye();
        }

        public void dinnerContext() 
        {
            this.men = new StrategyDinner();
        }

        public void conquer() 
        {
            this.men.conquer();
        }
    }
}
