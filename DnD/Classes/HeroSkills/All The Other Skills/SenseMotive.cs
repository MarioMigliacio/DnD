using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The SenseMotive Skill.
    /// </summary>
    public class SenseMotive : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost SenseMotive.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for SenseMotive.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.SenseMotive;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.SenseMotive;
    }
}
