using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class GoogleApi
    {
        public Google FetechGoogleData()
        {
            return new Google()
            {
                AccountName = "Joe",
                AccountPassword = "1234",
                Image = "https://google.com/image.jpg",
                Address = "BKK 10120"
            };
        }
    }

    public class Google
    {
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
    }
}
