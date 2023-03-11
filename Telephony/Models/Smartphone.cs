using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IPhone, IWeb
    {
        public string CallNumbers(string number)
        {
            if (!number.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {number}";
        }
        
        public string Browse(string site)
        {
            if (site.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {site}!";
        }

    }
}
