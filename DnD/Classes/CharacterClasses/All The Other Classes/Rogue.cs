using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Rogue Hero class.
    /// </summary>
    public class Rogue : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Rogue Constructor.
        /// </summary>
        public Rogue()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Rogue;
        }
    }
}
