// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do?\n [A]dd number\n [S]ubtract numbers\n [M]ultiply numbers");
string doYouWantToDo = Console.ReadLine()?.ToLower();

if (doYouWantToDo == "a")
{
    int total = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, total, "+");
    
}
else if (doYouWantToDo == "s")
{
    int total = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, total , "-");
}
else if (doYouWantToDo == "m")
{
    int total = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, total , "*");
}
else
{
    Console.WriteLine("Invalid choice!\n Press any key to close.");
    if (Console.ReadKey().Key == ConsoleKey.Escape) ;
}
return 0;

void PrintFinalEquation(
    int firstNumber, int secondNumber, int result, string @operator)
{
    Console.WriteLine(
        firstNumber + " " + @operator + " " + secondNumber + " = "  + result);
}