using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Swim Skill.
    /// </summary>
    public class Swim : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Swim.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Strength;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Swim.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Swim;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Swim.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Swim is.
        /// </summary>
        public override Skills SkillType => Skills.Swim;
    }
}
