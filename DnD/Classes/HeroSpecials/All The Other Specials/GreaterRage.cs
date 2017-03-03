using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The GreaterRage Special.
    /// </summary>
    public class GreaterRage : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire GreaterRage.
        /// </summary>
        public override int? MinimumLevelRequirement => 11;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.GreaterRage;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.GreaterRage;
    }
}
