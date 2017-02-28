using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Survival Skill.
    /// </summary>
    public class Survival : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Survival.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Survival.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Survival;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Survival.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Survival is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Survival;
    }
}
