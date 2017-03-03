using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The Suggestion Special.
    /// </summary>
    public class Suggestion : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire Suggestion.
        /// </summary>
        public override int? MinimumLevelRequirement => 6;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.Suggestion;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.Suggestion;
    }
}
