using TDD_StringCalculator;
namespace TDD_StringCalculator_test
{
    [TestClass]
    public sealed class Test6
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativeNumbersThrowException()
        {
            StringCalculator calculator = new StringCalculator();
            Random random = new Random();

            int negVal = -random.Next();

            calculator.Calculate(negVal.ToString());
            
        }
    }
}