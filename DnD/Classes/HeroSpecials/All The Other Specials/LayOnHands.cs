using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The LayOnHands Special.
    /// </summary>
    public class LayOnHands : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire LayOnHands.
        /// </summary>
        public override int? MinimumLevelRequirement => 2;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.LayOnHands;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.LayOnHands;
    }
}
