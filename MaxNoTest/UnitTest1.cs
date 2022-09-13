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
        [Test]
        public void GivenMaxFloatFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            float num = findMaxNo.FindMaxFloatNumber(3.1f, 1.1f, 2.1f);
            Assert.AreEqual(3.1f, num);
        }
        [Test]
        public void GivenMaxFloatSecondtNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            float num = findMaxNo.FindMaxFloatNumber(1.1f, 3.1f, 2.1f);
            Assert.AreEqual(3.1f, num);
        }
        [Test]
        public void GivenMaxFloatThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo findMaxNo = new MaxNo();
            float num = findMaxNo.FindMaxFloatNumber(1.1f, 2.1f, 3.1f);
            Assert.AreEqual(3.1f, num);
        }
        [Test]
        public void GivenMaxStringFirst_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo max = new MaxNo();
            string num = max.FindMaxStringNumber("peach", "apple", "banana");
            Assert.AreEqual("peach", num);
        }
        [Test]
        public void GivenMaxStringSecond_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo max = new MaxNo();
            string num = max.FindMaxStringNumber("apple", "peach", "banana");
            Assert.AreEqual("peach", num);
        }
        [Test]
        public void GivenMaxStringThird_WhenAnalized_ShouldReturnMaxNumber()
        {
            MaxNo max = new MaxNo();
            string num = max.FindMaxStringNumber("apple", "banana", "peach");
            Assert.AreEqual("peach", num);
        }
    }
}