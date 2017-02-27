using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The SleightOfHand Skill.
    /// </summary>
    public class SleightOfHand : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost SleightOfHand.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for SleightOfHand.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.SleightOfHand;

        /// <summary>
        /// Represents the number of ranks the player has alloted into SleightOfHand.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> SleightOfHand is.
        /// </summary>
        public override Skills SkillType => Skills.SleightOfHand;
    }
}
