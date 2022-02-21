using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PalindromeChecker : IChecker
    {
        public bool Check(string userinput)
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
