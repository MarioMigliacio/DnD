using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The InspireHeroics Special.
    /// </summary>
    public class InspireHeroics : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire InspireHeroics.
        /// </summary>
        public override int? MinimumLevelRequirement => 12;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.InspireHeroics;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.InspireHeroics;
    }
}
