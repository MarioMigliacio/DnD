using DnD.Enums.ClassTypes;

namespace DnD.Classes.CharacterClasses
{
    /// <summary>
    /// The Caster Hero class.
    /// </summary>
    public class Caster : BaseCharacterClass
    {
        /// <summary>
        /// The defualt Caster Constructor.
        /// </summary>
        public Caster()
        {
            ClassLevel = 1;
            CharacterClassType = ClassType.Caster;
        }
    }
}
