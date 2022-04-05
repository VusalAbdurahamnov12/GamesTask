using System;
using System.Collections.Generic;
using System.Text;
using GameClass.Interfaces;
using GameClass.Extension;
using GameClass.CustomException;
namespace GameClass.Models
{
    internal class RpgGame : Game, IAction, IRpg
    {
        private int _level;
        private string _gameName;
        private string _publisher;
        private string _gameRelaseDate;
        private double _price;
        public int Level
        {
            get 
            { 
                return _level;
            }
            set 
            {
                if (value >= 0 && value <= 1000) _level = value;
                else throw new LevelException("This cant be negative or higher than 1000 lvl");
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
                else throw new LevelException("This cant be negative or higher than 1000 lvl");
            }
        }
        public bool IsFps { get; set; }
        public override string GameName
        {
            get
            {
                return _gameName;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _gameName = value;
                else throw new StringNullEmptyWhiteSpcaeException("This cant be null , whitespace or empty");
            }
        }
        public override string Publisher
        {
            get
            {
                return _publisher;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _publisher = value;
                else throw new StringNullEmptyWhiteSpcaeException("This cant be null , whitespace or empty");
            }
        }
        public override double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0 && value <= 1000) _price = value;
                else throw new PriceException("This cant be negative or higher than 1000 $");
            }
        }
        public override string GameRelaseDate
        {
            get
            {
                return _gameRelaseDate;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _gameRelaseDate = value;
                else throw new StringNullEmptyWhiteSpcaeException("This cant be null , whitespace or empty");
            }
        }
        public override bool IsMultiplayer { get; set; }

        public RpgGame(string gameName,string publisher, double price, string gameRelaseDate, bool isMultiplayer)
        {
            GameName = gameName;
            Publisher = publisher;
            Price = price;
            GameRelaseDate = gameRelaseDate;
            IsMultiplayer = isMultiplayer;
        }

        public int LeftLevel()
        {
            if (WantedLevel < Level) throw new Exception();
            return WantedLevel - Level;
        }
    }
}
