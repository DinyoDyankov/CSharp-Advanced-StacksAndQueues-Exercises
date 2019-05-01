namespace P07.TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            var allPumps = new Queue<int[]>();

            for (int i = 0; i < pumpsCount; i++)
            {
                allPumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            for (int i = 0; i < allPumps.Count; i++)
            {
                int fuelInTheTank = 0;
                var current = allPumps.Peek();
                var circleCompleted = true;

                for (int j = 0; j < allPumps.Count; j++)
                {
                    fuelInTheTank += current[0];

                    if (fuelInTheTank < current[1])
                    {
                        circleCompleted = false;

                        for (int k = allPumps.Count - j + 1; k > 0; k--)
                        {
                            allPumps.Enqueue(allPumps.Dequeue());
                        }
                        break;
                    }

                    fuelInTheTank -= current[1];
                    allPumps.Enqueue(allPumps.Dequeue());
                    current = allPumps.Peek();
                }

                if (circleCompleted)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
