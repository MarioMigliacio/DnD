using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Balance Skill.
    /// </summary>
    public class Balance : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Balance.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Balance.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Balance;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Balance.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> Balance is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.Balance;
    }
}
