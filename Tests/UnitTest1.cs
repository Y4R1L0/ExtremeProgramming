using App; 

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRomanNumbersParse()
        {
            Assert.AreEqual(1, RomanNumber.Parse("I").Value, "1 == I");
            Assert.AreEqual(1, RomanNumber.Parse("I").Value, "2 == II");
        }
    }
}