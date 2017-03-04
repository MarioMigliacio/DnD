using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Bard Hero class.
    /// </summary>
    public class Bard : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Bard Constructor.
        /// </summary>
        public Bard()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Bard;
        }
    }
}
