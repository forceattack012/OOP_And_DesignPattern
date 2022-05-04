using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    public class CreditCardPattinum : CreditCard
    {
        public CreditCardPattinum(string name, string type, decimal amount) : base(name, type, amount)
        {

        }

        public override string GetAccountName()
        {
            return $"Patinum Card your Name is : {Name}";
        }
    }
}
