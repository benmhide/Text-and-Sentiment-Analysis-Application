using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1127M_PartB
{
    class StringToStringArrayConverter                                                      // String conversion class with a custom methods for converting a string to a string array.
    {
        public static string[] ConvertedArray(string textToAnalyseCompletelyCleaned)        // String to a string array converting method. Method takes one string agrument. Converts a string to a string array.
        {                                                                                   
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };                                                            // Assigns a string array of characters from where to split the string.
            string[] textToAnalyseArray = textToAnalyseCompletelyCleaned.Split(separators, StringSplitOptions.RemoveEmptyEntries);  // Splits a string into array of substrings using the strings in sperators array.
                                                                                                                                    // The return value does not include array elements that contain an empty string.
            return textToAnalyseArray;                                                                                              // Returns the array created from the string.
        }
    }
}
