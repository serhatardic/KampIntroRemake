using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            //1.way
            Customer customer = new Customer();
            customer.City = "Istanbul";
            customer.FirstName = "Serhat";
            customer.LastName = "Ardic";
            customer.Id = 1;
            //2. way
            Customer customer2 = new Customer()
            {
                City = "Karaman", Id = 2, FirstName = "Eymen", LastName = "Ardic"             
            };

            Console.WriteLine(customer2.FirstName + customer2.LastName);

        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated");
        }
    }
}
