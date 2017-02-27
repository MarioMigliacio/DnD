using DnD.Enums.Skills;
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
        /// Represents the number of ranks the player has alloted into SenseMotive.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> SenseMotive is.
        /// </summary>
        public override Skills SkillType => Skills.SenseMotive;
    }
}
