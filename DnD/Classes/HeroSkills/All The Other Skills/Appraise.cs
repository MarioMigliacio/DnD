using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Appraise Skill.
    /// </summary>
    public class Appraise : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Appraise.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Appraise.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Appraise;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Appraise.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Appriase is.
        /// </summary>
        public override Skills SkillType => Skills.Appraise;
    }
}
