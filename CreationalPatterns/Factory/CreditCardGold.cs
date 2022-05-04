using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    public class CreditCardGold : CreditCard
    {
        public CreditCardGold(string name, string type, decimal amount) : base(name, type, amount)
        {
        }

        public override string GetAccountName()
        {
            return $"Gold Card your Name is : {Name}";
        }
    }
}
