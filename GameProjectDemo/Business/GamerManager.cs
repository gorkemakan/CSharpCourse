using GameProjectDemo.Abstract;
using GameProjectDemo.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class GamerManager:IGamerService
    {


        private IPersonCheckService _personCheckService;

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu eklendi: " + gamer.FirstName + gamer.LastName);
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu eklenirken bilgilerde bir hata oluştu.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.FirstName + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgisi güncellendi: " + gamer.FirstName + gamer.LastName);
        }

    }
}
