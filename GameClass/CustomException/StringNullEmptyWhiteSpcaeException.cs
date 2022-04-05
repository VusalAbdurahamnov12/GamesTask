using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.CustomException
{
    class StringNullEmptyWhiteSpcaeException : Exception
    {
        public StringNullEmptyWhiteSpcaeException(string message) :base(message) 
        {

        }
    }
}
