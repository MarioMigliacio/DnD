using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The DivineGrace Special.
    /// </summary>
    public class DivineGrace : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire DivineGrace.
        /// </summary>
        public override int? MinimumLevelRequirement => 2;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.DivineGrace;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.DivineGrace;
    }
}
