using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The QuiveringPalm Special.
    /// </summary>
    public class QuiveringPalm : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire QuiveringPalm.
        /// </summary>
        public override int? MinimumLevelRequirement => 15;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.QuiveringPalm;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.QuiveringPalm;
    }
}
