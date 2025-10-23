namespace LearningC_Unity.Learning_C_;
using System;

public class ArrayPractice
{
    public static string BuildHelloString()
    {
        char[] letters = new char[] {'h', 'e', 'l', 'l', 'o'}; //your code goes here
        var result = "";
        for(int i = 0; i < letters.Length; ++i)
        {
            result += letters; //your code goes here
        }

        Console.WriteLine(result);
        return result;
    }
}