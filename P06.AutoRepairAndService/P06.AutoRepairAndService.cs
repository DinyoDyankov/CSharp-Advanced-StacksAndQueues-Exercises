namespace P06.AutoRepairAndService
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] carsInTheQueue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> carsForService = new Queue<string>(carsInTheQueue);

            Stack<string> servicedCars = new Stack<string>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Service")
                {
                    if (carsForService.Count == 0)
                    {
                        continue;
                    }
                    Console.WriteLine($"Vehicle {carsForService.Peek()} got served.");
                    servicedCars.Push(carsForService.Dequeue());
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servicedCars));
                }
                else
                {
                    string[] carToCheckIfServiced = command.Split('-');

                    string currentCarToCheck = carToCheckIfServiced[1];

                    if (carsForService.Contains(currentCarToCheck))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else if (servicedCars.Contains(currentCarToCheck))
                    {
                        Console.WriteLine("Served.");
                    }
                }
            }

            if (carsForService.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsForService)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servicedCars)}");
        }
    }
}
