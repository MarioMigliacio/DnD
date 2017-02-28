using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Diplomacy Skill.
    /// </summary>
    public class Diplomacy : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Diplomacy.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Diplomacy.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Diplomacy;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Diplomacy.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Diplomacy is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Diplomacy;
    }
}
