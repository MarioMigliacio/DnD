﻿using DnD.Classes.CharacterClasses;
using DnD.Enums.ClassFeats;
using DnD.Enums.Stats;
using System.Collections.Generic;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Manyshot Feat.
    /// </summary>
    public class Manyshot : BaseFeat
    {
        /// <summary>
        /// Returns the value of required base attack for the Manyshot feat.
        /// </summary>
        public override int AttackBonusPrerequisites => 6;

        /// <summary>
        /// Returns the associated List of required Feats that the Manyshot feat requires.
        /// Null if no required Feats.
        /// </summary>
        public override List<BaseFeat> FeatPrerequisites => new List<BaseFeat> {new PointBlankShot(), new RapidShot()};

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        public override BaseCharacterClass ClassLevelPrerequisites => null;

        /// <summary>
        /// Returns a dictionary where KEY represents the required stat and VALUE = the value of that stat.
        /// </summary>
        public override Dictionary<Stats, int> MinimumRequiredStat => new Dictionary<Stats, int> {{Stats.Dexterity, 17}};

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.FeatStrings.Manyshot;

        /// <summary>
        /// Returns the enumeration type of Feat this particular Feat represents.
        /// </summary>
        public override ClassFeats FeatType => ClassFeats.Manyshot;
    }
}
