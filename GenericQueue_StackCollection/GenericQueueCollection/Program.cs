using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericQueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { Code = "IND", Name = "India", Capital = "Delhi" };
            Country country2 = new Country() { Code = "USA", Name = "United States", Capital = "Washington" };
            Country country3 = new Country() { Code = "UK", Name = "United Kingdom", Capital = "Londom" };
            Country country4 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };
            Queue<Country> queuecountries = new Queue<Country>();
            
            queuecountries.Enqueue(country1);
            queuecountries.Enqueue(country2);
            queuecountries.Enqueue(country3);
            queuecountries.Enqueue(country4);//to add objects to the queue we use enqueue.

            queuecountries.Dequeue();//to remove object at the begining of the queue.
            foreach (Country c in queuecountries)
            {
                Console.WriteLine(c.Code + "--" + c.Name + "--" + c.Capital);
            }
           Country c1 =  queuecountries.Peek();
           Console.WriteLine(c1.Code + "****" + c1.Name + "****" + c1.Capital);

           if (queuecountries.Contains(country2))
           {
               Console.WriteLine("country2 exists");
           }
           Stack<Country> stackcountries = new Stack<Country>();
           stackcountries.Push(country1);
           stackcountries.Push(country2);
           stackcountries.Push(country3);
           stackcountries.Push(country4);
           stackcountries.Pop();
           foreach (Country c in stackcountries)
           {
               Console.WriteLine(c.Code + "--" + c.Name + "--" + c.Capital);
           }
           Country c2 = stackcountries.Peek();
           Console.WriteLine(c2.Code + "****" + c2.Name + "****" + c2.Capital);

           if (stackcountries.Contains(country2))
           {
               Console.WriteLine("country2 exists");
           }

        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }

    }
}
