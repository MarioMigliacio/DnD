using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The GatherInformation Skill.
    /// </summary>
    public class GatherInformation : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost GatherInformation.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for GatherInformation.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.GatherInformation;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.GatherInformation;
    }
}
