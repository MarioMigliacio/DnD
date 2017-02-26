using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The Bluff Skill.
    /// </summary>
    public class Bluff : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Bluff.
        /// </summary>
        public override Stats BenefitsFrom { get { return Stats.Charisma; } }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Bluff.
        /// </summary>  
        public override string Description { get { return UserStrings.SkillStrings.Bluff; } }

        /// <summary>
        /// Represents the number of ranks the player has alloted into Bluff.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Bluff is.
        /// </summary>
        public override Skills SkillType { get { return Skills.Bluff; } }
    }
}
