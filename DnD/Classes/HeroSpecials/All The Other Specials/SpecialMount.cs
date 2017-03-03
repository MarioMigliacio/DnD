using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SpecialMount Special.
    /// </summary>
    public class SpecialMount : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SpecialMount.
        /// </summary>
        public override int? MinimumLevelRequirement => 5;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SpecialMount;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SpecialMount;
    }
}
