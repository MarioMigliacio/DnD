using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The TurnUndead Special.
    /// </summary>
    public class TurnUndead : BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire TurnUndead.
        /// </summary>
        public override int? MinimumLevelRequirement => 4;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public override string Description => UserStrings.SpecialStrings.TurnUndead;

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public override ClassSpecial SpecialType => ClassSpecial.TurnUndead;
    }
}
