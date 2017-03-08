using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DnD.Classes.HeroFeats;
using DnD.Classes.HeroSkills;
using DnD.Classes.HeroSpecials;
using DnD.Classes.CharacterClasses;
using DnD.Enums.ClassTypes;
using DnD.Enums.Stats;
using DnD.Enums.Alignment;
using DnD.Enums.Races;
using DnD.Enums.SavingThrows;

namespace DnD.Classes.Player
{
    /// <summary>
    /// Represents the main player character that is to be created and utilized.
    /// </summary>
    public class Hero
    {
        #region Hero Properties

        /// <summary>
        /// As the character grows in strength, so to does their Level.
        /// </summary>
        public int Level { get; set; } = 0;

        /// <summary>
        /// HitDie governs how much health points maximum, a hero can earn upon leveling.
        /// </summary>
        public int HitDie { get; set; } = 0;

        /// <summary>
        /// The entire amount of health a hero has. Lose it all and die forever.
        /// </summary>
        public int MaxHp { get; set; } = 0;

        /// <summary>
        /// The current state of the hero's health bar. Cannot exceed MaxHp (unless special circumstances).
        /// </summary>
        public int CurrentHp { get; set; } = 0;

        /// <summary>
        /// The amount of extra attack given to the hero upon attack attempts. Governed by class and level.
        /// </summary>
        public int BaseAttackBonus { get; set; } = 0;

        /// <summary>
        /// The amount of available skill ranks a hero can place into the multitude of available skills. 
        /// Normally governed by intellect and level.
        /// </summary>
        public int SkillRanksAvailable { get; set; } = 0;

        /// <summary>
        /// The amount of available Feats the player may choose from.
        /// </summary>
        public int FeatsAvailable { get; set; } = 0;

        /// <summary>
        /// The fact that a ton of bonus feats make the game more complex is both a good and bad thing.
        /// This represents true if the Hero can acquire a certain bonus feat.
        /// </summary>
        public bool BonusFeatsAvailable { get; set; } = false;

        /// <summary>
        /// The amount of currency held by the hero.
        /// </summary>
        public int Currency { get; set; } = 0;

        /// <summary>
        /// Represents the Character Class for this hero.
        /// </summary>
        public BaseCharacterClass TypeOfCharacter { get; set; } = null;

        /// <summary>
        /// Represents how the player stands in regards to the law and respect towards others.
        /// </summary>
        public Alignment PlayerAlignment { get; set; } = Alignment.None;

        /// <summary>
        /// Represents the type of race the hero is.
        /// </summary>
        public RaceType PlayerRace { get; set; } = RaceType.None;

        /// <summary>
        /// The unique name for this hero.
        /// </summary>
        public string Name { get; set; } = null;

        /// <summary>
        /// The particular Gender for this hero.
        /// </summary>
        public string Gender { get; set; } = null;

        /// <summary>
        /// When placing skills, no skill may have more ranks then governed by SkillCap.
        /// </summary>
        public int SkillCap => Level + 3;

        #endregion 

        #region Hero Containers
        
        /// <summary>
        /// The hero's collection of Skills acquired.
        /// </summary>
        public List<BaseSkill> PlayerSkills { get; set; }

        /// <summary>
        /// The hero's collection of Specials acquired.
        /// </summary>
        public List<BaseSpecial> PlayerSpecials { get; set; }

        /// <summary>
        /// The hero's collection of Feats acquired.
        /// </summary>
        public List<BaseFeat> PlayerFeats { get; set; }

        /// <summary>
        /// The hero's collection of Stats and their values.
        /// </summary>
        public Dictionary<Stats, int> PlayerStats { get; set; }

        /// <summary>
        /// The hero's collection of Stat Modifiers.
        /// </summary>
        public Dictionary<Stats, int> PlayerModifiers { get; set; }

        /// <summary>
        /// The hero's collection of SavingThrows and their values.
        /// </summary>
        public Dictionary<SavingThrowType, int> PlayerSavingThrows { get; set; }

        #endregion
        
        #region Helper Methods

        /// <summary>
        /// Helper method to instantiate a Barbarian with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateBarbarian(Hero thisHero)
        {
            thisHero.HitDie = 12;
            thisHero.BaseAttackBonus = 1;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Barbarian();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            thisHero.PlayerSpecials.Add(new FastMovement());
            thisHero.PlayerSpecials.Add(new Illiteracy());
            thisHero.PlayerSpecials.Add(new Rage());
        }

