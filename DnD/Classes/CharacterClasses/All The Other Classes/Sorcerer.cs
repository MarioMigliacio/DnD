using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Sorcerer Hero class.
    /// </summary>
    public class Sorcerer : BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public override ClassType CharacterClassType => ClassType.Sorcerer;
    }
}
