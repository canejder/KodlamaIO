using System;
using GameMarketingProject.API;

namespace GameMarketingProject.Business
{
    public class PlayerManager : IRegistryManager
    {
        Player _player;
        private Validator _validator = new Validator();

        public PlayerManager()
        {
            
        }

        public void Create(IManagable player)
        {
            _player = (Player) player;
            if (_validator.Validate(_player))
            {
                Console.WriteLine("Oyuncu kaydı oluşturuldu: " + _player.LastName);
            }
            else
            {
                Console.WriteLine("Lütfen kimlik bilgilerinizle doğrulama yapın.");
            }

        }

        public void Update(IManagable player)
        {
            _player = (Player) player;

            Console.WriteLine("Oyuncu kaydı güncellendi: " + _player.LastName);
        }

        public void Delete(IManagable player)
        {
            _player = (Player) player;

            Console.WriteLine("Oyuncu silindi: " + _player.LastName);
        }
    }
}