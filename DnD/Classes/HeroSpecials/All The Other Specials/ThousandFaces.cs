using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The ThousandFaces Special.
    /// </summary>
    public class ThousandFaces : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire ThousandFaces.
        /// </summary>
        public override int? MinimumLevelRequirement => 13;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.ThousandFaces;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.ThousandFaces;
    }
}
