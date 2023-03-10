using NUnit.Framework;
using QuilgoConsoleTestApp;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void NumberWithHighestOccurenceRate_TestIsCorrect()
        {
            //arrange
            int[] numbers = { 1, 1, 1, 2, 2, 3, 4, 4, 4, 4, 5, 5, 5, 5,5 };
            int rightAnswer = 5;

            //act
            int result = Solution.NumberWithHighestOccurenceRate(numbers);

            //assert
            Assert.AreEqual(rightAnswer, result);
        }

    }
}