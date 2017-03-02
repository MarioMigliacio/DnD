using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Bard Hero class.
    /// </summary>
    public class Bard : BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public override ClassType CharacterClassType => ClassType.Bard;
    }
}
