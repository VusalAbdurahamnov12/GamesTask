using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Models
{
    public abstract class Game
    {
        public abstract string GameName { get; set; }
        public abstract string Publisher { get; set; }
        public abstract double Price { get; set; }
        public abstract string GameRelaseDate { get; set; }
        public abstract bool IsMultiplayer { get; set; }

    }
}
