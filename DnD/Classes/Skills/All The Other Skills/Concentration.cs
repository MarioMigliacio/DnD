using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The Concentration Skill.
    /// </summary>
    public class Concentration : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Concentration.
        /// </summary>
        public override Stats BenefitsFrom { get { return Stats.Constitution; } }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Concentration.
        /// </summary>  
        public override string Description { get { return UserStrings.SkillStrings.Concentration; } }

        /// <summary>
        /// Represents the number of ranks the player has alloted into Concentration.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Concentration is.
        /// </summary>
        public override Skills SkillType { get { return Skills.Concentration; } }
    }
}
