using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class CampaignManager : ICampainService
    {
        public void AddDiscount(Campaign campaign)
        {
            System.Console.WriteLine("Discount added.");
        }

        public void DeleteDiscount(Campaign campaign)
        {
            System.Console.WriteLine("Discount deleted.");
        }

        public void UpdateDiscount(Campaign campaign)
        {
            System.Console.WriteLine("Discount updated.");
        }
        public double ApplyDiscount(Games game, Campaign campaign)
        {   
            return ((game.gamePrice * (100 - campaign.DiscountRate) / 100));
        }

    }
}