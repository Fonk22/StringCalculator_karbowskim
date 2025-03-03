using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test8
    {
        [TestMethod]
        public void SingleCharDelimeterCanBeDefinedOnFirsLine()
        {
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            foreach (char delimeter in chars)
            {
                int val1 = random.Next(0, 1000);
                int val2 = random.Next(0, 1000);
                int result = calculator.Calculate($"//{delimeter}\n{val1}{delimeter}{val2}");
                Assert.AreEqual(val1 + val2, result);
            }
        }
    }
}