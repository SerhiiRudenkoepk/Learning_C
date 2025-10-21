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


/* Now we learn about Parsing.
What is Parsing? Parsing - transforming bool, int, string to other types 
*/ 

Console.WriteLine("Provide a number");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);  // we changed string to int
Console.WriteLine(number);


// String interpolation

int a = 4, b = 2, c = 3;
Console.WriteLine("First is " + a + ", second is " + b + ", third is " + c);
// Instead we can just use $ and {} to do a string interpolation
Console.WriteLine($"First is: {a}, and then {b}, and then {c}"); 
Console.ReadLine();



/*  Switch statements / default keyword / expressions 
The switch statement provides a way to transfer the exection to different paths of code based on the value of expression.
*/

switch (userChoice)  // it will work as if else statement, but it's much shorter and more readable 
{
 case "S":
  PrintSelectedOption("See all TODOs");
  Console.WriteLine("Another line");
  break; // Each case should end with break
 case "A":
  PrintSelectedOption("Add a TODO");
  break;
 case "R":
  PrintSelectedOption("Remove a TODO");
  break;
 case "E":
  PrintSelectedOption("Exit");
  break;
 default: // it works like else
  Console.WriteLine("Invalid Choice");
  break;
}