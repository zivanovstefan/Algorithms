using System;
using Algorithms;

// Asking the user to enter a word, number or phrase
Console.WriteLine("Enter a word, number or phrase...\n");
var input = Console.ReadLine(); 

//converting characters to lower case
var checker = new PalindromeChecker();
var check = checker.Check(input);

Console.WriteLine(check);
