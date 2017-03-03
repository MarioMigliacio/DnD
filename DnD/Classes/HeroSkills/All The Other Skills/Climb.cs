using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Climb Skill.
    /// </summary>
    public class Climb : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Climb.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Strength;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Climb.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Climb;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Climb;
    }
}
