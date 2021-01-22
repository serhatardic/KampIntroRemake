using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
        //   //ex for value type
        //    int sayi1 = 10;
        //    int sayi2 = 20;
        //    sayi1 = sayi2;
        //    sayi2 = 100;
        //    Console.WriteLine(sayi1);
        //    //ex for reference type
        //    int[] sayilar1 = new int[] { 1, 2, 3 };
        //    int[] sayilar2 = new int[] { 10, 20, 30 };
        //    sayilar1 = sayilar2;
        //    sayilar2[0] = 1000;
        //    Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            
            person1.FirstName = "Serhat";
            person2 = person1;
            person1.FirstName = "Ceren";
            //Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Gamze";
            Person person3 = customer;
            customer.FirstName = "Derin";
            //Console.WriteLine(person3.FirstName);
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //customer.CreditCardNumber = "1111 2222 3333 4444";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);
            personManager.Add(person3);
        }  
    
    }
    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

    