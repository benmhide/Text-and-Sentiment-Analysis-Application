using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace CMP1127M_PartB
{
    public class WordCounter                                                        // Word counting class with a custom method for counting the words in a string (using the regular expressions engine).
    {        
        public static int WordCount(string textToAnalyse)                           // Word counting method. Method takes one string agrument. Counts the words in the string and returns the count as an integer.
        {
            MatchCollection word = Regex.Matches(textToAnalyse, @"[\S]+");          // Using the regular expressions engine to match verbatim string literal of any non white space character. Then considers....
                                                                                    // ....each non-letter character to be part of a word then counts these words in the string.

            return word.Count;                                                      // Returns the word count.
        }
    }
}

