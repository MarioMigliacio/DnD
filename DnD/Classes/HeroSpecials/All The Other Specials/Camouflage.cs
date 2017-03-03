using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The Camouflage Special.
    /// </summary>
    public class Camouflage : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire Camouflage.
        /// </summary>
        public override int? MinimumLevelRequirement => 13;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.Camouflage;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.Camouflage;
    }
}
