using System;

namespace _06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char _operator = char.Parse(Console.ReadLine());

            string outputMessage;
            double operationResult = 0.0;

            switch (_operator)
            {
                case '/':
                    if (n2 == 0)
                    {
                        outputMessage = $"Cannot divide {n1} by zero";
                    }
                    else
                    {
                        operationResult = (double)n1 / (double)n2;
                        outputMessage = $"{n1} / {n2} = {operationResult}";
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        outputMessage = $"Cannot divide {n1} by zero";
                    }
                    else
                    {
                        operationResult = n1 % n2;
                        outputMessage = $"{n1} % {n2} = {operationResult}";
                    }
                    break;
                case '+':
                    operationResult = n1 + n2;
                    outputMessage = $"{n1} + {n2} = {operationResult}";
                    break;
                case '-':
                    operationResult = n1 - n2;
                    outputMessage = $"{n1} - {n2} = {operationResult}";
                    break;
                case '*':
                    operationResult = n1 * n2;
                    outputMessage = $"{n1} * {n2} = {operationResult}";
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            Console.Write(outputMessage);

            switch (_operator)
            {
                case '+':
                case '-':
                case '*':
                    if (operationResult % 2 == 0)
                    {
                        Console.WriteLine(" - even");
                    }
                    else
                    {
                        Console.WriteLine(" - odd");
                    }
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
