using DnD.Classes.CharacterClasses;
using DnD.Enums.Stats;
using System.Collections.Generic;
using DnD.Enums.ClassFeats;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Base Feat class is an abstract entity which satisfies the required generic prerequisites for any type of feat.
    /// Whether it be a list of Feat type enums, Particular character class levels, or minimum stat requirements.
    /// Also supports a description of the feat.
    /// </summary>
    public abstract class BaseFeat
    {
        /// <summary>
        /// Returns the value of required base attack that this particular feat requires.
        /// </summary>
        public abstract int? AttackBonusPrerequisites { get; }

        /// <summary>
        /// Returns the associated List of required feats that this particular feat requires.
        /// Null if no required feat.
        /// </summary>
        public abstract List<BaseFeat> FeatPrerequisites { get; }

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        public abstract BaseCharacterClass ClassLevelPrerequisites { get; }

        /// <summary>
        /// Returns a dictionary where KEY represents the required stat and VALUE = the value of that stat.
        /// </summary>
        public abstract Dictionary<Stats, int> MinimumRequiredStat { get; }

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Returns the enumeration type of Feat this particular Feat represents.
        /// </summary>
        public abstract ClassFeats FeatType { get; }
    }
}
