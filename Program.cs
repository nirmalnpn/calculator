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
            Console.WriteLine("--------------------------------------------");

            if (userProvidedInput >= 1 && userProvidedInput <= 5)
            {
                Console.Write("Enter how many inputs you want (2 or 3):");
                int userProvidedInputCount = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------");

                int firstInput, secondInput, thirdInput = 0; // Declare all inputs, with a default of 0 for thirdInput

                if (userProvidedInputCount == 2)
                {
                    var inputs = Get2Inputs(answer); // Get 2 inputs for operations
                    firstInput = inputs.Item1;
                    secondInput = inputs.Item2;
                }
                else if (userProvidedInputCount == 3)
                {
                    var inputs = Get3Inputs(answer); // Get 3 inputs for operations
                    firstInput = inputs.Item1;
                    secondInput = inputs.Item2;
                    thirdInput = inputs.Item3;
                }
                else
                {
                    Console.WriteLine("Invalid input count, please try again.");
                    continue;
                }

                switch (userProvidedInput)
                {
                    case 1:
                        int addResult;
                        if (userProvidedInputCount == 2)
                        {
                            addResult = Addition(firstInput, secondInput); // Use only 2 inputs
                        }
                        else
                        {
                            addResult = Addition(firstInput, secondInput, thirdInput); // Use 3 inputs
                        }
                        Console.WriteLine($"The sum is = {addResult}");
                        answer = addResult;
                        break;

                    case 2:
                        double averageResult;
                        if (userProvidedInputCount == 2)
                        {
                            averageResult = Average(firstInput, secondInput);// Use only 2 inputs
                        }
                        else
                        {
                            averageResult = Average(firstInput, secondInput, thirdInput); // Use 3 inputs
                        }
                        Console.WriteLine($"The Average is = {averageResult}");
                        answer = (int)averageResult;
                        break;

                    case 3:
                        int subResult;
                        if (userProvidedInputCount == 2)
                        {
                            subResult = Subtraction(firstInput, secondInput);// Use only 2 inputs
                        }
                        else
                        {
                            subResult = Subtraction(firstInput, secondInput, thirdInput); // Use 3 inputs
                        }
                        
                        Console.WriteLine($"The difference is = {subResult}");
                        answer = subResult;
                        break;

                    case 4:
                        int mulResult;
                        if (userProvidedInputCount == 2)
                        {
                            mulResult = Multiplication(firstInput, secondInput);// Use only 2 inputs
                        }
                        else
                        {
                            mulResult = Multiplication(firstInput, secondInput, thirdInput); // Use 3 inputs
                        }
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
                        
                        Console.Write("Enter the value of n: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(Fibonacci(i) + " ");
                        }
                        Console.WriteLine("");
                        break;
                    case 9:
                        int sum=getInput();
                        Console.WriteLine($"The sum of 10 inputs is: {sum}");
                        answer = sum;
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
        Console.WriteLine("8. Fibonacci Sequence");
        Console.WriteLine("9. Sum 10 Inputs");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
    }

    public static (int, int) Get2Inputs(int ans)
    {
        Console.Write("Enter first input (or type 'ans'): ");
        string firstInputStr = Console.ReadLine();
        int firstInput = firstInputStr.ToLower() == "ans" ? ans : int.Parse(firstInputStr);

        Console.Write("Enter second input (or type 'ans'): ");
        string secondInputStr = Console.ReadLine();
        int secondInput = secondInputStr.ToLower() == "ans" ? ans : int.Parse(secondInputStr);

        return (firstInput, secondInput);
    }

    public static (int, int, int) Get3Inputs(int ans)
    {
        Console.Write("Enter first input (or type 'ans'): ");
        string firstInputStr = Console.ReadLine();
        int firstInput = firstInputStr.ToLower() == "ans" ? ans : int.Parse(firstInputStr);

        Console.Write("Enter second input (or type 'ans'): ");
        string secondInputStr = Console.ReadLine();
        int secondInput = secondInputStr.ToLower() == "ans" ? ans : int.Parse(secondInputStr);

        Console.Write("Enter third input (or type 'ans'): ");
        string thirdInputStr = Console.ReadLine();
        int thirdInput = thirdInputStr.ToLower() == "ans" ? ans : int.Parse(thirdInputStr);

        return (firstInput, secondInput, thirdInput);
    }

    public static int Addition(int firstInput, int secondInput)
    {
        return firstInput + secondInput;
    }

    public static int Addition(int firstInput, int secondInput, int thirdInput)
    {
        return firstInput + secondInput + thirdInput;
    }

    public static double Average(int firstInput, int secondInput)
    {
        int sum = firstInput + secondInput;
        return (double)sum / 2;
    }
    public static double Average(int firstInput, int secondInput, int thirdInput)
    {
        int sum = firstInput + secondInput + thirdInput;
        return (double)sum / 3;
    }

    public static int Subtraction(int firstInput, int secondInput)
    {
        return firstInput - secondInput;
    }
    public static int Subtraction(int firstInput, int secondInput, int thirdInput)
    {
        return firstInput - secondInput - thirdInput;
    }

    public static int Multiplication(int firstInput, int secondInput)
    {
        return firstInput * secondInput;
    }
    public static int Multiplication(int firstInput, int secondInput, int thirdInput)
    {
        return firstInput * secondInput * thirdInput;
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
        string[] inputs = inputStr.Split(',');
        int Sum = 0;
        for (int i = 0; i < inputs.Length; i++)
        {
            Sum += int.Parse(inputs[i]);
        }          
            return Sum; // Sum up the inputs
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

    public static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static int getInput()
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"please provide the {i + 1} input:");
            int userInput = int.Parse(Console.ReadLine());
            sum += userInput;
        }
        return sum;
    }
}