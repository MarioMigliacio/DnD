using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Ranger Hero class.
    /// </summary>
    public class Ranger : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Ranger Constructor.
        /// </summary>
        public Ranger()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Ranger;
        }
    }
}
