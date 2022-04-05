using System;
using System.Collections.Generic;
using System.Text;
using GameClass.Interfaces;
namespace GameClass.Models
{
    internal class StrategyGame : Game, IStrategy
    {
        private string _gameName;
        private string _publisher;
        private string _gameRelaseDate;
        private double _price;
        private string _mapName;
        public string MapName
        {
            get
            {
                return _mapName;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _mapName = value;
                else throw new Exception();
            }
        }
        public override string GameName
        {
            get
            {
                return _gameName;
            }

            set
            {
                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value)) _gameName = value;
                else throw new Exception();
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
                else throw new Exception();
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
                else throw new Exception();
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
                else throw new Exception();
            }
        }
        public override bool IsMultiplayer { get ; set ; }
        public StrategyGame(string mapName, string gameName, string publisher, double price, string gameRelaseDate, bool isMultiplayer)
        {
            GameName = gameName;
            Publisher = publisher;
            Price = price;
            GameRelaseDate = gameRelaseDate;
            IsMultiplayer = isMultiplayer;
            MapName = mapName;
        }
    }
}
