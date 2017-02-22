using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD.Enums.Items;
using DnD.Enums.Qualities;

namespace SolutionUnitTests
{
    /// <summary>
    /// The area of the DnD project where unit tests take place. Be smart about planning, dont waste time and be the LAZY programmer who 
    /// actually is not so lazy in reality. (make significant use of your time, dont double back on BS that you dont need to)
    /// </summary>
    [TestClass]
    public class SolutionUnitTests
    {
        /// <summary>
        /// This is the first unit test in place. Try and make sure the VAST expanse of items to be incorporated into the game actually work.
        /// Are enumerable, and can be used in a meaningful way.
        /// </summary>
        [TestMethod]
        public void EnumerateTheThings()
        {
            // ItemType is the Generic Item to be enumerated across.
            var first = ItemType.Weapon;
            var second = ItemType.Book;
            Assert.AreNotEqual(first, second);
            Assert.AreEqual(first, ItemType.Weapon);
        }
    }
}
