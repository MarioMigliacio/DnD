using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Druid Hero class.
    /// </summary>
    public class Druid : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Druid Constructor.
        /// </summary>
        public Druid()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Druid;
        }
    }
}
