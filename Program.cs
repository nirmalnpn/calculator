using System;

class Program
{
    public static void Main()
    {
        Greet();
        ShowMenu();
        string userInput = "";
        int answer = 0; // Initialize the answer variable

        while (userInput.ToLower() != "end")
        {
            int userProvidedInput = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            if (userProvidedInput >= 1 && userProvidedInput <= 5)
            {
                (int firstInput, int secondInput) = GetInputs(answer); // Get inputs for operations

                switch (userProvidedInput)
                {
                    case 1:
                        int addResult = Addition(firstInput, secondInput);
                        Console.WriteLine($"The sum is = {addResult}");
                        answer = addResult;
                        break;

                    case 2:
                        double averageResult = Average(firstInput, secondInput);
                        Console.WriteLine($"The Average is = {averageResult}");
                        answer = (int)averageResult;
                        break;

                    case 3:
                        int subResult = Subtraction(firstInput, secondInput);
                        Console.WriteLine($"The difference is = {subResult}");
                        answer = subResult;
                        break;

                    case 4:
                        int mulResult = Multiplication(firstInput, secondInput);
                        Console.WriteLine($"The product is = {mulResult}");
                        answer = mulResult;
                        break;

                    case 5:
                        double divdResult = Division(firstInput, secondInput);
                        Console.WriteLine($"The quotient is = {divdResult}");
                        answer = (int)divdResult;
                        break;
                    

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            else
            {
                switch (userProvidedInput)
                {
                    case 6:
                        int seriesAddResult = SeriesAddition();
                        Console.WriteLine($"The sum of the series is = {seriesAddResult}");
                        answer = seriesAddResult;
                        break;
                    case 7:
                        MultiplicationTable();
                        break;

                    case 8:
                        DisplaySequence();
                        break;
                    case 0:
                        Console.WriteLine("Closing the program...");
                        userInput = "end";
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            Console.WriteLine("-------------------------------");
        }
    }

    public static void Greet()
    {
        Console.WriteLine("Hello, welcome to my Calculator");
        Console.WriteLine("-------------------------------");
        DateTime currentTime = DateTime.Now;
        if (currentTime.Hour < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
        {
            Console.WriteLine("Good afternoon");
        }
        else
        {
            Console.WriteLine("Good evening");
        }
        Console.WriteLine("-------------------------------");
        Console.WriteLine(currentTime);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Please select an option for operation:");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("0. Close the program");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Average");
        Console.WriteLine("3. Subtraction");
        Console.WriteLine("4. Multiplication");
        Console.WriteLine("5. Division");
        Console.WriteLine("6. Series Addition");
        Console.WriteLine("7. Multiplication Table of given number");
        Console.WriteLine("8. Display \"1, 1, 2, 3, 4, 5, 6, 7, 8\"");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
    }

    public static (int, int) GetInputs(int ans)
    {
        Console.Write("Enter first input (or type 'ans'): ");
        string firstInputStr = Console.ReadLine();
        int firstInput = firstInputStr.ToLower() == "ans" ? ans : int.Parse(firstInputStr);

        Console.Write("Enter second input (or type 'ans'): ");
        string secondInputStr = Console.ReadLine();
        int secondInput = secondInputStr.ToLower() == "ans" ? ans : int.Parse(secondInputStr);

        return (firstInput, secondInput);
    }

    public static int Addition(int firstInput, int secondInput)
    {
        return firstInput + secondInput;
    }
    public static double Average(int firstInput, int secondInput)
    {
        int sum = firstInput + secondInput;
        return (double)sum / 2;
    }

    public static int Subtraction(int firstInput, int secondInput)
    {
        return firstInput - secondInput;
    }

    public static int Multiplication(int firstInput, int secondInput)
    {
        return firstInput * secondInput;
    }

    public static double Division(int firstInput, int secondInput)
    {
        if (secondInput != 0)
        {
            return (double)firstInput / secondInput;
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
    }
    public static int SeriesAddition()
    {
        Console.Write("Enter numbers separated by commas: ");
        string inputStr = Console.ReadLine();

        int[] inputs = inputStr.Split(',')
                                .Select(s => int.Parse(s.Trim()))
                                .ToArray();

        // Sum up the inputs
        return inputs.Sum();

    }

    public static void MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Limit: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            int result = n * i;
            Console.WriteLine($"{n} x {i} = {result}");
        }
    }
   

    public static void DisplaySequence()
    {
        int i = 1;
        bool firstOnePrinted = false;
        Console.Write("Enter the limit: ");
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


/*
 for(int i=0;i<10;i++)
{
    getInput(i);
}


int getInput(int inputCount)
{
    Console.WriteLine($"please provide the {inputcount +1} input:");
    int userInput=int.parse(Console.ReadLine());
    return userInput;
}
 */