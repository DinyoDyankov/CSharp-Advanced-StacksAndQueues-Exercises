namespace P01.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            int[] firstLineOfInput = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] elementsToPushToTheStack = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < firstLineOfInput[0]; i++)
            {
                stack.Push(elementsToPushToTheStack[i]);
            }

            for (int i = 0; i < firstLineOfInput[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(firstLineOfInput[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
