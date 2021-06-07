using GameProjectDemo.Business;
using GameProjectDemo.Concretes;
using GameProjectDemo.Abstract;
using System;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    //Ödevi yaparken kodlarından örnek aldığım Zeynel Toplar'a (kodlama.io) teşekkür ederim.

    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                NationalId = "12345678912",
                FirstName = "Görkem ",
                LastName = "Akan",
                DateOfBirth = new DateTime(2005, 1, 3),
                Balance = 450
            };

            Gamer gamer2 = new Gamer
            {
                NationalId = "12146587952",
                FirstName = "Engin ",
                LastName = "Demiroğ",
                DateOfBirth = new DateTime(1985, 1, 6),
                Balance = 500
            };

            Gamer gamer3 = new Gamer
            {
                NationalId = "23125469878",
                FirstName = "Alp ",
                LastName = "Vatansever",
                DateOfBirth = new DateTime(2004, 10, 8),
                Balance = 750
            };

            Gamer gamer4 = new Gamer
            {
                NationalId = "69878",
                FirstName = "Murat",
                LastName = "Şimşek",
                DateOfBirth = new DateTime(2004, 11, 15),
                Balance = 750
            };

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer3);
            gamerManager.Add(gamer4);
            Console.WriteLine("---------------------------");

            Game game1 = new Game
            {
                GameName = "CSGO",
                Price = 120
            };

            Game game2 = new Game
            {
                GameName = "GTA",
                Price = 200
            };

            Game game3 = new Game
            {
                GameName = "Europa Universalis IV",
                Price = 250
            };

            Game game4 = new Game
            {
                GameName = "Hearts of Iron IV",
                Price = 100
            };

            GameManager gameManager = new GameManager();
            gameManager.Delete(game1);
            Console.WriteLine("-------------------------");
            gameManager.Delete(game2);
            Console.WriteLine("-------------------------");
            gameManager.Update(game3);
            Console.WriteLine("-------------------------");
            gameManager.Add(game4);
            Console.WriteLine("-------------------------");


            Campaign campaign1 = new Campaign
            {
                CampaignName = "Öğrenci Kampanyası ",
                CampaignDiscount = 15
            };

            Campaign campaign2 = new Campaign
            {
                CampaignName = "Yaz Kampanyası ",
                CampaignDiscount = 30
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.DeleteCampaign(campaign1);
            campaignManager.AddCampaign(campaign2);
            Console.WriteLine("-------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game3, gamer1, campaign2);
            gameSaleManager.Sale(game2, gamer3, campaign1);

        }
    }
}
