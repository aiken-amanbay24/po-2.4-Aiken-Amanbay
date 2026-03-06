using System;

class Program
{
    static void Main()
    {
        // Exercise 1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2)
            Console.WriteLine("The numbers are equal");
        else if (num1 > num2)
            Console.WriteLine("The first number is greater than the second");
        else
            Console.WriteLine("The first number is less than the second");


        // Exercise 2
        Console.WriteLine("\nExercise 2:");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 5 && number < 10)
            Console.WriteLine("The number is greater than 5 and less than 10");
        else
            Console.WriteLine("Unknown number");


        // Exercise 3
        Console.WriteLine("\nExercise 3:");
        Console.Write("Enter a number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number2 == 5 || number2 == 10)
            Console.WriteLine("The number is either 5 or 10");
        else
            Console.WriteLine("Unknown number");


        // Exercise 4
        Console.WriteLine("\nExercise 4:");
        Console.Write("Enter deposit amount: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double result = 0;

        if (deposit < 100)
            result = deposit + deposit * 0.05;
        else if (deposit >= 100 && deposit <= 200)
            result = deposit + deposit * 0.07;
        else
            result = deposit + deposit * 0.10;

        Console.WriteLine("Deposit with interest: " + result);


        // Exercise 5
        Console.WriteLine("\nExercise 5:");
        Console.Write("Enter deposit amount: ");
        double deposit2 = Convert.ToDouble(Console.ReadLine());
        double result2 = 0;

        if (deposit2 < 100)
            result2 = deposit2 + deposit2 * 0.05;
        else if (deposit2 >= 100 && deposit2 <= 200)
            result2 = deposit2 + deposit2 * 0.07;
        else
            result2 = deposit2 + deposit2 * 0.10;

        result2 += 15; // bonus

        Console.WriteLine("Deposit with interest and bonus: " + result2);


        // Exercise 6
        Console.WriteLine("\nExercise 6:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }


        // Exercise 7
        Console.WriteLine("\nExercise 7:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int op = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Result: " + (a + b));
                break;
            case 2:
                Console.WriteLine("Result: " + (a - b));
                break;
            case 3:
                Console.WriteLine("Result: " + (a * b));
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
    }
}