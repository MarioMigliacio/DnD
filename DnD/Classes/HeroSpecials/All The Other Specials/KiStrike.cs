using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The KiStrike Special.
    /// </summary>
    public class KiStrike : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire KiStrike.
        /// </summary>
        public override int? MinimumLevelRequirement => 4;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.KiStrike;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.KiStrike;
    }
}
