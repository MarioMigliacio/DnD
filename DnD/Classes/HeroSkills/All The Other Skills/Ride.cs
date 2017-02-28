using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Ride Skill.
    /// </summary>
    public class Ride : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Ride.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Ride.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Ride;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Ride.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Ride is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Ride;
    }
}
