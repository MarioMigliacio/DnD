using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The InspireCompetence Special.
    /// </summary>
    public class InspireCompetence : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire InspireCompetence.
        /// </summary>
        public override int? MinimumLevelRequirement => 3;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.InspireCompetence;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.InspireCompetence;
    }
}
