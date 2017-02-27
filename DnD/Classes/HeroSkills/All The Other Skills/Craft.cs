using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Craft Skill.
    /// </summary>
    public class Craft : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Craft.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Craft.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Craft;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Craft.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Craft is.
        /// </summary>
        public override Skills SkillType => Skills.Craft;
    }
}
