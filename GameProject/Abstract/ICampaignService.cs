using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService 
    { 
        int Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
