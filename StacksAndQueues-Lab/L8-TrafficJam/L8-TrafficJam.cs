using System;
using System.Collections.Generic;

namespace L8_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            int n = int.Parse(Console.ReadLine());
            var carsQueue = new Queue<string>();
            int numberOfCars = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carsQueue.Count != 0)
                        {
                            numberOfCars++;
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{numberOfCars} cars passed the crossroads.");
        }
    }
}
