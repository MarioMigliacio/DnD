using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Monk Hero class.
    /// </summary>
    public class Monk : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Monk Constructor.
        /// </summary>
        public Monk()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Monk;
        }
    }
}
