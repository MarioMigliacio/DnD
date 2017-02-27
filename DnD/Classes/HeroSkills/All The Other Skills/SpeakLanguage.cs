using DnD.Enums.Skills;
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
        /// Represents the number of ranks the player has alloted into SpeakLanguage.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> SpeakLanguage is.
        /// </summary>
        public override Skills SkillType => Skills.SpeakLanguage;
    }
}
