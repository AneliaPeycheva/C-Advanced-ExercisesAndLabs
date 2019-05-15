using System;
using System.Collections.Generic;
using System.Linq;

namespace L3_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 + 5 + 10 - 2 - 1
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            var calculatorStack = new Stack<string>(input.Reverse());
            while (calculatorStack.Count>1)
            {
                int firstOperand = int.Parse(calculatorStack.Pop());
                char operation = char.Parse(calculatorStack.Pop());
                int secondOperand = int.Parse(calculatorStack.Pop());
                switch (operation)
                {
                    case '+':
                        calculatorStack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case '-':
                        calculatorStack.Push((firstOperand - secondOperand).ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(calculatorStack.Pop());
        }        
    }
}
