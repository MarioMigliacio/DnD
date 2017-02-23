using DnD;
using DnD.Enums.Items;
using DnD.Enums.Qualities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

            Dictionary<Scroll, ScrollQuality> pages = new Dictionary<Scroll, ScrollQuality>();
            Random rng = new Random();
            ScrollQuality theQuality;
            int minorDistribution = 0;
            int mediumDistribution = 0;
            int majorDistribution = 0;

            // The following loop populates the pages dictionary with spells and the following distributions of scroll qualities:
            // minor: ~60%, medium: ~30%, major: ~10%.
            foreach(Scroll spell in Enum.GetValues(typeof(Scroll)))
            {
                int spawn = rng.Next(0, 101);

                if (spawn >= 90)
                {
                    theQuality = ScrollQuality.Major;
                    majorDistribution++;
                }
                else if (spawn >= 60 && spawn < 90)
                {
                    theQuality = ScrollQuality.Medium;
                    mediumDistribution++;
                }
                else
                {
                    theQuality = ScrollQuality.Minor;
                    minorDistribution++;
                }


                pages.Add(spell, theQuality);
            }
        }
    }
}
