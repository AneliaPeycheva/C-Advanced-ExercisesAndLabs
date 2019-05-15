using System;
using System.Collections;
using System.Collections.Generic;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stringReverser = new Stack<char>();
            foreach (var character in input)
            {
                stringReverser.Push(character);
            }
            while (stringReverser.Count>0)
            {
                Console.Write(stringReverser.Pop()); 
            }
            Console.WriteLine();
        }
    }
}
