﻿using DnD.Classes.CharacterClasses;
using DnD.Enums.ClassFeats;
using DnD.Enums.ClassSkills;
using DnD.Enums.ClassSpecials;
using DnD.Enums.Stats;
using DnD.Interfaces;
using System.Collections.Generic;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The ImprovedPreciseShot Feat.
    /// </summary>
    public class ImprovedPreciseShot : BaseFeat, IHeroSpecialSkillFeats
    {
        /// <summary>
        /// Returns the value of required base attack for the ImprovedPreciseShot feat.
        /// </summary>
        public override int? AttackBonusPrerequisites => 11;

        /// <summary>
        /// Returns the associated List of required Feats that the ImprovedPreciseShot feat requires.
        /// Null if no required Feats.
        /// </summary>
        public override List<BaseFeat> FeatPrerequisites => new List<BaseFeat> {new PreciseShot(), new PointBlankShot()};

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        public override BaseCharacterClass ClassLevelPrerequisites => null;

        /// <summary>
        /// Returns a key value pair which corresponds to KEY = <see cref="Stats"/> and VALUE = the value of that stat.
        /// </summary>
        public override KeyValuePair<Stats, int>? MinimumRequiredStat => new KeyValuePair<Stats, int>(Stats.Dexterity, 19);

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public string Description => UserStrings.FeatStrings.ImprovedPreciseShot;

        /// <summary>
        /// Nullable Skill type enumerator value. If the inheriting object is of type Skill, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassSkills? SkillType => null;

        /// <summary>
        /// Nullable SpecialType enumerator value. If the inheriting object is of type SpecialType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassSpecial? SpecialType => null;

        /// <summary>
        /// Nullable FeatType enumerator value. If the inheriting object is of type FeatType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassFeats? FeatType => ClassFeats.ImprovedPreciseShot;
    }
}