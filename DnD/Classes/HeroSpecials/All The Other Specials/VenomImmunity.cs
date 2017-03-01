using DnD.Enums.ClassFeats;
using DnD.Enums.ClassSkills;
using DnD.Enums.ClassSpecials;
using DnD.Interfaces;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// The VenomImmunity Special.
    /// </summary>
    public class VenomImmunity : BaseSpecial, IHeroSpecialSkillFeats
    {
        /// <summary>
        /// The minimum class level required for the ability to acquire VenomImmunity.
        /// </summary>
        public override int? MinimumLevelRequirement => 9;

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        public string Description => UserStrings.SpecialStrings.VenomImmunity;

        /// <summary>
        /// Nullable Skill type enumerator value. If the inheriting object is of type Skill, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassSkills? SkillType => null;

        /// <summary>
        /// Nullable FeatType enumerator value. If the inheriting object is of type FeatType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassFeats? FeatType => null;

        /// <summary>
        /// Nullable SpecialType enumerator value. If the inheriting object is of type SpecialType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        public ClassSpecial? SpecialType => ClassSpecial.VenomImmunity;
    }
}
