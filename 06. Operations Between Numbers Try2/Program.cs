using System;

namespace _06.Operations_Between_Numbers_Try2
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
                        Console.Write(outputMessage);
                    }
                    else
                    {
                        operationResult = (double)n1 / (double)n2;
                        outputMessage = $"{n1} / {n2} = {operationResult:F2}";
                        Console.Write(outputMessage);
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        outputMessage = $"Cannot divide {n1} by zero";
                        Console.Write(outputMessage);
                    }
                    else
                    {
                        operationResult = n1 % n2;
                        outputMessage = $"{n1} % {n2} = {operationResult}";
                        Console.Write(outputMessage);
                    }
                    break;

                case '+':
                    operationResult = n1 + n2;
                    outputMessage = $"{n1} + {n2} = {operationResult}";
                    if (operationResult % 2 == 0)
                    {
                        Console.WriteLine($"{outputMessage} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{outputMessage} - odd");
                    }
                    break;
                case '-':
                    operationResult = n1 - n2;
                    outputMessage = $"{n1} - {n2} = {operationResult}";
                    if (operationResult % 2 == 0)
                    {
                        Console.WriteLine($"{outputMessage} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{outputMessage} - odd");
                    }
                    break;
                case '*':
                    operationResult = n1 * n2;
                    outputMessage = $"{n1} * {n2} = {operationResult}";
                    if (operationResult % 2 == 0)
                    {
                        Console.WriteLine($"{outputMessage} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{outputMessage} - odd");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

        }
    }
}
