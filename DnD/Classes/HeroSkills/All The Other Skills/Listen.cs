using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Listen Skill.
    /// </summary>
    public class Listen : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Listen.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Listen.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Listen;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Listen.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Listen is.
        /// </summary>
        public override Skills SkillType => Skills.Listen;
    }
}
