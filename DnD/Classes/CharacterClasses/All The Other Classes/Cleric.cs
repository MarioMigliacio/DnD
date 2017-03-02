using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Cleric Hero class.
    /// </summary>
    public class Cleric : BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public override ClassType CharacterClassType => ClassType.Cleric;
    }
}
