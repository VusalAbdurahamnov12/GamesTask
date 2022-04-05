using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.CustomException
{
    class LevelException : Exception
    {
        public LevelException(string message) : base(message)
        {

        }
    }
}
