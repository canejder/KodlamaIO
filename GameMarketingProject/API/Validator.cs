using System;
using System.Threading.Tasks;

namespace GameMarketingProject.API
{
    public class Validator
    {
        private Player _player;

        public Validator()
        {
            CheckWebServices();
        }

        private void CheckWebServices()
        {
            Console.WriteLine("Servisler kontrol ediliyor...");
            Console.WriteLine("Bağlantı kuruluyor...");
            Console.WriteLine("Servislerle bağlantı kuruldu.");
        }

        private void CheckCitizenName()
        {
            Console.WriteLine("İsim ve soyisim bilgisi kontrol ediliyor");
            var nameLength = _player.FirstName.Length > 3 ? true : false;
            if (nameLength)
            {
                Console.WriteLine("Doğrulandı.");
            }
            else
            {
                Console.WriteLine("Doğrulanamadı.");
            }
        }

        private void CheckCitizenDoB()
        {
            Console.WriteLine("Doğum tarihi kontrol ediliyor...");
            var birthDate = _player.DoB.Year < 1970 ? true : false;
            if (birthDate)
            {
                Console.WriteLine("Doğrulandı.");
            }
            else
            {
                Console.WriteLine("Doğrulanamadı.");
            }
        }

        bool CheckCitizenshipNumber()
        {
            Console.WriteLine("Kimlik numarası doğrulanıyor...");
            var citizenNumberLength = _player.CitizenshipNumber.Length == 11 ? true : false;
            if(citizenNumberLength)
            {
                Console.WriteLine("Kimlik doğrulaması tamamlandı.");
                return true;
            }
            else
            {
                Console.WriteLine("Kimlik doğrulanamadı.");
                return false;
            }
        }

        public bool Validate(Player player)
        {
            _player = player;
            CheckCitizenName();
            CheckCitizenDoB();
            return CheckCitizenshipNumber();

        }
    }
}