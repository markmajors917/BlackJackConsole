using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    class CreditCard
    {
        private string _number;

        public string Number
        {
            get { return _number; }
            // (value - string)
            set
            {
                // Only change the value of _number
                // If legnth of value is at least 16
                int legnthOfValue = value.Length;
                if (legnthOfValue == 16)
                    _number = value;
                {
                    _number = value;
                }
            }
        }
    }
}
