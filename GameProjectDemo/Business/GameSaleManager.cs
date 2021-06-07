using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    public class GameSaleManager:IGameSaleService
    {

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            if (gamer.Balance < game.Price)
            {
                Console.WriteLine("Oyunu satın alacak paranız bulunmamaktadır.");
            }
            else
            {
                double newPrice = game.Price - (game.Price * (campaign.CampaignDiscount / 100));
                Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " kişisine satıldı.");
                Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " TL");
                Console.WriteLine("Uygulanan İndirim fiyatı : " + game.Price * (campaign.CampaignDiscount / 100) + " TL");

            }
        }
    }
}
