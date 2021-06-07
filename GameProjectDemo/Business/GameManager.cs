using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Business
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi, \nFiyatı: " + game.Price);
 
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun kaldırıldı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi.");
        }
    }
}
