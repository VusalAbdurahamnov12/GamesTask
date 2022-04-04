using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Models
{
    internal class Library
    {
        private Game[] myGames = new Game[0];
        public void ShowAllGames()
        {
            foreach (Game game in myGames)
            {
                Console.WriteLine(game.GameName );
            }
        }
        public void ShowSpecialTypeGames<T>()
        {
            foreach (Game item in myGames)
            {
                if(item is T)
                {

                    Console.WriteLine(item.GameName);
                }
            }
        }


    }
}
