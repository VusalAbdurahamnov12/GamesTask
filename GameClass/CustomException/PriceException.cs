using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.CustomException
{
    class PriceException :Exception
    {
        public PriceException(string message):base(message)
        {

        }
    }
}
