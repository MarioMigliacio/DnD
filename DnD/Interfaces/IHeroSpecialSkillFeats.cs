using DnD.Enums.ClassFeats;
using DnD.Enums.ClassSkills;
using DnD.Enums.ClassSpecials;

namespace DnD.Interfaces
{
    /// <summary>
    /// The IHeroComponent Interface is a layer which incorporates the similarities between Players Skills, Feats, and Special attributes.
    /// Also in common with all these components is a UserString Description tag which was put in place to give every component a nice description.
    /// </summary>
    public interface IHeroSpecialSkillFeats
    {
        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Nullable Skill type enumerator value. If the inheriting object is of type Skill, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        ClassSkills? SkillType { get; }

        /// <summary>
        /// Nullable FeatType enumerator value. If the inheriting object is of type FeatType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        ClassFeats? FeatType { get; }

        /// <summary>
        /// Nullable SpecialType enumerator value. If the inheriting object is of type SpecialType, which one it belongs to is acquired.
        /// Null if not compatable.
        /// </summary>
        ClassSpecial? SpecialType { get; }
    }
}
