namespace P09.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            var text = new Stack<string>();
            text.Push("");

            for (int i = 0; i < numberOfOperations; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                switch (command)
                {
                    case "1":
                        string currentText = text.Peek() + input[1];
                        text.Push(currentText);
                        break;
                    case "2":
                        string previousText = text.Peek();
                        int elementsToRemove = int.Parse(input[1]);
                        string newString = previousText.Substring(0, previousText.Length - elementsToRemove);
                        text.Push(newString);
                        break;
                    case "3":
                        string allTheText = text.Peek();
                        int indexToReturn = int.Parse(input[1]);
                        Console.WriteLine(allTheText[indexToReturn - 1]);
                        break;
                    case "4":
                        text.Pop();
                        break;
                }
            }
        }
    }
}
