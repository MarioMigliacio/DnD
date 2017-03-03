using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The DiamondSoul Special.
    /// </summary>
    public class DiamondSoul : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire DiamondSoul.
        /// </summary>
        public override int? MinimumLevelRequirement => 13;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.DiamondSoul;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.DiamondSoul;
    }
}
