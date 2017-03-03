using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The InspireGreatness Special.
    /// </summary>
    public class InspireGreatness : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire InspireGreatness.
        /// </summary>
        public override int? MinimumLevelRequirement => 9;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.InspireGreatness;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.InspireGreatness;
    }
}
