﻿Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
char op = Console.ReadLine()[0];

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result;

switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Error: division by zero.");
            return;
        }
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid operator.");
        return;
}

Console.WriteLine($"Result: {result}");