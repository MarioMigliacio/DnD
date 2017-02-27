using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Profession Skill.
    /// </summary>
    public class Profession : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Profession.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Profession.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Profession;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Profession.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Profession is.
        /// </summary>
        public override Skills SkillType => Skills.Profession;
    }
}
