using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Design_Pattern
{
    public class Currency
    {
        private int amount;
        public Currency(int amount)
        {
            this.amount = amount;
        }
        public int GetAmount()
        {
            return amount;
        }
    }
}
