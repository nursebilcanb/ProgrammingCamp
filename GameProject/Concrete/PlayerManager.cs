using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class PlayerManager : IPlayerService
    {
        public void Register(Player player)
        {
            Console.WriteLine($"{player.FirstName} {player.LastName} registered.");
        }

        public void Update(Player player)
        {
            Console.WriteLine($"{player.FirstName} {player.LastName} updated.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine($"{player.FirstName} {player.LastName} deleted.");
        }
    }
}
