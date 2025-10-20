// First difference is that in C# comments are written through "//" instead of "#" in Python

// As we can see, we're calling out console to write a line (in Python it's just ' print() '.
Console.WriteLine("HelloWorld");
// CTRL + R R - let you to replace the highlighted name to a different one (and all places where it currently placed)

// As you can see, we're declaring string at the beginning. If in Python we don't do it, in C# it's mandatory.
string userInputs = "A";
Console.WriteLine(userInputs);
// We can change the variable here without writing 'string' because we already declared it as string.
userInputs = "B";
Console.WriteLine(userInputs);
int number = 7;
Console.WriteLine(number);
number = 10;
Console.WriteLine(number);



// Declaration
int numbers;
// We can also declare multiple times
int a = 1, b = 2;
string lost, In, Vivo;
// Initialization
numbers = 5;
// Initialization at declaration
string text = "abc";
var fullName = "John Smith";
/* var - easier way of initialization at declaration without writing 'string' or 'int'.
 If we will use string on our var first, and then try to change it to a number - it will not work
*/
fullName = 10; 
Console.WriteLine();
// Console.ReadLine - input() in python
var userChoice = Console.ReadLine();
Console.WriteLine("User choice: " + userChoice);
// Red dot (if we will click on the left side on the number - creates breakpoint.
// Basically, code executing until this breakpoint moment. So we can test a specific part of the code
userChoice = "ABC" + "DBC" + "CDQ";

Console.ReadKey();


/*
With this we can write long comments, and not stuffing everything in one line
*/

// AND (&&) and OR (||) operators
var number = 10;
var checking = number > 2 && number < 3; // False
var checking2 = number == 2 || number < 11; // True, because it is less than 11


// Functions/Methods
// void __name__ (____parameter___)
void PrintSelectedOption(string selectedOption)
{
 
}
// non-void methods
bool isLong(string input)
{
 if (input.Length > 10)
 {
  return true;
 }
 // The problem is, that if we create else and place return there - it will not work. Function should end on return
 return false;
}

// Or we can do a refactor ( Code refactoring is the process of improving the code quality without alterin its behavior)

bool IsLong(string input)
{
 return input.Length > 10;
}
int lad = int.Abs();