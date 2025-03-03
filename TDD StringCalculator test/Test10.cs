using System.Text;
using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test10
    {
        [TestMethod]
        public void ManySingleOrMultiCharDelimetersCanBeDefined()
        {
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int singleDelimCount = random.Next(1,10);
            int multiDelimCount = random.Next(1,10);

            List<string> delimeters = new List<string>();

            while (singleDelimCount-- > 0)
            {
                delimeters.Add(chars[random.Next(chars.Length)].ToString());
            }

            while(multiDelimCount-- > 0)
            {
                int charCount = random.Next(2, 20);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < charCount; i++)
                {
                    sb.Append(chars[random.Next(chars.Length)]);
                }
                delimeters.Add(sb.ToString());
            }

            int val1 = random.Next(0, 1000);
            int val2 = random.Next(0, 1000);
            int val3 = random.Next(0, 1000);

            string delimeter1 = delimeters[random.Next(delimeters.Count)];
            string delimeter2 = delimeters[random.Next(delimeters.Count)];

            StringBuilder arg = new StringBuilder();

            foreach (string delimeter in delimeters)
            {
                arg.Append("//");
                arg.Append(delimeter.Length > 1 ? $"[{delimeter}]" : delimeter);
                arg.Append('\n');
            }
            arg.Append(val1);
            arg.Append(delimeter1);
            arg.Append(val2);
            arg.Append(delimeter2);
            arg.Append(val3);
            string argString = arg.ToString();
            int result = calculator.Calculate(arg.ToString());
            Assert.AreEqual(val1 + val2 + val3, result);
        }
    }
}