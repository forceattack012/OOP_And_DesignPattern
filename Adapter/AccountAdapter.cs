using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AccountAdapter : IAccountAdapter
    {
        public AccountInfo GetAccountInfo()
        {
            var adaptee = new GoogleApi().FetechGoogleData();

            return new AccountInfo
            {
                Name = adaptee.AccountName,
                Address = adaptee.Address,
                Password = adaptee.AccountPassword
            };
        }
    }
}
