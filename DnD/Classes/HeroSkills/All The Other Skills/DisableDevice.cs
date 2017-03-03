using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The DisableDevice Skill.
    /// </summary>
    public class DisableDevice : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost DisableDevice.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for DisableDevice.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.DisableDevice;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.DisableDevice;
    }
}
