using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }


        ICampaignService _campaignService;
        public GamerManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }


        IOrderService _orderService;

        public GamerManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " Added");
            }
            else
            {
                Console.WriteLine( "Validation Failed" );
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" Deleted");
        }
    }
}
