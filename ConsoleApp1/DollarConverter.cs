using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DollarConverter : IConverter
    {

        public string NumberToDollar(int number)
        {
            if (number < 0 || number > 999999999)
                Console.WriteLine("dollar value more than 9 length is not supported");

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToDollar(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToDollar(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToDollar(number / 100) + " hundred ";
                number %= 100;
            }

            return GetFinalResult(number, words);
        }

        public string NumberToCent(int cent)
        {
            string strcent = "";

            if (cent < 0 || cent > 99)
                Console.WriteLine("Cent value more than 2 length is not supported");

            return GetFinalResult(cent, strcent);
        }

        public string GetFinalResult(int cent, string strInput)
        {
            var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (cent < 20)
                strInput += units[cent];
            else
            {
                strInput += tens[cent / 10];
                if ((cent % 10) > 0)
                    strInput += " " + units[cent % 10];
            }

            return strInput;
        }

    }
}
