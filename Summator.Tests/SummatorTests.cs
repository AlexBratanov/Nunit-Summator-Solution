using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
      [Test]
        public void Test_Sum_TwoPossitive_Numbers()
        {
            int result = Summator.Sum(new int[] { 1, 2, 3 });
            Assert.That(result == 6);
        }
        [Test]
        public void Test_Sum_OnePossitive_Number()
        {
            int result = Summator.Sum(new int[] { 7 });
            Assert.That(result == 7);
        }
        [Test]
        public void Test_Average_TwoPossitive_Numbers()
        {
            int result = Summator.Average(new int[] { 5, 10, 15 });
            Assert.That(result == 10);
        }
    }
}