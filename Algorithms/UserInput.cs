using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class UserInput
    {
        public string GetInput()
        {
            Console.WriteLine("Enter a word");
            string input = Console.ReadLine();
            return input;
        }
        public string GetOption()
        {
            Console.WriteLine("Choose [a] for letter occurrence count or [b] for filter");
            string option = Console.ReadLine();
            return option;
        }
    }
}
