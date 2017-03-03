using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The Track Special.
    /// </summary>
    public class Track : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire Track.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.Track;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.Track;
    }
}
