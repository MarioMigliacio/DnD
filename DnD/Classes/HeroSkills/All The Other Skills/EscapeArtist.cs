using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The EscapeArtist Skill.
    /// </summary>
    public class EscapeArtist : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost EscapeArtist.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for EscapeArtist.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.EscapeArtist;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.EscapeArtist;
    }
}
