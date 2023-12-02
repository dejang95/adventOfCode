/*
Example of input:

1abc2
pqr3stu8vwx
a1b2c3d4e5f
treb7uchet
*/

using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        int finalSum = 0;
        string[] puzzleLines = System.IO.File.ReadAllLines(@"input");
        foreach(string line in puzzleLines){
            finalSum += GetNumberFromLine(line);
        }
        Console.WriteLine("Final sum is: " + finalSum);
    }

    static int GetNumberFromLine(string line){
        string firstDigit = String.Empty;
        string secondDigit = String.Empty;
        char[] symbolsArray = line.ToCharArray();
        foreach (char symbol in symbolsArray){
            if(char.IsDigit(symbol)) {
                if (firstDigit.Equals(String.Empty)) {
                    firstDigit = symbol.ToString();
                } else secondDigit = symbol.ToString();
            }
        }
        if(secondDigit.Equals(String.Empty)) secondDigit = firstDigit;
        return int.Parse(firstDigit + secondDigit);
    }
}
