using System;

namespace InterfacesDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager robotManager = new Robot();
            //robotManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Update(new CustomerManager());
            projectManager.Add(new Robot());
            projectManager.Update(new Robot());

        }
    }
    interface IPersonManager
    {
        void Add();

        void Update();
    }

    class CustomerManager : IPersonManager
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
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
    }
    class Robot : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Robot Added");
        }

        public void Update()
        {
            Console.WriteLine("Robot Updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager) 
        {
            personManager.Update();
        }
    }
}
