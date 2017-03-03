using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The DivineHealth Special.
    /// </summary>
    public class DivineHealth : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire DivineHealth.
        /// </summary>
        public override int? MinimumLevelRequirement => 3;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.DivineHealth;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.DivineHealth;
    }
}
