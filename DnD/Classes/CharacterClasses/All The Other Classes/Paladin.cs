using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Paladin Hero class.
    /// </summary>
    public class Paladin : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Paladin Constructor.
        /// </summary>
        public Paladin()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Paladin;
        }
    }
}
