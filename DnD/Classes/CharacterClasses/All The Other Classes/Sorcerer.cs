using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Sorcerer Hero class.
    /// </summary>
    public class Sorcerer : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Sorcerer Constructor.
        /// </summary>
        public Sorcerer()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Sorcerer;
        }
    }
}
