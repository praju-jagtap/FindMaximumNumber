using FindMaxNo;

namespace MaxNoTest
{
    public class Tests
    {
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            int num = findMaxNo.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(3, num);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            int num = findMaxNo.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(3, num);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            int num = findMaxNo.FindMaxIntNumber(1, 2, 3);
            Assert.AreEqual(3, num);
        }

    }
}