using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    public static class CreditCardFactory
    {
        public static CreditCard? CreateCreditCard(string type, string name, decimal amount)
        {
            CreditCard? creditCard = null;

            if(type == "Gold")
            {
                creditCard = new CreditCardGold(type, name, amount);
            }
            else if(type == "Pattinum")
            {
                creditCard = new CreditCardPattinum(type, name, amount);
            }

            return creditCard;
        }
    }
}
