using DnD.Classes.CharacterClasses;
using DnD.Enums.ClassFeats;
using DnD.Enums.Stats;
using System.Collections.Generic;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The SpringAttack Feat.
    /// </summary>
    public class SpringAttack : BaseFeat
    {
        /// <summary>
        /// Returns the value of required base attack for the SpringAttack feat.
        /// </summary>
        public override int? AttackBonusPrerequisites => 4;

        /// <summary>
        /// Returns the associated List of required Feats that the SpringAttack feat requires.
        /// Null if no required Feats.
        /// </summary>
        public override List<BaseFeat> FeatPrerequisites => new List<BaseFeat> {new Dodge(), new Mobility()};

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        public override BaseCharacterClass ClassLevelPrerequisites => null;

        /// <summary>
        /// Returns a dictionary where KEY represents the required stat and VALUE = the value of that stat.
        /// </summary>
        public override Dictionary<Stats, int> MinimumRequiredStat => new Dictionary<Stats, int> {{Stats.Dexterity, 13}};

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.FeatStrings.SpringAttack;

        /// <summary>
        /// Returns the enumeration type of Feat this particular Feat represents.
        /// </summary>
        public override ClassFeats FeatType => ClassFeats.SpringAttack;
    }
}
