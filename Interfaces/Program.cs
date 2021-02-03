using Interfaces;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Serhat", LastName = "Ardic", Address = "Istanbul" });
            //PersonManager personManager1 = new PersonManager();
            //personManager1.Add(new Customer { Id = 2, FirstName = "Eymen", LastName = "Ardic", Address = "Istanbul" });
            //Customer customer2 = new Customer
            //{
            //    Id = 3,
            //    FirstName = "Beytullah",
            //    LastName = "Ardic",
            //    Address = "Istanbul",
            //};
            //PersonManager personManager2 = new PersonManager();
            //personManager2.Add(customer2);
            //Student student = new Student()
            //{
            //    Id = 4,
            //    FirstName = "Serhat",
            //    LastName = "Ardic",
            //    Department = "EEE",
            //};
            //PersonManager personManager3 = new PersonManager();
            //personManager3.Add(student);
            //CustomerManager customerManager = new CustomerManager();
            //SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            //OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            //oracleCustomerDal.Update();
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                Console.WriteLine("Wait for the update...");
                customerDal.Update();
            }

        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    
    class Customer : IPerson
    {
        public  int Id { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Id);
        }

    }
}
