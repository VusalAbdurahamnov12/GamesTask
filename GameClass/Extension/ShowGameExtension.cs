using GameClass.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Extension
{
    public static class ShowGameExtension
    {
        public static void ShowGameInfo(this Game game)
        {
            foreach (var item in game.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(game)}");
            }
        }
    }
}
