using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The UnarmedStrike Special.
    /// </summary>
    public class UnarmedStrike : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire UnarmedStrike.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.UnarmedStrike;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.UnarmedStrike;
    }
}
