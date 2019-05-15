using System;
using System.Collections.Generic;

namespace L6_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            var customersQueue = new Queue<string>();
            while ((input = Console.ReadLine())!= "End")
            {
                if (input=="Paid")
                {
                    while(customersQueue.Count>0)
                    {
                        Console.WriteLine(customersQueue.Dequeue());
                    }
                }
                else
                {
                    customersQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{customersQueue.Count} people remaining.");
        }        
    }
}
