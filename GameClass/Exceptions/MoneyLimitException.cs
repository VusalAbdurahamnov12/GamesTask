using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Exceptions
{
    public class MoneyLimitException:Exception
    {
        public MoneyLimitException(string message) : base(message) { }
    }
}
