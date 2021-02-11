using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1998, FirstName = "Serhat", LastName = "Ardic", IdentityNumber = 12345 });


            Gamer gamer2 = new Gamer();
            gamer2.BirthYear = 1998;
            gamer2.FirstName = "Serhat";
            gamer2.LastName = "Ardic";
            gamer2.IdentityNumber = 12345;


            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer2);

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Discount(gamer2);

            campaignManager.Gift(gamer2);

            campaignManager.GiftDelete(gamer2);




            

            
        }
    }
}
 