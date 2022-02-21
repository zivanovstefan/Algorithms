using System;
using Algorithms;

Console.WriteLine("Enter a word");
string str = Console.ReadLine();

Console.WriteLine("Insert a for the number of occurrences of letters in a word");
Console.WriteLine("Insert b for string without duplicates");

var counter = new LetterOccurrenceCounter();
var filter = new DuplicateFilter();

string userChoice = Console.ReadLine();
if (userChoice == "a")
      {
          Console.WriteLine(counter.Count(str));
      }
else if (userChoice == "b")
      {
      Console.WriteLine(filter.Filter(str));
       }
else
{
Console.WriteLine("Your choice is not valid");
}
