using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The SmiteEvil Special.
    /// </summary>
    public class SmiteEvil : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire SmiteEvil.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.SmiteEvil;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.SmiteEvil;
    }
}