        /// <summary>
        /// Helper method to instantiate a Bard with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateBard(Hero thisHero)
        {
            thisHero.HitDie = 6;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Bard();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new BardicMusic());
            thisHero.PlayerSpecials.Add(new BardicKnowledge());
            thisHero.PlayerSpecials.Add(new CounterSong());
            thisHero.PlayerSpecials.Add(new Fascinate());
            thisHero.PlayerSpecials.Add(new InspireCourage());
        }

        /// <summary>
        /// Helper method to instantiate a Cleric with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateCleric(Hero thisHero)
        {
            thisHero.HitDie = 8;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Cleric();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new TurnOrRebukeUndead());
        }

        /// <summary>
        /// Helper method to instantiate a Druid with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateDruid(Hero thisHero)
        {
            thisHero.HitDie = 8;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D6;
            thisHero.TypeOfCharacter = new Druid();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new AnimalCompanion());
            thisHero.PlayerSpecials.Add(new NatureSense());
            thisHero.PlayerSpecials.Add(new WildEmpathy());
        }

        /// <summary>
        /// Helper method to instantiate a Fighter with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateFighter(Hero thisHero)
        {
            thisHero.HitDie = 10;
            thisHero.BaseAttackBonus = 1;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Fighter();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            thisHero.BonusFeatsAvailable = true;
        }

        /// <summary>
        /// Helper method to instantiate a Monk with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateMonk(Hero thisHero)
        {
            thisHero.HitDie = 8;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Monk();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new FlurryOfBlows());
            thisHero.PlayerSpecials.Add(new UnarmedStrike());
            
            thisHero.BonusFeatsAvailable = true;
        }

        /// <summary>
        /// Helper method to instantiate a Paladin with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreatePaladin(Hero thisHero)
        {
            thisHero.HitDie = 10;
            thisHero.BaseAttackBonus = 1;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Paladin();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            thisHero.PlayerSpecials.Add(new AuraOfGood());
            thisHero.PlayerSpecials.Add(new DetectEvil());
            thisHero.PlayerSpecials.Add(new SmiteEvil());
        }

        /// <summary>
        /// Helper method to instantiate a Ranger with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateRanger(Hero thisHero)
        {
            thisHero.HitDie = 8;
            thisHero.BaseAttackBonus = 1;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Ranger();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            thisHero.PlayerSpecials.Add(new FavoredEnemy());
            thisHero.PlayerSpecials.Add(new Tracking());
            thisHero.PlayerSpecials.Add(new WildEmpathy());
        }

        /// <summary>
        /// Helper method to instantiate a Rogue with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateRogue(Hero thisHero)
        {
            thisHero.HitDie = 6;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Rogue();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            thisHero.PlayerSpecials.Add(new SneakAttack());
            thisHero.PlayerSpecials.Add(new TrapFinding());
        }

        /// <summary>
        /// Helper method to instantiate a Sorcerer with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateSorcerer(Hero thisHero)
        {
            thisHero.HitDie = 4;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            thisHero.TypeOfCharacter = new Sorcerer();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new SummonFamiliar());
        }

        /// <summary>
        /// Helper method to instantiate a Wizard with standardized hero properties.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void CreateWizard(Hero thisHero)
        {
            thisHero.HitDie = 4;
            thisHero.BaseAttackBonus = 0;
            thisHero.Currency = Dice.Dice.D6 + Dice.Dice.D6 + Dice.Dice.D6;
            thisHero.TypeOfCharacter = new Wizard();

            thisHero.PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            thisHero.PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            thisHero.PlayerSpecials.Add(new SummonFamiliar());
            thisHero.PlayerSpecials.Add(new EnscribeScroll());
        }

        /// <summary>
        /// An elf is a bullshit asshole who gets OP stats and skills upon creation IMAGINE THAT!!
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeElf(Hero thisHero)
        {
            if (!thisHero.PlayerSkills.Contains(new Listen()))
            {
                thisHero.PlayerSkills.Add(new Listen {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new Search()))
            {
                thisHero.PlayerSkills.Add(new Search {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new Spot()))
            {
                thisHero.PlayerSkills.Add(new Spot {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Gnomes are versatile in their ability to listen and craft.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeGnome(Hero thisHero)
        {
            if (!thisHero.PlayerSkills.Contains(new Listen()))
            {
                thisHero.PlayerSkills.Add(new Listen {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new Craft()))
            {
                thisHero.PlayerSkills.Add(new Craft {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Are you surprised that a HUMAN-ELF gets fucking OP also?! NO?? good. Imma nerf these fuckers hard some day.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeHalfElf(Hero thisHero)
        {
            if (!thisHero.PlayerSkills.Contains(new Listen()))
            {
                thisHero.PlayerSkills.Add(new Listen {NumberOfRanks = 1});
            }

            if (!thisHero.PlayerSkills.Contains(new Search()))
            {
                thisHero.PlayerSkills.Add(new Search {NumberOfRanks = 1});
            }

            if (!thisHero.PlayerSkills.Contains(new Spot()))
            {
                thisHero.PlayerSkills.Add(new Spot {NumberOfRanks = 1});
            }

            if (!thisHero.PlayerSkills.Contains(new Diplomacy()))
            {
                thisHero.PlayerSkills.Add(new Diplomacy {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new GatherInformation()))
            {
                thisHero.PlayerSkills.Add(new GatherInformation {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Half-orcs are just misunderstood creatures :( they just want to be strong, katuktuk smash.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeHalfOrc(Hero thisHero)
        {
            if (!thisHero.PlayerSkills.Contains(new Listen()))
            {
                thisHero.PlayerSkills.Add(new Climb {NumberOfRanks = 1});
            }

            if (!thisHero.PlayerSkills.Contains(new Swim()))
            {
                thisHero.PlayerSkills.Add(new Swim {NumberOfRanks = 1});
            }
        }

        /// <summary>
        /// Halflings are nimble little ankle-biters, did you not watch the lord of the rings? Golem ate that dudes finger! thats NIMBLE AF.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeHalfling(Hero thisHero)
        {
            if (!thisHero.PlayerSkills.Contains(new Climb()))
            {
                thisHero.PlayerSkills.Add(new Climb {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new Jump()))
            {
                thisHero.PlayerSkills.Add(new Jump {NumberOfRanks = 2});
            }

            if (!thisHero.PlayerSkills.Contains(new MoveSilently()))
            {
                thisHero.PlayerSkills.Add(new MoveSilently {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Humans are the youngest species of the races, and therefore have the most to prove. Their ability to learn fast is unparalelled.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void MakeHuman(Hero thisHero)
        {
            thisHero.SkillRanksAvailable += 4;
            thisHero.FeatsAvailable += 1;
        }

        /// <summary>
        /// The number of available skill ranks depends on the rolled intellect for the hero as well as the class of hero.
        /// This is intended for the creation process of a lvl 1 hero. 
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        /// <returns>Returns the value which should be set for SkillRanksAvailable.</returns>
        private static int DetermineSkillRanks(Hero thisHero)
        {
            int retval = 0;

            switch (thisHero.TypeOfCharacter.CharacterClassType)
            {
                case ClassType.Barbarian: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Bard: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 6) * 4; break;
                case ClassType.Cleric: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Druid: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Fighter: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Monk: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Paladin: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Ranger: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 6) * 4; break;
                case ClassType.Rogue: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 8) * 4; break;
                case ClassType.Sorcerer: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Wizard: retval = (thisHero.PlayerModifiers[Stats.Intellect] + 2) * 4; break;
            }

            return retval;
        }

        /// <summary>
        /// A helper method that Populates the heros PlayerModifiers property to the expected value.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        public static void DetermineStatModifiers(Hero thisHero)
        {
            foreach (var stat in thisHero.PlayerStats)
            {
                int theValue = 0;

                switch (stat.Value)
                {
                    case 0: case 1: theValue = -5; break;
                    case 2: case 3: theValue = -4; break;
                    case 4: case 5: theValue = -3; break;
                    case 6: case 7: theValue = -2; break;
                    case 8: case 9: theValue = -1; break;
                    case 10: case 11: theValue = 0; break;
                    case 12: case 13: theValue = 1; break;
                    case 14: case 15: theValue = 2; break;
                    case 16: case 17: theValue = 3; break;
                    case 18: case 19: theValue = 4; break;
                    case 20: case 21: theValue = 5; break;
                    case 22: case 23: theValue = 6; break;
                    default: theValue = 0; break;
                }

                thisHero.PlayerModifiers.Add(stat.Key, theValue);
            }
        }

        /// <summary>
        /// A helper method that directly influences the PlayerStats property based on the influence of the PlayerRace selected.
        /// </summary>
        /// <param name="thisHero">What hero object we are modifying to set up.</param>
        private static void ApplyRacialBonus(Hero thisHero)
        {
            switch (thisHero.PlayerRace)
            {
                case RaceType.Dwarf:
                    thisHero.PlayerStats[Stats.Constitution] += 2;
                    thisHero.PlayerStats[Stats.Charisma] -= 2;
                    break;
                case RaceType.Elf:
                    thisHero.PlayerStats[Stats.Dexterity] += 2;
                    thisHero.PlayerStats[Stats.Constitution] -= 2;
                    MakeElf(thisHero);
                    break;
                case RaceType.Gnome:
                    thisHero.PlayerStats[Stats.Constitution] += 2;
                    thisHero.PlayerStats[Stats.Strength] -= 2;
                    MakeGnome(thisHero);
                    break;
                case RaceType.HalfOrc:
                    thisHero.PlayerStats[Stats.Strength] += 3;
                    thisHero.PlayerStats[Stats.Intellect] -= 2;
                    thisHero.PlayerStats[Stats.Charisma] -= 2;
                    MakeHalfOrc(thisHero);
                    break;
                case RaceType.Halfling:
                    thisHero.PlayerStats[Stats.Dexterity] += 2;
                    thisHero.PlayerStats[Stats.Strength] -= 2;
                    MakeHalfling(thisHero);
                    break;
                case RaceType.Human:
                    MakeHuman(thisHero);
                    break;
                case RaceType.HalfElf:
                    MakeHalfElf(thisHero);
                    break;
                default: break;
            }
        }

        #endregion

        #region GetHero stuff

        /// <summary>
        /// Acquire a new instance of a default constructed hero. 
        /// </summary>
        /// <returns>A default construction of the Hero class.</returns>
        public static Hero GetInitialHero()
        {
            Hero thisHero = new Hero
            {
                Level = 1,
                PlayerSkills = new List<BaseSkill>(),
                PlayerSpecials = new List<BaseSpecial>(),
                PlayerFeats = new List<BaseFeat>(),
                PlayerStats = new Dictionary<Stats, int>(),
                PlayerModifiers = new Dictionary<Stats, int>(),
                PlayerSavingThrows = new Dictionary<SavingThrowType, int>()
            };
            

            return thisHero;
        }

        /// <summary>
        /// Acquire a new instance of a stage two constructed hero.
        /// </summary>
        /// <param name="which">Defines what kind of hero class we're looking at.</param>
        /// <param name="what">Defines what kind of race the hero is.</param>
        /// <param name="givenStats">Gives the hero a populated dictionary of stats.</param>
        /// <returns>A completed construction of the hero class.</returns>
        public static Hero GetStageTwoHero(ClassType which, RaceType what, Dictionary<Stats, int> givenStats)
        {
            Hero thisHero = GetInitialHero();
            thisHero.PlayerStats = givenStats;

            switch (which)
            {
                case ClassType.Barbarian: CreateBarbarian(thisHero); break;
                case ClassType.Bard: CreateBard(thisHero); break;
                case ClassType.Cleric: CreateCleric(thisHero); break;
                case ClassType.Druid: CreateDruid(thisHero); break;
                case ClassType.Fighter: CreateFighter(thisHero); break;
                case ClassType.Monk: CreateMonk(thisHero); break;
                case ClassType.Paladin: CreatePaladin(thisHero); break;
                case ClassType.Ranger: CreateRanger(thisHero); break;
                case ClassType.Rogue: CreateRogue(thisHero); break;
                case ClassType.Sorcerer: CreateSorcerer(thisHero); break;
                case ClassType.Wizard: CreateWizard(thisHero); break;
                default: break;
            }

            switch (what)
            {
                case RaceType.Dwarf: thisHero.PlayerRace = RaceType.Dwarf; break;
                case RaceType.Elf: thisHero.PlayerRace = RaceType.Elf; break;
                case RaceType.Gnome: thisHero.PlayerRace = RaceType.Gnome; break;
                case RaceType.HalfElf: thisHero.PlayerRace = RaceType.HalfElf; break;
                case RaceType.HalfOrc: thisHero.PlayerRace = RaceType.HalfOrc; break;
                case RaceType.Halfling: thisHero.PlayerRace = RaceType.Halfling; break;
                case RaceType.Human: thisHero.PlayerRace = RaceType.Human; break;
                default: break;
            }

            thisHero.MaxHp = thisHero.HitDie;
            thisHero.CurrentHp = thisHero.MaxHp;
            
            ApplyRacialBonus(thisHero);
            DetermineStatModifiers(thisHero);
            thisHero.SkillRanksAvailable += DetermineSkillRanks(thisHero);
            thisHero.FeatsAvailable += 1;

            return thisHero;
        }

        #endregion
    }
}
