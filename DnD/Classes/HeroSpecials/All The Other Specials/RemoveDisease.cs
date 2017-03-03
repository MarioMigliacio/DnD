using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The RemoveDisease Special.
    /// </summary>
    public class RemoveDisease : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire RemoveDisease.
        /// </summary>
        public override int? MinimumLevelRequirement => 6;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.RemoveDisease;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.RemoveDisease;
    }
}
