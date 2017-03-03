using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The ImprovedCombatStyle Special.
    /// </summary>
    public class ImprovedCombatStyle : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire ImprovedCombatStyle.
        /// </summary>
        public override int? MinimumLevelRequirement => 6;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.ImprovedCombatStyle;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.ImprovedCombatStyle;
    }
}
