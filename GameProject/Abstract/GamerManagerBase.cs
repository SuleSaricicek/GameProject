using GameProject.Entities;
using System;

namespace GameProject
{
    public abstract class GamerManagerBase : IGamerManager
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıl eklendi:"+ gamer.FirstName + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}