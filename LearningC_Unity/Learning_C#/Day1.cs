// First difference is that in C# comments are written through "//" instead of "#" in Python

// As we can see, we're calling out console to write a line (in Python it's just ' print() '.

using System.Globalization;
using Console = System.Console;

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

// or 

switch (points)
{
 case 10:
 case 9:
  return 'A';
 case 8:
  return 'B';
 case 7:
 case 6:
  return 'C';
 default:
  return '!';
}

// and let's refactor it and make it shorter

return points switch
{
 10 or 9 => 'A',
 8 => 'B',
 7 or 6 => 'C',
 _ => '!', //default
};

// or

return points switch
{
 >= 90 => 'A',
 >= 80 => 'B',
 >= 50 => 'C',
 _ => 'D' // anything below 50 gets a D
};

// Loop
// 1) While

var number = 0;

while (number < 10)
{
 number += 1;
 number++; // means that it will +1 each time and '--' will -1 
 Console.WriteLine("Number is: " + number);
}

Console.WriteLine("The loop is finished");

/* In the while loop, the condition is checked before the first execution of the loop body
 so it can happen that the code inside the loop will not be executed even once */

while(condition) {
   // some code
}


/* in the do-while loop the condition is checked after the code in the body is executed
 so the code inside the loop will always be executed at least once*/
do
{
   //some code
}
while (condition);

do
{
 Console.WriteLine("Enter a word what is lnger than 10 chars");
 word = Console.ReadLine(); // input
}
while (word.Lenght < 10); //check word if it's < 10


// For in loop
// initializer section (executed only once before entering the loop; 
// Сondition section - boolean
// iterator - it defines what happens after each execution of the bodt of the loop.
// for (initializer; condition; iterator)
for (int i = 0; i < 5; ++i)  
{
 Console.WriteLine("Hello");
}

// continue 
for (var i = 0; i < 20; ++i)
{
 if (i % 3 == 0)
 {
  continue; // basically, when it's % by 3, it will continue and it will like do the part with it and go further in the loop
 }
 Console.WriteLine("i is " + 1);
}

Console.WriteLine("Loop if finished");


/* Nested loops - loop what is inside of another loop. */

// It will print until firt - k will be not higher 5, than it will start adding to j + 1, then it will go again for k then add another j
// and it will loop untill i will be higher than 4, j higher 3 and k > 5.
for (int i = 0; i < 4; ++i)
{
 for (int j = 0; j < 3; ++j)
 {
  for (int k = 0; k < 5; ++k) //  
  {
   Console.WriteLine($"is is {i}, j is {j}, k is {k}");  
  }
 }
}

/* What is 'Performance' ? 
Performance - a measure of how fast the program is EXECUTED (not working) and how much resources (memory etc) it consumes

Tip 1: Move performance heavy code outside the loop, or to OUTER loops. */


// Arrays - the most basic COLLECTION type in C#, storing multiple elements of the same type.
// array - collection of fixed size, so once an array is created, it's size can't be changed.

int[] numbers = new int[3] // arrays is an object of a class, and you need to use a 'new' keyword 
// we're asking PC to create memory for new object and initialize it. [0, 0, 0]

numbers[0] = 5;
numbers[1] = 3; // we declared that number with index 1 = 3.
// Because it's int - it can't be string.

int[] numbers = new int[] { 2, 6, 1, 5, 20 };

for (var i = 0; i < number.Length; ++i) //number.Length - len of the array. And we can't use <= here either
{
  
}

// Multidimensional array
сhar[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

// How to use it?
var height = letters.GetLength(0);
var width = letters.GetLength(1)
Console.WriteLine("height is" + height);
Console.WriteLine("width is" + width);

// We can't use Len property as we did with a single-dimensional array as it gives a total number of the array (6)
/* To access array to each dimension we're using GetLength for height and width (it's the first and the second
 dimension of the array*/
for (var i = 0; i < height; i++)
{
 Console.WriteLine("i is " + i);
 for (var j = 0; j < height; j++)
 {
  Console.WriteLine("j is " + j);
  Console.WriteLine("element is " + letter[i,j]);
 }
}

var letters2 = new char[,]
{
 {'A', 'B', 'C'},
 {'D', 'E', 'F'}
}

// foreach - a simplier ver of for in. For example:

var words = new [] {"one", "two", "three"};

/* With 'for' loop it will be:
for(var i = 0; i < words.Length; i++)
{
  Console.WriteLine(words[i]);
} */ 
 // with foreach it will be:

 foreach (var word in words)
 {
  Console.WriteLine(word);
 }
 /* In this loop we don't have access to an index (and it's fine for us)
 The variable of the loop, which we named "word" is the first element of the collection in the first iteration
 of the loop. The second element in the second iteration and so on */
 
 // Another example
 using System;

 namespace Coding.Exercise
 {
  public class Exercise
  {
   public static bool IsAnyWordLongerThan(int length, string[] words)
   {
    foreach (var word in words)  //don't forget parenthesis () 
    {
     if(word.Length > length)
     {
      return true; // true is written lowercase, and so is 'false'
     }
                
    }
    return false;
   }
  }
 }
 
 /* LIST
 List - size of a list CAN be changed (it's not fixed)
 
 Difference between .Length and .Count:
 .Length - used in arrays - returns a length of array (fixed)
 .Count - used in List, Dictionary,  HashSet etc. - returns an amount of elements in collection (can be changed)
  */
 

// Important. <> after List - related to generic types and list is a generic type
// List - class

// List<string> words = new List<string>(); - we can write it like this or make it shorter
 var words = new List<string>();
 {
  "one",
  "two",
  
 };

 words[0] = "uno";
 words[1] = "due";
 words[2] = "Will cause an error, cuz we only have 0 and 1."
Console.WriteLine("Count of elements is " + words.Count); // counting a amount of elements in the collection

words.Remove("two"); // we're removing "two" from the list. So we will have only "one" 
foreach (var word in words)
{
 Console.WriteLine(word);
}
Console.ReadKey();
 
 
 