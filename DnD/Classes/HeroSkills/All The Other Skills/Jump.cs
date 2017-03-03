using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Jump Skill.
    /// </summary>
    public class Jump : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Jump.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Strength;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Jump.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Jump;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Jump;
    }
}
