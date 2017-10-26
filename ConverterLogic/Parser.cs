using System;
using System.Collections.Generic;
using System.Text;

namespace ConverterLogic
{
    public class Parser : IParser
    {
        public int ParseString(string s)
        {
            int number = int.MaxValue;

            int.TryParse(s, out number);
            number = (number != 0) ? number : throw new ArgumentException("Value must be a numeric");
            number = (number < 0 || number > 4000) ? throw new ArgumentException("Value must be in the range 0 - 3999") : number;

            return number;
        }
    }
}