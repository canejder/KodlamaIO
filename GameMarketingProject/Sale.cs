using System;

namespace GameMarketingProject
{
    public class Sale
    {
        public Sale(Player player, Game game)
        {
            Console.WriteLine("***\t\t\tFATURA\t\t\t***" +
                              "\nŞahsın adı     : " + player.FirstName +
                              "\nŞahsın Soyadı  : " + player.LastName +
                              "\n\nOyunun adı     : " + game.Name +
                              "\nAdet           : " + game.Count +
                              "\nTutar          : " + game.Price * game.Count + "$");
        }

        public Sale(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("***\t\t\tFATURA\t\t\t***" +
                              "\nŞahsın adı     : " + player.FirstName +
                              "\nŞahsın Soyadı  : " + player.LastName +
                              "\n\nOyunun adı     : " + game.Name +
                              "\nKampanya       : " + campaign.Id + "::" + campaign.Name +
                              "\nAdet           : " + game.Count +
                              "\nTutar          : " + game.Price * game.Count * (1-campaign.Modifier)+"$");
        }
    }
}