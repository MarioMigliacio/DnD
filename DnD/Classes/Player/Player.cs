using System.Collections.Generic;
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
        public int Level { get; private set; } = 0;

        /// <summary>
        /// HitDie governs how much health points maximum, a hero can earn upon leveling.
        /// </summary>
        public int HitDie { get; private set; } = 0;

        /// <summary>
        /// The entire amount of health a hero has. Lose it all and die forever.
        /// </summary>
        public int MaxHp { get; private set; } = 0;

        /// <summary>
        /// The current state of the hero's health bar. Cannot exceed MaxHp (unless special circumstances).
        /// </summary>
        public int CurrentHp { get; private set; } = 0;

        /// <summary>
        /// The amount of extra attack given to the hero upon attack attempts. Governed by class and level.
        /// </summary>
        public int BaseAttackBonus { get; private set; } = 0;

        /// <summary>
        /// The amount of available skill ranks a hero can place into the multitude of available skills. 
        /// Normally governed by intellect and level.
        /// </summary>
        public int SkillRanksAvailable { get; private set; } = 0;

        /// <summary>
        /// The amount of available Feats the player may choose from.
        /// </summary>
        public int FeatsAvailable { get; private set; } = 0;

        /// <summary>
        /// The amount of currency held by the hero.
        /// </summary>
        public int Currency { get; private set; } = 0;

        /// <summary>
        /// Represents the Character Class for this hero.
        /// </summary>
        public BaseCharacterClass TypeOfCharacter { get; private set; } = null;

        /// <summary>
        /// Represents how the player stands in regards to the law and respect towards others.
        /// </summary>
        public Alignment PlayerAlignment { get; private set; }

        /// <summary>
        /// Represents the type of race the hero is.
        /// </summary>
        public RaceType PlayerRace { get; private set; }

        /// <summary>
        /// The unique name for this hero.
        /// </summary>
        public string Name { get; private set; } = null;

        /// <summary>
        /// When placing skills, no skill may have more ranks then governed by SkillCap.
        /// </summary>
        public int SkillCap => Level + 3;

        #endregion 

        #region Hero Containers
        
        /// <summary>
        /// The hero's collection of Skills acquired.
        /// </summary>
        public List<BaseSkill> PlayerSkills { get; }

        /// <summary>
        /// The hero's collection of Specials acquired.
        /// </summary>
        public List<BaseSpecial> PlayerSpecials { get; }

        /// <summary>
        /// The hero's collection of Feats acquired.
        /// </summary>
        public List<BaseFeat> PlayerFeats { get; }

        /// <summary>
        /// The hero's collection of Stats and their values.
        /// </summary>
        public Dictionary<Stats, int> PlayerStats { get; }

        /// <summary>
        /// The hero's collection of Stat Modifiers.
        /// </summary>
        public Dictionary<Stats, int> PlayerModifiers { get; }

        /// <summary>
        /// The hero's collection of SavingThrows and their values.
        /// </summary>
        public Dictionary<SavingThrowType, int> PlayerSavingThrows { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// The Default constructor for a Hero player. Gives a base level, and creates new containers for advanced data types pertinent to a hero.
        /// </summary>
        public Hero()
        {
            Level = 1;
            PlayerSkills = new List<BaseSkill>();
            PlayerSpecials = new List<BaseSpecial>();
            PlayerFeats = new List<BaseFeat>();
            PlayerStats = new Dictionary<Stats, int>();
            PlayerModifiers = new Dictionary<Stats, int>();
            PlayerSavingThrows = new Dictionary<SavingThrowType, int>();
        }

        /// <summary>
        /// The Second stage for developing a character. Takes the very basic parameters from the default constructor
        /// and continues to build the character as more information becomes available.
        /// Call this constructor once we know what class type and race the player has chosen.
        /// </summary>
        /// <param name="fromBase">The Hero object we build off of.</param>
        /// <param name="which">The Class type the person has chosen for this hero.</param>
        /// <param name="what">The Race type the person has chosen for this hero.</param>
        /// <param name="givenStats">The supplied stats that were rolled for this hero.</param>
        public Hero(Hero fromBase, ClassType which, RaceType what, Dictionary<Stats, int> givenStats)
        {
            Level = fromBase.Level;
            PlayerSkills = fromBase.PlayerSkills;
            PlayerSpecials = fromBase.PlayerSpecials;
            PlayerFeats = fromBase.PlayerFeats;
            PlayerModifiers = fromBase.PlayerModifiers;
            PlayerSavingThrows = fromBase.PlayerSavingThrows;
            PlayerStats = givenStats;

            switch (which)
            {
                case ClassType.Barbarian: CreateBarbarian(); break;
                case ClassType.Bard: CreateBard(); break;
                case ClassType.Cleric: CreateCleric(); break;
                case ClassType.Druid: CreateDruid();break;
                case ClassType.Fighter: CreateFighter(); break;
                case ClassType.Monk: CreateMonk(); break;
                case ClassType.Paladin: CreatePaladin(); break;
                case ClassType.Ranger: CreateRanger(); break;
                case ClassType.Rogue: CreateRogue(); break;
                case ClassType.Sorcerer: CreateSorcerer(); break;
                case ClassType.Wizard: CreateWizard(); break;
                default:break;
            }

            switch (what)
            {
                case RaceType.Dwarf: PlayerRace = RaceType.Dwarf; break;
                case RaceType.Elf: PlayerRace = RaceType.Elf; break;
                case RaceType.Gnome: PlayerRace = RaceType.Gnome; break;
                case RaceType.HalfElf: PlayerRace = RaceType.HalfElf; break;
                case RaceType.HalfOrc: PlayerRace = RaceType.HalfOrc; break;
                case RaceType.Halfling: PlayerRace = RaceType.Halfling; break;
                case RaceType.Human: PlayerRace = RaceType.Human; break;
                default: break;
            }

            MaxHp = HitDie;
            CurrentHp = MaxHp;

            DetermineStatModifiers();
            ApplyRacialBonus();
            SkillRanksAvailable = DetermineSkillRanks();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Helper method to instantiate a Barbarian with standardized hero properties.
        /// </summary>
        private void CreateBarbarian()
        {
            HitDie = 12;
            BaseAttackBonus = 1;
            Currency = Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Barbarian();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            PlayerSpecials.Add(new FastMovement());
            PlayerSpecials.Add(new Illiteracy());
            PlayerSpecials.Add(new Rage());
        }

        /// <summary>
        /// Helper method to instantiate a Bard with standardized hero properties.
        /// </summary>
        private void CreateBard()
        {
            HitDie = 6;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Bard();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new BardicMusic());
            PlayerSpecials.Add(new BardicKnowledge());
            PlayerSpecials.Add(new CounterSong());
            PlayerSpecials.Add(new Fascinate());
            PlayerSpecials.Add(new InspireCourage());
        }

        /// <summary>
        /// Helper method to instantiate a Cleric with standardized hero properties.
        /// </summary>
        private void CreateCleric()
        {
            HitDie = 8;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D4;
            TypeOfCharacter = new Cleric();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new TurnOrRebukeUndead());
        }

        /// <summary>
        /// Helper method to instantiate a Druid with standardized hero properties.
        /// </summary>
        private void CreateDruid()
        {
            HitDie = 8;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D6;
            TypeOfCharacter = new Druid();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new AnimalCompanion());
            PlayerSpecials.Add(new NatureSense());
            PlayerSpecials.Add(new WildEmpathy());
        }

        /// <summary>
        /// Helper method to instantiate a Fighter with standardized hero properties.
        /// </summary>
        private void CreateFighter()
        {
            HitDie = 10;
            BaseAttackBonus = 1;
            Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Fighter();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            // this bonus feat must be selected from the specific fighter bonus feats.
            PlayerSpecials.Add(new BonusFeat());
        }

        /// <summary>
        /// Helper method to instantiate a Monk with standardized hero properties.
        /// </summary>
        private void CreateMonk()
        {
            HitDie = 8;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Monk();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new FlurryOfBlows());
            PlayerSpecials.Add(new UnarmedStrike());

            // this bonus feat must either be improved grapple or stunning fist!
            PlayerSpecials.Add(new BonusFeat());
        }

        /// <summary>
        /// Helper method to instantiate a Paladin with standardized hero properties.
        /// </summary>
        private void CreatePaladin()
        {
            HitDie = 10;
            BaseAttackBonus = 1;
            Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Paladin();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            PlayerSpecials.Add(new AuraOfGood());
            PlayerSpecials.Add(new DetectEvil());
            PlayerSpecials.Add(new SmiteEvil());
        }

        /// <summary>
        /// Helper method to instantiate a Ranger with standardized hero properties.
        /// </summary>
        private void CreateRanger()
        {
            HitDie = 8;
            BaseAttackBonus = 1;
            Currency = Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Ranger();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 2);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            PlayerSpecials.Add(new FavoredEnemy());
            PlayerSpecials.Add(new Tracking());
            PlayerSpecials.Add(new WildEmpathy());
        }

        /// <summary>
        /// Helper method to instantiate a Rogue with standardized hero properties.
        /// </summary>
        private void CreateRogue()
        {
            HitDie = 6;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Rogue();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 2);
            PlayerSavingThrows.Add(SavingThrowType.Will, 0);

            PlayerSpecials.Add(new SneakAttack());
            PlayerSpecials.Add(new TrapFinding());
        }

        /// <summary>
        /// Helper method to instantiate a Sorcerer with standardized hero properties.
        /// </summary>
        private void CreateSorcerer()
        {
            HitDie = 4;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D4 + Dice.Dice.D4 + Dice.Dice.D4;
            TypeOfCharacter = new Sorcerer();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new SummonFamiliar());
        }

        /// <summary>
        /// Helper method to instantiate a Wizard with standardized hero properties.
        /// </summary>
        private void CreateWizard()
        {
            HitDie = 4;
            BaseAttackBonus = 0;
            Currency = Dice.Dice.D6 + Dice.Dice.D6 + Dice.Dice.D6;
            TypeOfCharacter = new Wizard();

            PlayerSavingThrows.Add(SavingThrowType.Fortitude, 0);
            PlayerSavingThrows.Add(SavingThrowType.Reflex, 0);
            PlayerSavingThrows.Add(SavingThrowType.Will, 2);

            PlayerSpecials.Add(new SummonFamiliar());
            PlayerSpecials.Add(new EnscribeScroll());
        }

        /// <summary>
        /// An elf is a bullshit asshole who gets OP stats and skills upon creation IMAGINE THAT!!
        /// </summary>
        private void MakeElf()
        {
            if (!PlayerSkills.Contains(new Listen()))
            {
                PlayerSkills.Add(new Listen {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new Search()))
            {
                PlayerSkills.Add(new Search {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new Spot()))
            {
                PlayerSkills.Add(new Spot {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Gnomes are versatile in their ability to listen and craft.
        /// </summary>
        private void MakeGnome()
        {
            if (!PlayerSkills.Contains(new Listen()))
            {
                PlayerSkills.Add(new Listen {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new Craft()))
            {
                PlayerSkills.Add(new Craft {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Are you surprised that a HUMAN-ELF gets fucking OP also?! NO?? good. Imma nerf these fuckers hard some day.
        /// </summary>
        private void MakeHalfElf()
        {
            if (!PlayerSkills.Contains(new Listen()))
            {
                PlayerSkills.Add(new Listen {NumberOfRanks = 1});
            }

            if (!PlayerSkills.Contains(new Search()))
            {
                PlayerSkills.Add(new Search {NumberOfRanks = 1});
            }

            if (!PlayerSkills.Contains(new Spot()))
            {
                PlayerSkills.Add(new Spot {NumberOfRanks = 1});
            }

            if (!PlayerSkills.Contains(new Diplomacy()))
            {
                PlayerSkills.Add(new Diplomacy {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new GatherInformation()))
            {
                PlayerSkills.Add(new GatherInformation {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Half-orcs are just misunderstood creatures :( they just want to be strong, katuktuk smash.
        /// </summary>
        private void MakeHalfOrc()
        {
            if (!PlayerSkills.Contains(new Listen()))
            {
                PlayerSkills.Add(new Climb {NumberOfRanks = 1});
            }

            if (!PlayerSkills.Contains(new Swim()))
            {
                PlayerSkills.Add(new Swim {NumberOfRanks = 1});
            }
        }

        /// <summary>
        /// Halflings are nimble little ankle-biters, did you not watch the lord of the rings? Golem ate that dudes finger! thats NIMBLE AF.
        /// </summary>
        private void MakeHalfling()
        {
            if (!PlayerSkills.Contains(new Climb()))
            {
                PlayerSkills.Add(new Climb {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new Jump()))
            {
                PlayerSkills.Add(new Jump {NumberOfRanks = 2});
            }

            if (!PlayerSkills.Contains(new MoveSilently()))
            {
                PlayerSkills.Add(new MoveSilently {NumberOfRanks = 2});
            }
        }

        /// <summary>
        /// Humans are the youngest species of the races, and therefore have the most to prove. Their ability to learn fast is unparalelled.
        /// </summary>
        private void MakeHuman()
        {
            SkillRanksAvailable += 4;
            FeatsAvailable += 1;
        }

        /// <summary>
        /// The number of available skill ranks depends on the rolled intellect for the hero as well as the class of hero.
        /// </summary>
        /// <returns>Returns the value which should be set for SkillRanksAvailable.</returns>
        private int DetermineSkillRanks()
        {
            int retval = 0;

            switch (TypeOfCharacter.CharacterClassType)
            {
                case ClassType.Barbarian: retval = (PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Bard: retval = (PlayerModifiers[Stats.Intellect] + 6) * 4; break;
                case ClassType.Cleric: retval = (PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Druid: retval = (PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Fighter: retval = (PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Monk: retval = (PlayerModifiers[Stats.Intellect] + 4) * 4; break;
                case ClassType.Paladin: retval = (PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Ranger: retval = (PlayerModifiers[Stats.Intellect] + 6) * 4; break;
                case ClassType.Rogue: retval = (PlayerModifiers[Stats.Intellect] + 8) * 4; break;
                case ClassType.Sorcerer: retval = (PlayerModifiers[Stats.Intellect] + 2) * 4; break;
                case ClassType.Wizard: retval = (PlayerModifiers[Stats.Intellect] + 2) * 4; break;
            }

            return retval;
        }

        /// <summary>
        /// A helper method that Populates the heros PlayerModifiers property to the expected value.
        /// </summary>
        private void DetermineStatModifiers()
        {
            foreach (var stat in PlayerStats)
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

                PlayerModifiers.Add(stat.Key, theValue);
            }
        }

        /// <summary>
        /// A helper method that directly influences the PlayerStats property based on the influence of the PlayerRace selected.
        /// </summary>
        private void ApplyRacialBonus()
        {
            switch (PlayerRace)
            {
                case RaceType.Dwarf:
                    PlayerStats[Stats.Constitution] += 2;
                    PlayerStats[Stats.Charisma] -= 2;
                    break;
                case RaceType.Elf:
                    PlayerStats[Stats.Dexterity] += 2;
                    PlayerStats[Stats.Constitution] -= 2;
                    MakeElf();
                    break;
                case RaceType.Gnome:
                    PlayerStats[Stats.Constitution] += 2;
                    PlayerStats[Stats.Strength] -= 2;
                    MakeGnome();
                    break;
                case RaceType.HalfOrc:
                    PlayerStats[Stats.Strength] += 3;
                    PlayerStats[Stats.Intellect] -= 2;
                    PlayerStats[Stats.Charisma] -= 2;
                    MakeHalfOrc();
                    break;
                case RaceType.Halfling:
                    PlayerStats[Stats.Dexterity] += 2;
                    PlayerStats[Stats.Strength] -= 2;
                    MakeHalfling();
                    break;
                case RaceType.Human:
                    MakeHuman();
                    break;
                case RaceType.HalfElf:
                    MakeHalfElf();
                    break;
                default: break;
            }
        }

        #endregion
    }
}
