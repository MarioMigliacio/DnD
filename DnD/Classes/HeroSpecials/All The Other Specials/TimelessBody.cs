using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TimelessBody Special.
    /// </summary>
    public class TimelessBody : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TimelessBody.
        /// </summary>
        public override int? MinimumLevelRequirement => 15;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TimelessBody;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TimelessBody;
    }
}
