using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DuplicateFilter
    {
        public string Filter(string s)
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
