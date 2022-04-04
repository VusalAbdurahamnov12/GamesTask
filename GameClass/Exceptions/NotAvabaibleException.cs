using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Exceptions
{
    public  class NotAvabaibleException:Exception
    {
        public NotAvabaibleException(string message) : base(message) { }
    }
}
