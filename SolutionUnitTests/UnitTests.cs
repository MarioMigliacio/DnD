using DnD;
using DnD.Dice;
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

        /// <summary>
        /// A unit test to collectively test averages of the static Dice classes collection.
        /// </summary>
        [TestMethod]
        public void TestTheDice()
        {
            int d2Sum = 0, d3Sum = 0, d4Sum = 0, d6Sum = 0, d8Sum = 0, d10Sum = 0, d12Sum = 0, d20Sum = 0;
            int d2Avg = 0, d3Avg = 0, d4Avg = 0, d6Avg = 0, d8Avg = 0, d10Avg = 0, d12Avg = 0, d20Avg = 0;
            int numberRolled = 100000;

            // test the average for D2 at 100000 rolls.
            for (int i = 0; i < numberRolled; i++)
            {
                d2Sum += Dice.D2;
                d3Sum += Dice.D3;
                d4Sum += Dice.D4;
                d6Sum += Dice.D6;
                d8Sum += Dice.D8;
                d10Sum += Dice.D10;
                d12Sum += Dice.D12;
                d20Sum += Dice.D20;
            }

            d2Avg =  d2Sum / numberRolled;
            d3Avg = d3Sum / numberRolled;
            d4Avg = d4Sum / numberRolled;
            d6Avg = d6Sum / numberRolled;
            d8Avg = d8Sum / numberRolled;
            d10Avg = d10Sum / numberRolled;
            d12Avg = d12Sum / numberRolled;
            d20Avg = d20Sum / numberRolled;       
            
            // Conclusion: the test rolls averages appear to be consistently half of the value of the Dice roll which is acceptable.     
        }
    }
}
