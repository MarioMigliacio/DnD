using DnD.Classes.CharacterClasses;
using DnD.Enums.Stats;
using System.Collections.Generic;

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
        /// Returns a key value pair which corresponds to KEY = <see cref="BaseCharacterClass"/> and VALUE = the level of that class.
        /// Null if no required KEY/VALUE pair.
        /// </summary>
        public abstract KeyValuePair<BaseCharacterClass, int>? ClassLevelPrerequisites { get; }

        /// <summary>
        /// Returns a key value pair which corresponds to KEY = <see cref="Stats"/> and VALUE = the value of that stat.
        /// </summary>
        public abstract KeyValuePair<Stats, int>? MinimumRequiredStat { get; }        
    }
}
