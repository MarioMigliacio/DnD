using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The DamageReduction Special.
    /// </summary>
    public class DamageReduction : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire DamageReduction.
        /// </summary>
        public override int? MinimumLevelRequirement => 7;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.DamageReduction;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.DamageReduction;
    }
}
