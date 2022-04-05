using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Exceptions
{
    public  class NotAvaiableException:Exception
    {
        public NotAvaiableException(string message) : base(message) { }
    }
}
