using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StringProcessor
    {
        public string OptionProcess(string word, string option)
        {
            var counter = new LetterOccurrenceCounter();
            var filter = new DuplicateFilter();

            if (option == "a")
            {
                return counter.Count(word);
            }
            else if (option == "b")
            {
                return filter.Filter(word);
            }
            else
            {
                return "Your choice is not valid";
            }
        }
    }
}
