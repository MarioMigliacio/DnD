using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Bluff Skill.
    /// </summary>
    public class Bluff : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Bluff.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Bluff.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Bluff;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Bluff.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Bluff is.
        /// </summary>
        public override Skills SkillType => Skills.Bluff;
    }
}
