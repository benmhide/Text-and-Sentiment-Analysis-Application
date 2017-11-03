using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1127M_PartB
{
    public class ParagraphCounter                                   // Paragraph counting class with a custom method for counting the paragraphs in a string (using regular expressions engine).
    {
        public static int CountPrargraphs(string textToAnalyse)     // Paragraph counting method. Method takes one string agrument. Counts the paragraphs in the string and returns the count as an integer.
        {
            MatchCollection collection = 
                Regex.Matches(textToAnalyse, "[^\r\n]+((\r|\n|\r\n)[^\r\n]+)*");        // Using the regular expressions engine to match any non-zero number of non-newline characters and the....
                                                                                        // ....other forms of newlines to count the paragraphs in the string.

            return collection.Count;                                                    // Returns the paragraph count.
        }
    }
}
