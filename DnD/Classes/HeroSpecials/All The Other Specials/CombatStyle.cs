﻿using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The CombatStyle Special.
    /// </summary>
    public class CombatStyle : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire CombatStyle.
        /// </summary>
        public override int? MinimumLevelRequirement => 2;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.CombatStyle;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.CombatStyle;
    }
}
