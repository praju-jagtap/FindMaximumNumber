using FindMaxNo;

namespace MaxNoTest
{
    public class Tests
    {

        [Test]
        public void GivenMaxFirstPositionInt_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> findMax = new FindMaxGenerics<int>(3, 1, 2);
            int num = findMax.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxSecondPositionInt_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> findMax = new FindMaxGenerics<int>(1, 3, 2);
            int num = findMax.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxThirdPositionInt_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<int> findMax = new FindMaxGenerics<int>(1, 2, 3);
            int num = findMax.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxFirstPositionFloat_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> findMax = new FindMaxGenerics<float>(3.1f, 1.1f, 2.1f);
            float num = findMax.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxSecondPositionFloat_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> findMax = new FindMaxGenerics<float>(1.1f, 3.1f, 2.1f);
            float num = findMax.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxThirdPositionFloat_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<float> findMax = new FindMaxGenerics<float>(1.1f, 2.1f, 3.1f);
            float num = findMax.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxFirstPositionString_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> findMax = new FindMaxGenerics<string>("peach", "apple", "banana");
            string num = findMax.FindMax();
            Assert.AreEqual(num, "peach");
        }
        [Test]
        public void GivenMaxSecondPositionString_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> findMax = new FindMaxGenerics<string>("apple", "peach", "banana");
            string num = findMax.FindMax();
            Assert.AreEqual(num, "peach");
        }
        [Test]
        public void GivenMaxThirdPositionString_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenerics<string> findMax = new FindMaxGenerics<string>("apple", "banana", "peach");
            string num = findMax.FindMax();
            Assert.AreEqual(num, "peach");
        }
    }
}