using System;
using Algorithms;

string word = new UserInput().GetInput();
string option = new UserInput().GetOption();

string process = new StringProcessor().OptionProcess(word, option);
Console.WriteLine(process);