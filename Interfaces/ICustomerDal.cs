using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to Sql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from Sql");
        }

        public void Update()
        {
            Console.WriteLine("Update in Sql");
        }
    };

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Update in Oracle");
        }
    };
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) 
        {
            customerDal.Add();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    };
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to MySql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted from MySql");
        }

        public void Update()
        {
            Console.WriteLine("Update in MySql");
        }
    };

}


