using System;
using System.Collections.Generic;
using System.Linq;

namespace L2_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();           
            var sumStack = new Stack<int>();
            foreach (var item in inputArray)
            {
                sumStack.Push(item);
            }
            string input = string.Empty;
            int sum = 0;
            while ((input=Console.ReadLine())!= "end")
            {
                string[] inputInParts = input.Split();
                string command = inputInParts[0];
                switch (command)
                {
                    case "add":
                        int firstOperand = int.Parse(inputInParts[1]);
                        int secondOperand = int.Parse(inputInParts[2]);
                        sumStack.Push(firstOperand);
                        sumStack.Push(secondOperand);
                        break;
                    case "remove":
                        int numbersToRemove= int.Parse(inputInParts[1]);
                        if (numbersToRemove>sumStack.Count)
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < numbersToRemove; i++)
                            {
                                sumStack.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            while (sumStack.Count>0)
            {
                int digit = sumStack.Pop();
                sum += digit;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
