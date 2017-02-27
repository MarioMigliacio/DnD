using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Forgery Skill.
    /// </summary>
    public class Forgery : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Forgery.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Forgery.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Forgery;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Forgery.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Forgery is.
        /// </summary>
        public override Skills SkillType => Skills.Forgery;
    }
}
