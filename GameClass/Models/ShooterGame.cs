using System;
using System.Collections.Generic;
using System.Text;
using GameClass.Interfaces;
namespace GameClass.Models
{
    internal class ShooterGame : Game, IAction
    {
        
        public override string GameName { get  ; set  ; }
        public override string Publisher { get  ; set  ; }
        public override double Price { get  ; set  ; }
        public override string GameRelaseDate { get  ; set  ; }
        public override bool IsMultiplayer { get  ; set  ; }
        public bool IsFps { get  ; set  ; }
    }
}
