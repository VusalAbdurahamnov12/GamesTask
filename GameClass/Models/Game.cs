using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Models
{
    public abstract class Game
    {
        public string GameName { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public DateTime GameRelaseDate { get; set; }
        public bool IsMultiplayer { get; set; }

    }
}
