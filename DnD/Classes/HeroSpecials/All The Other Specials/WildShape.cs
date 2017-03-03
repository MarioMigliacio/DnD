using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The WildShape Special.
    /// </summary>
    public class WildShape : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire WildShape.
        /// </summary>
        public override int? MinimumLevelRequirement => 5;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.WildShape;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.WildShape;
    }
}
