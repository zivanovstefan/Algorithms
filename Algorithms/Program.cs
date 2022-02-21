using System;

namespace PalindromeChecker
{
	class Program
	{
		public static void Main()
		{
			// Asking the user to enter a word, number or phrase
			Console.WriteLine("Enter a word, number or phrase...\n");
			string input = Console.ReadLine();
			bool status = false;

			//converting characters to lower case
			string lowercaseInput = input.ToLower();

			// Printing result
			if (isPalindrome(lowercaseInput))
			{
				status = true;
				Console.WriteLine(status);
			}
			else
			{
				Console.WriteLine(status);
			}
		}
		public static bool isPalindrome(string userinput)
		{
			char[] charArray = userinput.ToCharArray();
			//reversing an array
			Array.Reverse(charArray);
			//converting charArray to string
			string reversedInput = new string(charArray);
			//is user input equal to the reversed user input
			if (userinput.Equals(reversedInput))
			{
				return true;
			}
			return false;
		}
	}
}