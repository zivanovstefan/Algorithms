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
            Console.WriteLine("Enter a word, number or phrase...\n");
            var input = Console.ReadLine();
            return input;
        }
    }
}
