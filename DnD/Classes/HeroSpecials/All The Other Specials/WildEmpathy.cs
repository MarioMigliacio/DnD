using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The WildEmpathy Special.
    /// </summary>
    public class WildEmpathy : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire WildEmpathy.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.WildEmpathy;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.WildEmpathy;
    }
}
