using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test5
    {
        [TestMethod]
        public void ThreeNumbersDelimitedEitherWayReturnSum()
        {
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int val1 = random.Next(0, 1000);
            int val2 = random.Next(0, 1000);
            int val3 = random.Next(0, 1000);

            int result1 = calculator.Calculate($"{val1}\n{val2}\n{val3}");
            int result2 = calculator.Calculate($"{val1}\n{val2},{val3}");
            int result3 = calculator.Calculate($"{val1},{val2}\n{val3}");
            int result4 = calculator.Calculate($"{val1},{val2},{val3}");

            Assert.AreEqual(val1 + val2 + val3, result1);
            Assert.AreEqual(val1 + val2 + val3, result2);
            Assert.AreEqual(val1 + val2 + val3, result3);
            Assert.AreEqual(val1 + val2 + val3, result4);
        }
    }
}
