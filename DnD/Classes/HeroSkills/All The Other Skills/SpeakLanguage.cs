using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The SpeakLanguage Skill.
    /// </summary>
    public class SpeakLanguage : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost SpeakLanguage.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => null;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for SpeakLanguage.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.SpeakLanguage;

        /// <summary>
        /// Returns the SkillType Enumeration value that represents this Skill.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.SpeakLanguage;
    }
}
