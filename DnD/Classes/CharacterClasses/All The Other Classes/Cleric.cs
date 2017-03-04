using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Cleric Hero class.
    /// </summary>
    public class Cleric : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Cleric Constructor.
        /// </summary>
        public Cleric()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Cleric;
        }
    }
}
