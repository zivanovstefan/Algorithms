using System;
using Algorithms;

var input = new UserInput();
var word = input.GetInput();

var checker = new PalindromeChecker();
var check = checker.Check(word);

Console.WriteLine(check);
