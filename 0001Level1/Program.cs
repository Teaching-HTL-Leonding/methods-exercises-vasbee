int input;
string selection;
string text;


do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;
            case "1": RunRandomInRage(); break;
            case "2": RunFizzBuzz(); break;
            case "3": RunFibonacciByIndex(); break;
            case "4": AskForNumberInRage(5, 10); break;
            case "5": RunIsPalindrome(); break;
            case "6": RunIsPalindromeAdvanced(); break;

            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");

// TODO: Create one code region for each level

#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion

#region Random In Range 1
int RandomInRage(int minimum, int maximum)
{
    return Random.Shared.Next(minimum, maximum + 1);
}

void RunRandomInRage()
{
    int count0 = 0, count1 = 0, count2 = 0;

    for (int i = 0; i < 1000001; i++)
    {
        int randomNumber = RandomInRage(0, 2);
        System.Console.Write($"{randomNumber}");

        if (randomNumber == 0)
        {
            count0++;
        }
        else if (randomNumber == 1)
        {
            count1++;
        }
        else { count2++; }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{count0} {count1} {count2}");
}

#endregion

#region To Fizz Buzz 2

string ToFizzBuzz(int input)
{
    string FizzBuzz;
    if (input % 3 == 0 && input % 5 == 0)
    {
        FizzBuzz = "FizzBuzz";
    }
    else if (input % 3 == 0)
    {
        FizzBuzz = "Fizz";
    }
    else if (input % 5 == 0)
    {
        FizzBuzz = "Buzz";
    }
    else
    {
        FizzBuzz = ":)";
    }
    return FizzBuzz;
}

void RunFizzBuzz()
{
    System.Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(ToFizzBuzz(number));
}

#endregion

#region Fibonacci By 3
int FibonacciByIndex(int index)
{
    int val1 = 0, val2 = 1, val3, i;

    for (i = 2; i <= index; ++i)
    {
        val3 = val1 + val2;

        if (i == index)
        {
            System.Console.WriteLine(val3 + " ");
        }

        val1 = val2;
        val2 = val3;
    }
    return index;
}

void RunFibonacciByIndex()
{
    System.Console.WriteLine("Enter a number");
    int numberindex = int.Parse(Console.ReadLine()!);
    FibonacciByIndex(numberindex);
}
#endregion

#region AskForNumberInRange 4

int AskForNumberInRage(int minimum, int maximum)
{

    System.Console.WriteLine($"Enter a number between {minimum} and {maximum}");
    do
    {
        input = int.Parse(Console.ReadLine()!);

        if (input > maximum)
        {
            System.Console.WriteLine($"Wrong number. Your input is too high. The maximum is {maximum}. Try again!");
        }
        else if (input < minimum)
        {
            System.Console.WriteLine($"Wrong number. Your input is too low. The minimum is {minimum}. Try again!");
        }
        else
        {
            System.Console.WriteLine("Thank you, your input is valid.");
        }
    }
    while (input < minimum || input > maximum);
    return input;
}


#endregion

#region RunIsPalindrome 5
void RunIsPalindrome()
{
    Console.Write("Please enter your text: ");
    text = Console.ReadLine()!;

    var result = IsPalindrome(text);
    Console.WriteLine($"The result is: {result}");
}

bool IsPalindrome(string input)
{
    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - i - 1])
        {
            return false;
        }
    }
    return true;

}

#endregion

#region RunIsPalindromeAdvanced 6

void RunIsPalindromeAdvanced()
{
    Console.Write("Please enter your text: ");
    text = Console.ReadLine()!;

    var result = IsPalindromeAdvanced(text);
    Console.WriteLine($"The result is: {result}");
}

bool IsPalindromeAdvanced(string input)
{
    text.Replace(" ", "");
    text.Replace("-", "");
    text.Replace(",", "");
    text.ToLower();

    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

#endregion