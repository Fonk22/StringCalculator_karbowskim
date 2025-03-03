using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace TDD_StringCalculator
{
    public class StringCalculator
    {
        private string delimitersPattern = @"(//\[.+\])|(//.)";
        private List<string> getDelimeters(string arg)
        {
            List<string> defult = new List<string>() { ",", "\n" };
            MatchCollection deliDefinitions = Regex.Matches(arg, delimitersPattern);

            return deliDefinitions.Count > 0 ? deliDefinitions.Select(
                m =>
                {
                    return Regex.Replace(m.Value, @"(//)|\[|\]", "", RegexOptions.IgnoreCase);
                }).ToList() : defult;
        }
        private string clearInput(string arg)
        {
            return Regex.Replace(arg, delimitersPattern, "", RegexOptions.IgnoreCase);
        }
        private string[] getNumbers(string arg, List<string> delimiters)
        {
            StringBuilder pattern = new StringBuilder();
            foreach (string delimiter in delimiters)
            {
                pattern.Append(Regex.Escape(delimiter) + "|");
            }
            pattern.Remove(pattern.Length - 1, 1);

            string[] numbers = Regex.Split(arg, pattern.ToString());
            return numbers;
        }
        public int Calculate(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return 0;
            }
            List<string> delimiters = getDelimeters(arg);
            arg = clearInput(arg);
            string[] numbers = getNumbers(arg, delimiters);

            int res = 0;
            foreach (string s in numbers)
            {
                int number = int.Parse(s);
                number = number > 1000 ? 0 : number;
                if (number < 0)
                {
                    throw new Exception("Negative numbers not allowed!");
                }
                res += number;
            }
            return res;

        }
    }
}
