using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenge_No._208___Culling_Numbers
{
    public class NumberCull
    {
        public String Run(String stringToParse)
        {
            // check is not null or empty
            if(String.IsNullOrEmpty(stringToParse))
                throw new ArgumentNullException();
            // check is numeric or spaces only
            Regex regex = new Regex("^[0-9 ]+$");
            if(regex.Match(stringToParse).Length == 0)
                throw new ArgumentException();
            // split on space
            var numberArray = stringToParse.Split(' ');
            if (!numberArray.Where(o => !string.IsNullOrEmpty(o)).Any())
                throw new ArgumentException();
            // throw away duplicates in array
            var uniqueNumberArray = numberArray.Where((v, i) => (i != 0) ? !numberArray.ElementAt(i - 1).Equals(v) : true);
            return String.Join(" ", uniqueNumberArray);
        }
    }
}
