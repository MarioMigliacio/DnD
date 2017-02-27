using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Tumble Skill.
    /// </summary>
    public class Tumble : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Tumble.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Tumble.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Tumble;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Tumble.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Tumble is.
        /// </summary>
        public override Skills SkillType => Skills.Tumble;
    }
}
