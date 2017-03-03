using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Caster Hero class.
    /// </summary>
    public class Caster : BaseCharacterClass
    {
        /// <summary>
        /// Represents which type of <see cref="ClassType"/> this class represents.
        /// </summary>
        public override ClassType CharacterClassType => ClassType.Caster;
    }
}
