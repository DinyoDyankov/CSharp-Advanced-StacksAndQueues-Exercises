namespace P08.BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var parentheses = new Stack<char>();

            bool balanced = true;

            if (input.Length != 0)
            {
                foreach (var p in input)
                {
                    switch (p)
                    {

                        case '(':
                            parentheses.Push(p);
                            break;
                        case '[':
                            parentheses.Push(p);
                            break;
                        case '{':
                            parentheses.Push(p);
                            break;
                        case ')':
                            if (!parentheses.Any() || parentheses.Pop() != '(')
                            {
                                balanced = false;
                            }
                            break;
                        case ']':
                            if (!parentheses.Any() || parentheses.Pop() != '[')
                            {
                                balanced = false;
                            }
                            break;
                        case '}':
                            if (!parentheses.Any() || parentheses.Pop() != '{')
                            {
                                balanced = false;
                            }
                            break;
                    }
                }
            }

            if (balanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
