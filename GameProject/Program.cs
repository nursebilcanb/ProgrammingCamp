using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player {Id =1, FirstName ="Nursebil", LastName="Canbolat", PlayerNickName="abcd",NationalityId="11111111111", DateOfBirth= "2001.6.5" };

            IPlayerCheckService playerCheckService = new PlayerCheckManager();
            bool result = playerCheckService.CheckIfRealPerson(player);

            if (result)
            {
                SalesManager salesManager = new SalesManager();
                salesManager.Sale(player);
            }
            else
            {
                Console.WriteLine("Invalid person/player.");
            }
            


            
        }
    }
}
