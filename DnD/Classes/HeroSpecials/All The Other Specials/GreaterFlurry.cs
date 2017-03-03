using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The GreaterFlurry Special.
    /// </summary>
    public class GreaterFlurry : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire GreaterFlurry.
        /// </summary>
        public override int? MinimumLevelRequirement => 11;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.GreaterFlurry;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.GreaterFlurry;
    }
}
