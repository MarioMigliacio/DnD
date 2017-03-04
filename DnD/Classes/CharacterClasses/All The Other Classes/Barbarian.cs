using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Barbarian Hero class.
    /// </summary>
    public class Barbarian : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Barbarian Constructor.
        /// </summary>
        public Barbarian()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Barbarian;
        }
    }
}
