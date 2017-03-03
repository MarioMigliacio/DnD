using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TurnOrRebukeUndead Special.
    /// </summary>
    public class TurnOrRebukeUndead : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TurnOrRebukeUndead.
        /// </summary>
        public override int? MinimumLevelRequirement => 1;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TurnOrRebukeUndead;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TurnOrRebukeUndead;
    }
}
