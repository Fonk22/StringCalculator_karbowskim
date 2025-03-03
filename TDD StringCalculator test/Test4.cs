using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test4
    {
        [TestMethod]
        public void TwoNumbersNewLineDelimetedReturnsSum()
        {
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int val1 = random.Next(0, 1000);
            int val2 = random.Next(0, 1000);

            int result = calculator.Calculate($"{val1}\n{val2}");
            Assert.AreEqual(val1 + val2, result);
        }
    }
}
