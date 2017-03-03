using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SummonFamiliar Special.
    /// </summary>
    public class SummonFamiliar : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SummonFamiliar.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SummonFamiliar;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SummonFamiliar;
    }
}
