using System;

namespace Algorithms
{
	class Program
	{
		public static void Main()
		{
            Console.WriteLine("Enter a word");
            string str = Console.ReadLine();
            Console.WriteLine("Insert a for the number of occurrences of letters in a word");
            Console.WriteLine("Insert b for string without duplicates");
            string userChoice = Console.ReadLine();
            if (userChoice == "a")
            {
                Console.WriteLine(CountLetterOccurrences(str));
            }
            else if (userChoice == "b")
            {
                Console.WriteLine(FilterLetters(str));
            }
            else
            {
                Console.WriteLine("Your choice is not valid");
            }
        }
        //method for counting the number of occurences of letter in a word
        public static string CountLetterOccurrences(string str)
        {
            while (str.Length > 0)
            {
                Console.Write(str[0]);
                int count = 0;
                for (int stringIndex = 0; stringIndex < str.Length; stringIndex++)
                {
                    if (str[0] == str[stringIndex])
                    {
                        count++;
                    }
                }
                str = str.Replace(str[0].ToString(), string.Empty);
                Console.WriteLine(count);
            }
            return Console.ReadLine();
        }
        //method for filtering letters
        public static string FilterLetters(string s)
        {
            string str = "";

            for (int stringIndex = 0; stringIndex < s.Length; stringIndex++)
            {
                char letter = s[stringIndex];
                if (str.IndexOf(letter) < 0)
                {
                    str += letter;
                }
            }
            return str;
        }

    }
}