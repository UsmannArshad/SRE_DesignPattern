using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Design_Pattern
{
    public class DispenserChain
    {
        private Dispenser d1;
        public DispenserChain()
        {
            d1 = new RupeesDispenser(5000);
            Dispenser d2 = new RupeesDispenser(1000);
            Dispenser d3 = new RupeesDispenser(500);
            d1.SetNext(d2);
            d2.SetNext(d3);
        }
        public void Dispense(Currency c)
        {
            d1.Dispense(c);
        }
    }
}
