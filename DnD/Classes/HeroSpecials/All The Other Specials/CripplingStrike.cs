using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The CripplingStrike Special.
    /// </summary>
    public class CripplingStrike : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire CripplingStrike.
        /// </summary>
        public override int? MinimumLevelRequirement => 10;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.CripplingStrike;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.CripplingStrike;
    }
}
