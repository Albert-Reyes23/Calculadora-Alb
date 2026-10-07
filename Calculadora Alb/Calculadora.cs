using System;

bool Start = true;

while (Start)
{
    Console.WriteLine("Welcome to the program ");
    Console.WriteLine("1 for Add");
    Console.WriteLine("2 for Subtract");
    Console.WriteLine("3 for Multiply");
    Console.WriteLine("4 for Divide");
    Console.WriteLine("5 for Check Student Grade");
    Console.WriteLine("and 6 for Exit");
    Console.Write("Choose an option: ");

    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        Console.Write("Enter first number ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Result: " + (num1 + num2));
    }
    else if (option == 2)
    {
        Console.Write("Enter first number ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Result " + (num1 - num2));
    }
    else if (option == 3)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Result " + (num1 * num2));
    }
    else if (option == 4)
    {
        Console.Write("Enter first number ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("You cannot divide by zero ");
        }
        else
        {
            Console.WriteLine("Result " + (num1 / num2));
        }
    }
    else if (option == 5)
    {
        Console.Write("Enter student grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade >= 70)
        {
            Console.WriteLine("The student passed");
        }
        else
        {
            Console.WriteLine("The student failed");
        }
    }
    else if (option == 6)
    {
        Console.WriteLine("Program closed, thanks for using it.....");
        Start = false;
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }

    Console.WriteLine();
}