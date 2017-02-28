using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The UseMagicDevice Skill.
    /// </summary>
    public class UseMagicDevice : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost UseMagicDevice.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for UseMagicDevice.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.UseMagicDevice;

        /// <summary>
        /// Represents the number of ranks the player has alloted into UseMagicDevice.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> UseMagicDevice is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.UseMagicDevice;
    }
}
