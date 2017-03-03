using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The StillMind Special.
    /// </summary>
    public class StillMind : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire StillMind.
        /// </summary>
        public override int? MinimumLevelRequirement => 3;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.StillMind;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.StillMind;
    }
}
