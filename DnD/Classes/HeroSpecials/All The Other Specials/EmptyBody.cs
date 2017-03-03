using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The EmptyBody Special.
    /// </summary>
    public class EmptyBody : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire EmptyBody.
        /// </summary>
        public override int? MinimumLevelRequirement => 19;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.EmptyBody;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.EmptyBody;
    }
}
