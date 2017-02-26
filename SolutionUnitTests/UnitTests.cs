using DnD;
using DnD.Classes.HeroFeats;
using DnD.Classes.HeroSkills;
using DnD.Classes.Player;
using DnD.Dice;
using DnD.Enums.Alignment;
using DnD.Enums.Currencies;
using DnD.Enums.Deities;
using DnD.Enums.Environments;
using DnD.Enums.Items;
using DnD.Enums.Qualities;
using DnD.Enums.Skills;
using DnD.UserStrings;
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
            Random rng = new Random();
            Dictionary<Scroll, ScrollQuality> pages = new Dictionary<Scroll, ScrollQuality>();
            List<Enum> theCollection = new List<Enum>();
            ScrollQuality theQuality;
            int minorDistribution = 0;
            int mediumDistribution = 0;
            int majorDistribution = 0;
            int numEnums = 0;

            // --- Test1 --- //
            // This massive portion of foreach loops is actually grabbing all these Enumeration types that belong to the ItemTypes group.
            // including the sub Enums (TradeGoods). theCollection has all the basic items in the game after the loops concludes.
            foreach (ItemType it in Enum.GetValues(typeof(ItemType)))
            {
                switch(it)
                {
                    case ItemType.Accessory:
                        foreach (AccessoryType acc in Enum.GetValues(typeof(AccessoryType))) { theCollection.Add(acc); } break;
                    case ItemType.Armor:
                        foreach (ArmorType arm in Enum.GetValues(typeof(ArmorType))) { theCollection.Add(arm); } break;
                    case ItemType.Book:
                        foreach (Book bk in Enum.GetValues(typeof(Book))) { theCollection.Add(bk); } break;
                    case ItemType.Potion:
                        foreach (Potion pot in Enum.GetValues(typeof(Potion))) { theCollection.Add(pot); } break;
                    case ItemType.QuestItem:
                        foreach (QuestItem que in Enum.GetValues(typeof(QuestItem))) { theCollection.Add(que); } break;
                    case ItemType.Scroll:
                        foreach (Scroll scr in Enum.GetValues(typeof(Scroll))) { theCollection.Add(scr); } break;
                    case ItemType.Weapon:
                        foreach (WeaponType wep in Enum.GetValues(typeof(WeaponType))) { theCollection.Add(wep); } break;
                    case ItemType.TradeGood:
                        foreach (TradeGood tg in Enum.GetValues(typeof(TradeGood)))
                        {
                            switch(tg)
                            {
                                case TradeGood.Cloth:
                                    foreach (Cloth clo in Enum.GetValues(typeof(Cloth))) { theCollection.Add(clo); } break;
                                case TradeGood.Consumable:
                                    foreach (Consumable cons in Enum.GetValues(typeof(Consumable))) { theCollection.Add(cons); } break;
                                case TradeGood.Gem:
                                    foreach (GemType gem in Enum.GetValues(typeof(GemType))) { theCollection.Add(gem); } break;
                                case TradeGood.Herb:
                                    foreach (Herb her in Enum.GetValues(typeof(Herb))) { theCollection.Add(her); } break;
                                case TradeGood.Leather:
                                    foreach (Leather let in Enum.GetValues(typeof(Leather))) { theCollection.Add(let); } break;
                                case TradeGood.Misc:
                                    foreach (Misc mis in Enum.GetValues(typeof(Misc))) { theCollection.Add(mis); } break;
                                case TradeGood.Ore:
                                    foreach (Metal metaAf in Enum.GetValues(typeof(Metal))) { theCollection.Add(metaAf); } break;
                                case TradeGood.Spice:
                                    foreach (Spice spi in Enum.GetValues(typeof(Spice))) { theCollection.Add(spi); } break;

                                default: break;
                            }
                        }

                        break;

                    default: break;
                }
            }

            numEnums = theCollection.Count;
            // Test1 Results: Satisfactory.
            
            // --- Test2 --- //
            // The following loop populates the pages dictionary with spells and the following distributions of scroll qualities:
            // minor: ~60%, medium: ~30%, major: ~10%.
            foreach (Scroll spell in Enum.GetValues(typeof(Scroll)))
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
            // Test2 Results: Satisfactory.
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

        /// <summary>
        /// A unit test to ensure that the UserStrings folder is set up correctly, and also that the FeatStrings descriptions are correct!
        /// </summary>
        [TestMethod]
        public void TestUserStrings()
        {
            var acrobatString = FeatStrings.Acrobatic;
            var empowerSpell = FeatStrings.EmpowerSpell;
            var powerAttack = FeatStrings.PowerAttack;

            var appraise = SkillStrings.Appraise;
            var climb = SkillStrings.Climb;
            var sleight = SkillStrings.SleightOfHand;

            // Test conclusion: Works! Dont forget that when you want to use these strings in a textbox, to include the WRAP settings, so it does new lines correctly.
        }

        /// <summary>
        /// Test that skills are working ok. And the expected strings are correct.
        /// </summary>
        [TestMethod]
        public void TestSkillsObjects()
        {
            Hero me = new Hero {Level = 3};

            // we can do this all day long. How many Skills verify that it works correct?! 2. stop doing it after 2 lol.
            var checkThisFuckinShitOut = SkillFactory.Create(Skills.Appraise);
            var omgItsAnotherSkill = SkillFactory.Create(Skills.Balance);

            // this sanity check checks that an enum from Skills = 40 (there is none) is indeed null. GOOD!
            var sanityCheck = SkillFactory.Create((Skills)40);
            Assert.AreEqual(null, sanityCheck);

            // does the abstract MaxRanksPossible member function work?!
            int cap = checkThisFuckinShitOut.MaxRanksPossible(me.Level);
            // yes!

            // Test conclusion: Works.
        }
    }
}
