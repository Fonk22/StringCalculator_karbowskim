using System.Text;
using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test9
    {
        [TestMethod]
        public void MultiCharDelimiterCanBeDefinedOnTheFirstLine()
        {
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int charCount = random.Next(2, 20);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < charCount; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            string delimeter = sb.ToString();

            int val1 = random.Next(0, 1000);
            int val2 = random.Next(0, 1000);


            int result = calculator.Calculate($"//[{delimeter}]\n{val1}{delimeter}{val2}");
            Assert.AreEqual(val1 + val2, result);
        }
    }
}