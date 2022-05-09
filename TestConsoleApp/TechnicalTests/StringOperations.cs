using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.TechnicalTests
{
    public class StringOperations
    {
        public string ReverseString(string stringToReverse)
        {
            string reversedStringResult = new string(stringToReverse.Reverse().ToArray());
            return reversedStringResult ?? string.Empty;
        }

        public string RemoveStringChars(string stringToRemoveFrom, char[] charsToRemove)
        {
            foreach (var item in charsToRemove)
            {
                stringToRemoveFrom = stringToRemoveFrom.Replace(item.ToString(), "");
            }

            return stringToRemoveFrom;
        }
    }
}
