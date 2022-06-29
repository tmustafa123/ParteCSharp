using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParteCSharp;
namespace ParteCSharpTests
{
    [TestClass]
    public class ParteCSharpTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.PrintCharacterName(5, 9);
        }
        [TestMethod]
        public void TestIsPowerOfTwo()
        {
            Assert.IsTrue(Program.IsPowerOfTwo(2));
            Assert.IsFalse(Program.IsPowerOfTwo(3));
        }
    }
}
