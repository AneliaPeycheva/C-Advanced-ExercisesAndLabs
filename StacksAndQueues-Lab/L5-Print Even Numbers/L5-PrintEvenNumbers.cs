using System;
using System.Collections.Generic;
using System.Linq;

namespace L5_Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var numbersQueue = new Queue<int>(input);
            while (numbersQueue.Count>1)
            {
                int number = numbersQueue.Dequeue();
                if (number%2==0)
                {
                    Console.Write($"{number}, ");
                }                
            }
            if (numbersQueue.Peek() % 2 == 0)
            {
                Console.WriteLine(numbersQueue.Dequeue());
            }                       
        }
    }
}
