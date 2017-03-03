using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SwiftTracker Special.
    /// </summary>
    public class SwiftTracker : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SwiftTracker.
        /// </summary>
        public override int? MinimumLevelRequirement => 8;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SwiftTracker;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SwiftTracker;
    }
}
