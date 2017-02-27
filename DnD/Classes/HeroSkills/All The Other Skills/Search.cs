using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Search Skill.
    /// </summary>
    public class Search : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Search.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Search.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Search;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Search.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Search is.
        /// </summary>
        public override Skills SkillType => Skills.Search;
    }
}
