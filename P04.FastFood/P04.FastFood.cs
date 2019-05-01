namespace P04.FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] ordersInput = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var allOrdersQueue = new Queue<int>(ordersInput);

            int allOrdersCount = allOrdersQueue.Count;
            int counter = 0;

            for (int i = 0; i < allOrdersCount; i++)
            {
                if (foodQuantity - allOrdersQueue.Peek() >= 0)
                {
                    foodQuantity -= allOrdersQueue.Peek();
                    allOrdersQueue.Dequeue();
                    counter++;
                }
            }

            Console.WriteLine(ordersInput.Max());

            if (counter == allOrdersCount)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", allOrdersQueue)}");
            }
        }
    }
}
