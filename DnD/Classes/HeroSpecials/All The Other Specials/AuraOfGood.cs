using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The AuraOfGood Special.
    /// </summary>
    public class AuraOfGood : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire AuraOfGood.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.AuraOfGood;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.AuraOfGood;
    }
}
