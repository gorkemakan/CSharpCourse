using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Business
{
    class CampaignManager:ICampaignService
    {


        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " %" + campaign.CampaignDiscount);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası güncellendi.");
            Console.WriteLine("Yeni durum: " + "%" + campaign.CampaignDiscount);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası silindi.");
        }
    }
}
