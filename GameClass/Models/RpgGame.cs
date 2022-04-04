using System;
using System.Collections.Generic;
using System.Text;
using GameClass.Interfaces;
namespace GameClass.Models
{
    internal class RpgGame : Game, IAction, IRpg
    {
        private int _level;
        public int Level
        {
            get 
            { 
                return _level;
            }
            set 
            {
                if (value >= 0 && value <= 1000) _level = value;
                else throw new Exception();
            }
        }
        public int WantedLevel {
            get
            {
                return _level;
            }
            set
            {
                if (value >= 0 && value <= 1000) _level = value;
                else throw new Exception();
            }
        }
        public bool IsFps { get; set; }
        public override string GameName { get; set; }
        public override string Publisher { get; set; }
        public override double Price { get; set; }
        public override string GameRelaseDate { get; set; }
        public override bool IsMultiplayer { get; set; }

        public int LeftLevel()
        {
            throw new NotImplementedException();
        }
    }
}
