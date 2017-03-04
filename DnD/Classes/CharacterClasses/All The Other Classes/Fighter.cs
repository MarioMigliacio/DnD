using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Fighter Hero class.
    /// </summary>
    public class Fighter : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Fighter Constructor.
        /// </summary>
        public Fighter()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Fighter;
        }
    }
}
