using System;
using System.Collections.Generic;
using System.Text;
using GameClass.CustomException;
namespace GameClass.Models
{
    internal class Library
    {
        private Game[] myGames = new Game[0];
        public Game this[int index]
        {
            get { return myGames[index]; }
            set { myGames[index] = value; }
        }
        public void ShowAllGames()
        {
            if (myGames.Length == 0) throw new GameListIsEmptyException("There is no game!");
            foreach (Game game in myGames)
            {
                Console.WriteLine(game.GameName);
            }
        }
        public void ShowSpecialTypeGames<T>()
        {
            if (myGames.Length == 0) throw new GameListIsEmptyException("There is no game!");
            foreach (Game item in myGames)
            {
                if (item is T)
                {
                    Console.WriteLine(item.GameName);
                }
            }
        }
    }
}
