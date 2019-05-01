namespace P02.BasicQueueOperations
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

            var queues = new Queue<int>();

            for (int i = 0; i < firstLineOfInput[0]; i++)
            {
                queues.Enqueue(elementsToPushToTheStack[i]);
            }

            for (int i = 0; i < firstLineOfInput[1]; i++)
            {
                queues.Dequeue();
            }

            if (queues.Contains(firstLineOfInput[2]))
            {
                Console.WriteLine("true");
            }
            else if (queues.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queues.Min());
            }

        }
    }
}
