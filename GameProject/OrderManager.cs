using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " thanks for purschasing!!! Your ordes has complated, now you can choose your campaign.");


        }
    }
}
