using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The VenomImmunity Special.
    /// </summary>
    public class VenomImmunity : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire VenomImmunity.
        /// </summary>
        public override int? MinimumLevelRequirement => 9;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.VenomImmunity;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.VenomImmunity;
    }
}
