using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test7
    {
        [TestMethod]
        public void NumbersGreaterThanThousandAreIgnored()
        {
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int ignoredVal = random.Next(1001, int.MaxValue);
            int val1 = random.Next(0, 1000);
            int val2 = random.Next(0, 1000);

            int res1 = calculator.Calculate(ignoredVal.ToString());
            int res2 = calculator.Calculate($"{val1},{ignoredVal}");
            int res3 = calculator.Calculate($"{val1},{ignoredVal},{val2}");

            Assert.AreEqual(0, res1);
            Assert.AreEqual(val1, res2);
            Assert.AreEqual(val1 + val2, res3);
        }
    }
}