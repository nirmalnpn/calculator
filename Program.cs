using System;

class Program
{
    static void Main()
    {
        Greet();
        string userInput = "";
        while (userInput.ToLower() != "end")
        {
            ShowMenu();
            int userProvidedInput = int.Parse(Console.ReadLine());
            {
                if (userProvidedInput == 1)
                {
                    int addResult = 0;
                    Addition(ref addResult);
                    Console.WriteLine($"The sum is ={addResult}");
                }
                else if (userProvidedInput == 2)
                {
                    int subResult = 0;
                    Subtraction(ref subResult);
                    Console.WriteLine($"the sub is={subResult}");
                }
                else if (userProvidedInput == 3)
                {
                    int mulResult = 0;
                    Multiplication(ref mulResult);
                    Console.WriteLine($"the mul is={mulResult}");
                }
                else if (userProvidedInput == 4)
                {
                    double divdResult = 0;
                    Division(ref divdResult);
                    Console.WriteLine($"the divd is={divdResult}");
                }
                else if (userProvidedInput == 5)
                {
                    MultiplicationTable();
                }
                else if (userProvidedInput == 6)
                {
                    DisplaySequence();
                }
                if (userProvidedInput == 7)
                {
                    Console.WriteLine("Closing the program...");
                    userInput = "end";
                }
            }
        }
    }
    static void Greet()
    {
        Console.WriteLine("Hello, welcome to my Calculator");
        Console.WriteLine("-------------------------------");
        DateTime currenttime = DateTime.Now;
        if (currenttime.Hour < 12)
        {
            Console.WriteLine("Good moring");
            Console.WriteLine("-------------------------------");
        }
        else if (currenttime.Hour > 12 && currenttime.Hour < 6)
        {
            Console.WriteLine("Good afternoon");
            Console.WriteLine("-------------------------------");
        }
        else
        {
            Console.WriteLine("Good evening");
            Console.WriteLine("-------------------------------");
        }
        Console.WriteLine(currenttime);
    }
    static void ShowMenu()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("PLease select the below option for operation");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.multiplication");
        Console.WriteLine("4.division");
        Console.WriteLine("5.multiplicationTable of given number");
        Console.WriteLine("6.display\"1, 1, 2, 3, 4, 5, 6, 7, 8\"");
        Console.WriteLine("7.Closing the program");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
    }
    static void Addition(ref int sum)
    {
        Console.Write("enter firstInput:-");
        int firstInput = int.Parse(Console.ReadLine());
        Console.Write("enter secondInput:-");
        int secondInput = int.Parse(Console.ReadLine());
        sum = firstInput + secondInput;
    }
    static void Subtraction(ref int sub)
    {
        Console.Write("enter firstInput:-");
        int firstInput = int.Parse(Console.ReadLine());
        Console.Write("enter secondInput:-");
        int secondInput = int.Parse(Console.ReadLine());
        sub = firstInput - secondInput;
    }
    static void Multiplication(ref int mul)
    {
        Console.Write("enter firstInput:-");
        int firstInput = int.Parse(Console.ReadLine());
        Console.Write("enter secondInput:-");
        int secondInput = int.Parse(Console.ReadLine());
        mul = firstInput * secondInput;
    }
    static void Division(ref double divd)
    {
        Console.Write("enter firstInput:-");
        double firstInput = int.Parse(Console.ReadLine());
        Console.Write("enter secondInput:-");
        double secondInput = int.Parse(Console.ReadLine());
        if (secondInput != 0)
        {
            divd = firstInput / secondInput;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    static void MultiplicationTable()
    {
        Console.Write("enter a number:-");
        int n = int.Parse(Console.ReadLine());
        Console.Write("limit:-");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            int multipal = n * i;
            Console.WriteLine($"{n} x {i} = {multipal}");
        }
    }
    static void DisplaySequence()
    {
        int i = 1;
        bool firstOnePrinted = false;
        Console.Write("Enter the limit:-");
        int x = int.Parse(Console.ReadLine());
        do
        {
            if (i == 1 && !firstOnePrinted)
            {
                Console.Write("1,");
                firstOnePrinted = true;
            }
            Console.Write(i);
            if (i < x)
            {
                Console.Write(",");
            }
            i++;
        }
        while (i <= x);
        Console.WriteLine("");
    }
}