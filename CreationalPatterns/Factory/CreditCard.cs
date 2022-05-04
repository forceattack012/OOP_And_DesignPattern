using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Factory
{
    public abstract class CreditCard
    {
        protected string Name { get; set; }
        protected string Type { get; set; }
        protected decimal Amount { get; set; }

        public CreditCard(string name, string type, decimal amount)
        {
            Name = name;
            Type = type;
            Amount = amount;
        }

        public virtual string GetAccountName() => Name;
        public virtual string GetType() => Type;
        public virtual decimal GetAmount() => Amount;
    }
}
