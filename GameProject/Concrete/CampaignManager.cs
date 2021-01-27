
using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {   
        public int Add(Player player)
        {
            int campaignPrice = 10;
            Console.WriteLine($"There is a {campaignPrice}$ campaign for {player.FirstName} {player.LastName}");
            return campaignPrice;
        }

        public void Update(Player player)
        {
            int updatePrice = 15;
            Console.WriteLine($"There is a {updatePrice}$ campaign at our games {player.FirstName}{player.LastName} will choose.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine($"This campaign which has 10$ deleted for {player.FirstName} {player.LastName}");
        }

       
    }
}
