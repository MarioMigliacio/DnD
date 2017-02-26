using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The Climb Skill.
    /// </summary>
    public class Climb : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Climb.
        /// </summary>
        public override Stats BenefitsFrom { get { return Stats.Strength; } }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Climb.
        /// </summary>  
        public override string Description { get { return UserStrings.SkillStrings.Climb; } }

        /// <summary>
        /// Represents the number of ranks the player has alloted into Climb.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Climb is.
        /// </summary>
        public override Skills SkillType { get { return Skills.Climb; } }
    }
}
