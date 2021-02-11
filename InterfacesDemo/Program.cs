using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] 
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] 
            {
                new Manager(),
                new Worker(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            IGetPaid[] getPaids = new IGetPaid[]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var getPaid in getPaids)
            {
                getPaid.GetPaid();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetPaid
    {
        void GetPaid();
    }
    class Manager : IWorker, IEat, IGetPaid
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetPaid()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, IGetPaid
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetPaid()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
