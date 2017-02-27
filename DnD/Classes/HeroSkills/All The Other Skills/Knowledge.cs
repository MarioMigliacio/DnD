using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Knowledge Skill.
    /// </summary>
    public class Knowledge : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Knowledge.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Knowledge.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Knowledge;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Knowledge.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Knowledge is.
        /// </summary>
        public override Skills SkillType => Skills.Knowledge;
    }
}
