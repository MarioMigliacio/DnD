using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Spot Skill.
    /// </summary>
    public class Spot : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Spot.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Wisdom;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Spot.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Spot;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Spot.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Spot is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Spot;
    }
}
