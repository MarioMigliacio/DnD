using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The Endurance Special.
    /// </summary>
    public class Endurance : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire Endurance.
        /// </summary>
        public override int? MinimumLevelRequirement => 3;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.Endurance;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.Endurance;
    }
}
