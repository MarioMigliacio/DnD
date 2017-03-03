using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The HideInPlainSight Special.
    /// </summary>
    public class HideInPlainSight : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire HideInPlainSight.
        /// </summary>
        public override int? MinimumLevelRequirement => 17;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.HideInPlainSight;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.HideInPlainSight;
    }
}
