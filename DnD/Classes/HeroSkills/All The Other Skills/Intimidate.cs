using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Intimidate Skill.
    /// </summary>
    public class Intimidate : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Intimidate.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Intimidate.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Intimidate;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Intimidate.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Intimidate is.
        /// </summary>
        public override Skills SkillType => Skills.Intimidate;
    }
}
