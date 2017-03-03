using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The BardicKnowledge Special.
    /// </summary>
    public class BardicKnowledge : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire BardicKnowledge.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.BardicKnowledge;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.BardicKnowledge;
    }
}
