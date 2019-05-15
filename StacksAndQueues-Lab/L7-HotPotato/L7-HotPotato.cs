using System;
using System.Collections.Generic;

namespace L7_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);
            while (queue.Count!=1)
            {
                for (int i = 1; i < n; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
