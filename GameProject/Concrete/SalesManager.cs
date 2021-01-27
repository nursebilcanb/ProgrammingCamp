using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public  class SalesManager : CampaignManager,ISalesDal
    {
        public void Sale(Player player)
        {
            List<string> games = new List<string> {"Assain's Creed", "League of Legends","Call of Duty","WolfTeam"};

            Console.Write($"Our available games for {player.FirstName} : " );
            foreach (var game in games)
            {
                Console.Write(game + "-");
            }

            int gamePrice = 25;
            Console.WriteLine("\nPrices of all our games are 25$.");

            foreach (var game in games)
            {
                Console.WriteLine($"{game} : 25$"); 
            }

            int sales = SalesCampaign(player);
            int salesCampaign = gamePrice - sales;

            Console.WriteLine($"Price of Sales Campaign of Game : {salesCampaign}$");

        }

      public int SalesCampaign(Player player)
        {
            CampaignManager campaignManager = new CampaignManager();
            int price = campaignManager.Add(player);
            return price;
        }

     
    }


}

