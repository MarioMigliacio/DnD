using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The FlurryOfBlows Special.
    /// </summary>
    public class FlurryOfBlows : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire FlurryOfBlows.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.FlurryOfBlows;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.FlurryOfBlows;
    }
}
