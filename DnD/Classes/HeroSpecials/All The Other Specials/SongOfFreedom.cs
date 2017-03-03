using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SongOfFreedom Special.
    /// </summary>
    public class SongOfFreedom : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SongOfFreedom.
        /// </summary>
        public override int? MinimumLevelRequirement => 12;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SongOfFreedom;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SongOfFreedom;
    }
}
