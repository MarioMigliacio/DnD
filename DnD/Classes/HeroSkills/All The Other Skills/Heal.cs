using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Heal Skill.
    /// </summary>
    public class Heal : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Heal.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Heal.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Heal;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Heal.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Heal is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Heal;
    }
}
