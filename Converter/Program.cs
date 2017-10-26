using System;
using ConverterLogic;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new MyConverter();

            bool looper = true;

            while (looper)
            {
                Console.WriteLine("What do you want to convert ? - Write exit to quit");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "exit":
                        looper = false;
                        break;

                    default:
                        Console.WriteLine(converter.Convert(input));
                        //Console.WriteLine("Incorrect entry, please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
