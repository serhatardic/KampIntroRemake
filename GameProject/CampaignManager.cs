using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Discount(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" %40 discount is activated!!!");
        }

        public void DiscountUpdate(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" your discount ratio has increased to %60!!!");
        }
        public void DiscountDelete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " your discount has deleted!!!");
        }

        public void Gift(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Buy 1, Get 1 is activated!!!");
        }
        public void GiftUpdate(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Buy 1, Get 1 is activated, now you get 2 games from shop!!!");
        }
        public void GiftDelete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Buy 1, Get 1 is deactivated, now you may cry!!!");
        }
    }
}
