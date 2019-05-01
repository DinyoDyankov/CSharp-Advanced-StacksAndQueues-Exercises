namespace P03.MaxAndMinElement
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
       {
            int numberOfQueries = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] commandInput = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (commandInput[0] == 1)
                {
                    stack.Push(commandInput[1]);
                }
                else if (commandInput[0] == 2 && stack.Count != 0)
                {
                    stack.Pop();
                }
                else if (commandInput[0] == 3 && stack.Count != 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (commandInput[0] == 4 && stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }

            }

            Console.WriteLine(string.Join(", ", stack));
       }
    }
}
