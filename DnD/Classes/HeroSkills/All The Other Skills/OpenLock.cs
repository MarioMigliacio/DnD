using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The OpenLock Skill.
    /// </summary>
    public class OpenLock : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost OpenLock.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for OpenLock.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.OpenLock;

        /// <summary>
        /// Represents the number of ranks the player has alloted into OpenLock.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> OpenLock is.
        /// </summary>
        public override Skills SkillType => Skills.OpenLock;
    }
}
