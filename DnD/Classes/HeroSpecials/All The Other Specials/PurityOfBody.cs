using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The PurityOfBody Special.
    /// </summary>
    public class PurityOfBody : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire PurityOfBody.
        /// </summary>
        public override int? MinimumLevelRequirement => 5;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.PurityOfBody;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.PurityOfBody;
    }
}
