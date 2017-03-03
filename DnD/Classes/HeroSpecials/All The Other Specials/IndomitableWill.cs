using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The IndomitableWill Special.
    /// </summary>
    public class IndomitableWill : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire IndomitableWill.
        /// </summary>
        public override int? MinimumLevelRequirement => 14;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.IndomitableWill;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.IndomitableWill;
    }
}
