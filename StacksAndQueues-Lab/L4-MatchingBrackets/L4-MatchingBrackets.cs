using System;
using System.Collections.Generic;

namespace L4_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var expresionStack = new Stack<int>(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    expresionStack.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex= expresionStack.Pop();
                    int endIndex = i;
                    Console.WriteLine(input.Substring(startIndex,endIndex-startIndex+1));
                }                
            }
        }
    }
}
