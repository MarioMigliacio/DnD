using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The ImprovedUncannyDodge Special.
    /// </summary>
    public class ImprovedUncannyDodge : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire ImprovedUncannyDodge.
        /// </summary>
        public override int? MinimumLevelRequirement => 5;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.ImprovedUncannyDodge;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.ImprovedUncannyDodge;
    }
}
