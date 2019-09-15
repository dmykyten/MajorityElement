using Microsoft.VisualStudio.TestTools.UnitTesting;
using MajorityElement;

namespace MajorityElement.Tests
{
    [TestClass]
    public class MajorityElementTests
    {
        [TestMethod]
        public void StringToIntArray()
        {
            var tested = new MajorityElement();

            CollectionAssert.AreEqual(
                tested.StringToIntArray("123"),
                new[] {1, 2, 3}
            );

            CollectionAssert.AreEqual(
                tested.StringToIntArray("112222"),
                new[] { 1, 1, 2, 2, 2, 2 }
            );
        }

        [TestMethod]
        public void FindBiggestNumber()
        {
            var solution = new MajorityElement();

            Assert.AreEqual(
                solution.FindBiggestNumber(new[] { 1, 2, 2, 2, 3 }),
                2
            );
            Assert.AreEqual(
                solution.FindBiggestNumber(new int[] {}),
                -1
            );

            Assert.AreEqual(
                solution.FindBiggestNumber(new int[] { 1, 2, 3}),
                -1
            );

            Assert.AreEqual(
                solution.FindBiggestNumber(new[] { 1, 2, 2, 3, 4, 4, 4, 4, 4 }),
                4
            );
        }
    }
}
