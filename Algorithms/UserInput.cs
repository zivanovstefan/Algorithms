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
            string input;
            do 
            {
                Console.WriteLine("Enter a word, number or phrase...");
                input = Console.ReadLine();
                
            }while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}

