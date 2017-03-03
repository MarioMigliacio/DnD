using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The very essential Abstract base entity for what describes a Character class.
    /// For instance, a Barbarian, Bard, Druid, Sorcerer, etc.
    /// </summary>
    public abstract class BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public abstract ClassType CharacterClassType { get; }

        /// <summary>
        /// Represents the highest Level earned in the particular type of class.
        /// </summary>
        public int ClassLevel { get; set; }
    }
}
