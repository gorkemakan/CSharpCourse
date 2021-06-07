using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
