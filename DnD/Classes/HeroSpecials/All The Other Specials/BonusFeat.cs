using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The BonusFeat Special.
    /// </summary>
    public class BonusFeat : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire BonusFeat.
        /// </summary>
        public override int? MinimumLevelRequirement => null;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.BonusFeat;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.BonusFeat;
    }
}
