using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Wizard Hero class.
    /// </summary>
    public class Wizard : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Wizard Constructor.
        /// </summary>
        public Wizard()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Wizard;
        }
    }
}
