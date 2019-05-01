namespace P05.FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] allClothesInTheBox = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> boxOfClothes = new Stack<int>(allClothesInTheBox);

            int usedRacks = 1;
            int usedRackSpace = 0;

            while (boxOfClothes.Count != 0)
            {
                if (usedRackSpace + boxOfClothes.Peek() > rackCapacity)
                {
                    usedRackSpace = 0;
                    usedRacks++;
                    usedRackSpace += boxOfClothes.Pop();
                }
                else if (usedRackSpace + boxOfClothes.Peek() <= rackCapacity)
                {
                    usedRackSpace += boxOfClothes.Pop();
                }
            }

            Console.WriteLine(usedRacks);
        }
    }
}
