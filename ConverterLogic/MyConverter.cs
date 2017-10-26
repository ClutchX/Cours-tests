using System;
using System.Linq;
using System.Text;

namespace ConverterLogic
{
    public class MyConverter : IConverter
    {
        int[] numeral = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] values = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        IParser parser = new Parser();

        public string Convert(string s)
        {
            var number = parser.ParseString(s);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                while (number >= numeral[i])
                {
                    number -= numeral[i];
                    result.Append(values[i]);
                }
            }

            return result.ToString();
        }
    }
}