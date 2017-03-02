using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Druid Hero class.
    /// </summary>
    public class Druid : BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public override ClassType CharacterClassType => ClassType.Druid;
    }
}
