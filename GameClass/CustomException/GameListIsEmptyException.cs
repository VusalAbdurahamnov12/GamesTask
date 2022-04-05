using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.CustomException
{
    class GameListIsEmptyException : Exception
    {
        public GameListIsEmptyException(string message) : base(message) 
        {

        }
    }
}
