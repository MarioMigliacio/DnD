using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Perform Skill.
    /// </summary>
    public class Perform : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Perform.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Perform.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Perform;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Perform.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Perform is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Perform;
    }
}
