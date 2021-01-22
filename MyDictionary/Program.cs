using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary1 = new MyDictionary<string, int>();
            myDictionary1.Add("Serhat Ardic", 1);
            Console.WriteLine(myDictionary1.Count);

        }
    }
}
