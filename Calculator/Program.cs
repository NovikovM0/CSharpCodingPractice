// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;

void Main()
{
    Welcome();
    Calculator();
    End();
}


void Welcome()
{
    Console.WriteLine("Hello!!");
}


void Calculator()
{
    Console.WriteLine("Input the first number:");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the second number:");
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("[A]dd numbers\n[S]ubstract numbers\n[M]ultiply numbers");
    string result = Calculation(Console.ReadLine().ToLower(), firstNumber, secondNumber);
    Console.WriteLine(result);
}


string Calculation(string operand, int firstNumber, int secondNumber )
{
    if (operand == "a")
    {
        return Convert.ToString(firstNumber + secondNumber);
    }
    else if (operand == "s")
    {
        return Convert.ToString(firstNumber - secondNumber);
    }
    else if (operand == "m")
    {
        return Convert.ToString(firstNumber * secondNumber);
    }

    return "Invalid choice";
}


void End()
{
    Console.WriteLine("Press any key to close");
    Console.ReadKey();
}


Main();
