using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Design_Pattern
{
    public class RupeesDispenser : Dispenser
    {
        private Dispenser next = null;
        private int worth;
        public RupeesDispenser(int worth)
        {
            this.worth = worth;
        }
        public void SetNext(Dispenser dispenser)
        {
            this.next = dispenser;
        }
        public void Dispense(Currency currency)
        {
            if (currency.GetAmount() >= worth)
            {
                int quotient = currency.GetAmount() / worth;
                int remainder = currency.GetAmount() % worth;
                Console.WriteLine("Dispensing: " + quotient + " in " + worth);
                if(remainder!=0 && next != null)
                {
                    next.Dispense(new Currency(remainder));
                }
            }
            else if (next != null)
            {
                next.Dispense(currency);
            }
            else
            {
                Console.WriteLine(currency.GetAmount() + " cannot be processed");  
            }
        }

       
    }
}
