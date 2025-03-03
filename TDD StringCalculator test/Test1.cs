using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void AnEmptyStringReturnsZero()
        {
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Calculate(String.Empty);
            Assert.AreEqual(0, result);
        }
    }
}
