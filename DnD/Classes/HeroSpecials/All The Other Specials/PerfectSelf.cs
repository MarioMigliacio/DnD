﻿using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The PerfectSelf Special.
    /// </summary>
    public class PerfectSelf : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire PerfectSelf.
        /// </summary>
        public override int? MinimumLevelRequirement => 20;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.PerfectSelf;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.PerfectSelf;
    }
}
