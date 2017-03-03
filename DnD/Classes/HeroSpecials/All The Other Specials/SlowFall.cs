using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SlowFall Special.
    /// </summary>
    public class SlowFall : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SlowFall.
        /// </summary>
        public override int? MinimumLevelRequirement => 4;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SlowFall;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SlowFall;
    }
}
