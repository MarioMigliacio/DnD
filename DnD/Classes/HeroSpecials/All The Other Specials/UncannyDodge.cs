﻿using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The UncannyDodge Special.
    /// </summary>
    public class UncannyDodge : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire UncannyDodge.
        /// </summary>
        public override int? MinimumLevelRequirement => 2;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.UncannyDodge;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.UncannyDodge;
    }
}
