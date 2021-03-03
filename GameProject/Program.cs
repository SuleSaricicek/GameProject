using GameProject.Adapters;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer{ BirthYear = new DateTime(1990, 4, 22), FirstName = "Şule", GamerId = 1, LastName = "Sarıçiçek", TcNo = 12251730674 });
            Console.ReadLine();
            
        }
    }
}
