using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Exceptions
{
    public  class PriceLimitException:Exception
    {
        public PriceLimitException(string message) : base(message) { }

    }
}
