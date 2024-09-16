﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Counters;

namespace Algorithms
{
    public class LetterOccurrenceCounter : ICounter
    {
        public string Count(string str)
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
            return str;
        }
    }
}
