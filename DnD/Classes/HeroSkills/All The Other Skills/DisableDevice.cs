using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The DisableDevice Skill.
    /// </summary>
    public class DisableDevice : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this DisableDevice.
        /// </summary>
        public override Stats BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for DisableDevice.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.DisableDevice;

        /// <summary>
        /// Represents the number of ranks the player has alloted into DisableDevice.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> DisableDevice is.
        /// </summary>
        public override Skills SkillType => Skills.DisableDevice;
    }
}
