using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The DiamondBody Special.
    /// </summary>
    public class DiamondBody : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire DiamondBody.
        /// </summary>
        public override int? MinimumLevelRequirement => 11;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.DiamondBody;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.DiamondBody;
    }
}
