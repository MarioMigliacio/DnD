using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The ScribeScroll Special.
    /// </summary>
    public class ScribeScroll : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire ScribeScroll.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.ScribeScroll;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.ScribeScroll;
    }
}
