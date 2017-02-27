using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Hide Skill.
    /// </summary>
    public class Hide : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Hide.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Hide.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Hide;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Hide.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Hide is.
        /// </summary>
        public override Skills SkillType => Skills.Hide;
    }
}
