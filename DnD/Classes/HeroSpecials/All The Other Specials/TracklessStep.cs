using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TracklessStep Special.
    /// </summary>
    public class TracklessStep : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TracklessStep.
        /// </summary>
        public override int? MinimumLevelRequirement => 3;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TracklessStep;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TracklessStep;
    }
}
