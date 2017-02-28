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
        /// Represents the number of ranks the player has alloted into Jump.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Jump is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Jump;
    }
}
