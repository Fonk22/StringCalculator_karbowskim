using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void SinglNumberReturnsTheValue()
        {
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int val = random.Next(0, 1000);
            
            int result = calculator.Calculate(val.ToString());
            Assert.AreEqual(val, result);
        }
    }
}