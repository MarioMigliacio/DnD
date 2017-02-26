using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The Craft Skill.
    /// </summary>
    public class Craft : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Craft.
        /// </summary>
        public override Stats BenefitsFrom { get { return Stats.Intellect; } }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Craft.
        /// </summary>  
        public override string Description { get { return UserStrings.SkillStrings.Craft; } }

        /// <summary>
        /// Represents the number of ranks the player has alloted into Craft.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Craft is.
        /// </summary>
        public override Skills SkillType { get { return Skills.Craft; } }
    }
}
