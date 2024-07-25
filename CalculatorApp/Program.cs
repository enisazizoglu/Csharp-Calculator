using System.Reflection.PortableExecutable;

Console.Clear();

bool keepAsking = true;
bool runCalculator = true;

do
{
    System.Console.WriteLine("Enter Number 1");
    int firstNumber = 0;
do
{
    string? answer = Console.ReadLine();
    if (answer != null)
    {
        bool isNumber = NumberChecker(answer);
        if (isNumber)
        {
            firstNumber = ToNumber(answer);
            keepAsking = false;
        }
        else
        {
            System.Console.WriteLine("Enter a correct number 1");
            keepAsking = true;
        }

    }
} while (keepAsking);
Console.Clear();




System.Console.WriteLine("Enter number 2");
int secondNumber = 0;
do
{
    keepAsking = true;
    string? answer = Console.ReadLine();
    if (answer != null)
    {
        bool isNumber = NumberChecker(answer);
        if (isNumber)
        {
            secondNumber = ToNumber(answer);
            keepAsking = false;
        }
        else
        {
            System.Console.WriteLine("Enter a correct number for number 2");
            keepAsking = true;
        }

    }


} while (keepAsking);


bool correctOption = false;
int result = 0;
do
{

    System.Console.WriteLine("Choose an arithmetic operation: \t + | - | / | * \nOR \t\t\t\t\t add | sub | div | mult");
    string? userChoice = Console.ReadLine();
    if (userChoice != null)
{
    if (userChoice == "+" || userChoice == "add")
    {
        result = Addition(firstNumber, secondNumber);
         System.Console.WriteLine($"Result of subtraction given your numbers is {result}");
         correctOption = false;
    }
    else if (userChoice == "-" || userChoice == "sub")
    {
        result = Subtraction(firstNumber, secondNumber);
        System.Console.WriteLine($"Result of subtraction given your numbers is {result}");
    }
    else if (userChoice == "/" || userChoice == "div")
    {
        result = Division(firstNumber, secondNumber);
        System.Console.WriteLine($"Result of division given your numbers is {result}");
    }
    else if (userChoice == "*" || userChoice == "mult")
    {
        result = Multip(firstNumber, secondNumber);
        System.Console.WriteLine($"Result of multiplication given your numbers is {result}");
    }
    else
    {
        System.Console.WriteLine("Incorrect Option. Choose one of the correct options.");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        correctOption = true;
    }
}
    
} while (correctOption);


bool again = true;
do
{
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine("Do you want to do another calculation? \t yes / no");
    string? userChoice = Console.ReadLine();
    if (userChoice != null)
    {
        if(userChoice.ToLower() == "yes")
        {
            again = false;
            runCalculator = true;
            Console.Clear();
        }
        else if (userChoice.ToLower() == "no")
        {
            again = false;
            runCalculator = false;
        }
        else
        {
            again = true;
        }
    }
} while (again);
    
} while (runCalculator);




static bool NumberChecker(string value)
{
    bool success = int.TryParse(value, out int result);
    if (success)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static int ToNumber(string answer)
{
    return int.Parse(answer);

}


// Arithmetic operations
static int Addition(int number1, int number2)
{
    return number1 + number2;
}

static int Subtraction(int number1, int number2)
{
    return number1 - number2;
}

static int Multip(int number1, int number2)
{
    return number1 * number2;
}

static int Division(int number1, int number2)
{
    return number1 / number2;
}

