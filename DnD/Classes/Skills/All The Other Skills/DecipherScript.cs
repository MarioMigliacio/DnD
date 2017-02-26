using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The DecipherScript Skill.
    /// </summary>
    public class DecipherScript : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this DecipherScript.
        /// </summary>
        public override Stats BenefitsFrom { get { return Stats.Intellect; } }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for DecipherScript.
        /// </summary>  
        public override string Description { get { return UserStrings.SkillStrings.DecipherScript; } }

        /// <summary>
        /// Represents the number of ranks the player has alloted into DecipherScript.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> DecipherScript is.
        /// </summary>
        public override Skills SkillType { get { return Skills.DecipherScript; } }
    }
}
