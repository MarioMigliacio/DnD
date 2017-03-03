using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The AbundantStep Special.
    /// </summary>
    public class AbundantStep : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire AbundantStep.
        /// </summary>
        public override int? MinimumLevelRequirement => 12;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.AbundantStep;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.AbundantStep;
    }
}
