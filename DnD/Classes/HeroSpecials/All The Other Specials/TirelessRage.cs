using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TirelessRage Special.
    /// </summary>
    public class TirelessRage : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TirelessRage.
        /// </summary>
        public override int? MinimumLevelRequirement => 17;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TirelessRage;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TirelessRage;
    }
}
