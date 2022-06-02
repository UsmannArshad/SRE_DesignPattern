using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Design_Pattern
{
    public interface Dispenser
    {
        void SetNext(Dispenser dispenser);
        void Dispense(Currency currency);
    }
}
