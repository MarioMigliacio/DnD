using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The Base Specials class is an abstract entity which represents the generic type of special. 
    /// </summary>
    public abstract class BaseSpecial
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire this particular Special.
        /// </summary>
        public abstract int? MinimumLevelRequirement { get; }

        /// <summary>
        /// Exposes whether or not the Player has learned this particular Special.
        /// </summary>
        public bool IsAcquired { get; set; } = false;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Returns the ClassSpecial Enumeration type represented by this Special.
        /// </summary>
        public abstract ClassSpecial SpecialType { get; }
    }
}
