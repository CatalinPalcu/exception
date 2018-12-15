using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();

            myStringList.Add("C#");
            myStringList.Add("Java");
            myStringList.Add("Java Script");
            myStringList.Add("Python");

            foreach (var item in myStringList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            if (myStringList.Contains("Java"))
                myStringList.Remove("Java");

            foreach (var item in myStringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Zoo zoo1 = new Zoo();
            foreach (var item in zoo1.Animals)
            {
                Console.WriteLine($"This is a {item.Name} and is a {item.MyGender.ToString()}");
            }

            Console.WriteLine("----------stack-----------------");
            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".Net");
            myStack.Push("Sql");
            myStack.Push("Java");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            int count = myStack.Count;
            for(int i=0; i<count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.WriteLine("----------queue-----------------");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".Net");
            myQueue.Enqueue("Sql");
            myQueue.Enqueue("Java");

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            count = myQueue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }


            Console.WriteLine("----------Dictionary-----------------");
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            dict.Add("Gigi", 30.23M);
            dict.Add("Ion", 15.6M);
            dict.Add("Mos Craciun", 1500000.6M);

            foreach (var record in dict)
            {
                Console.WriteLine($"{record.Key} with the money {record.Value}");
            }

            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();

            List<ILandBound> landAnimals = new List<ILandBound>();

            landAnimals.Add(new Animal("elephant", Gender.Female));
            landAnimals.Add(new Animal("tiger", Gender.Female));
            landAnimals.Add(new Animal("zebra", Gender.Male));
            landAnimals.Add(new Animal("fox", Gender.Male));

            foreach (var animal in landAnimals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
