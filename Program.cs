using System;

class Program
{
    public static void Main()
    {
        Greet();
        ShowMenu();
        string userInput = "";
        while (userInput.ToLower() != "end")
        {
            int userProvidedInput = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            double firstInput = 0;
            double secondInput = 0;
            double thirdInput = 0;
            double fourthInput = 0;

            if (userProvidedInput >= 1 && userProvidedInput <= 5)
            {
                GetInputs(ref firstInput, ref secondInput,ref thirdInput); // Get inputs for operations
            }
            {
                if (userProvidedInput == 1)
                {
                    double addResult = 0;
                    Addition(ref firstInput,ref secondInput,ref thirdInput,ref addResult);
                    Console.WriteLine($"The sum is ={addResult}");
                    Console.WriteLine("-------------------------------");
                }
                else if(userProvidedInput ==2)
                {
                    double averageResult=0;
                    Average(ref firstInput, ref secondInput, ref averageResult);
                    Console.WriteLine($"The Average is ={averageResult}");
                    Console.WriteLine("-------------------------------");
                }
                else if (userProvidedInput == 3)
                {
                    double subResult = 0;
                    Subtraction(ref firstInput, ref secondInput, ref subResult);
                    Console.WriteLine($"The sub is={subResult}");
                    Console.WriteLine("-------------------------------");
                }
                else if (userProvidedInput == 4)
                {
                    double mulResult = 0;
                    Multiplication(ref firstInput, ref secondInput, ref mulResult);
                    Console.WriteLine($"The mul is={mulResult}");
                    Console.WriteLine("-------------------------------");
                }
                else if (userProvidedInput == 5)
                {
                    double divdResult = 0;
                    Division(ref firstInput, ref secondInput, ref divdResult);
                    Console.WriteLine($"The divd is={divdResult:F3}");
                    Console.WriteLine("-------------------------------");
                }
                else if (userProvidedInput == 6)
                {
                    MultiplicationTable();
                    Console.WriteLine("-------------------------------");
                }
                else if (userProvidedInput == 7)
                {
                    DisplaySequence();
                    Console.WriteLine("-------------------------------");
                }
                if (userProvidedInput == 8)
                {
                    Console.WriteLine("Closing the program...");
                    userInput = "end";
                }
            }
        }
    }
    public static void Greet()
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
    public static void ShowMenu()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("PLease select the below option for operation");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("1.Addition");
        Console.WriteLine("1.Average");
        Console.WriteLine("3.Subtraction");
        Console.WriteLine("4.multiplication");
        Console.WriteLine("5.division");
        Console.WriteLine("6.multiplicationTable of given number");
        Console.WriteLine("7.display\"1, 1, 2, 3, 4, 5, 6, 7, 8\"");
        Console.WriteLine("8.Closing the program");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
    }
    public static void GetInputs(ref double firstInput,ref double secondInput,ref double thirdInput)
    {
        Console.Write("enter firstInput:-");
        firstInput = int.Parse(Console.ReadLine());
        Console.Write("enter secondInput:-");
        secondInput = int.Parse(Console.ReadLine());
        Console.Write("enter thirdInput:-");
        thirdInput = int.Parse(Console.ReadLine());
    }
    public static void Addition(ref double firstInput, ref double secondInput, ref double thirdInput, ref double sum)
    {
        sum = firstInput + secondInput + thirdInput;
    }
    public static void Average(ref double firstInput, ref double secondInput, ref double average)
    {
        double sum = firstInput + secondInput;
        average = sum / 2;
    }
    public static void Subtraction(ref double firstInput, ref double secondInput, ref double sub)
    {
        sub = firstInput - secondInput;
    }
    public static void Multiplication(ref double firstInput, ref double secondInput, ref double mul)
    {
        mul = firstInput * secondInput;
    }
    public static void Division(ref double firstInput, ref double secondInput, ref double divd)
    {
        if (secondInput != 0)
        {
            divd = firstInput / secondInput;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public static void MultiplicationTable()
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
    public static void DisplaySequence()
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