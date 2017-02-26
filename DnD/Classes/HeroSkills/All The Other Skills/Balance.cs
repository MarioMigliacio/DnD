using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Balance Skill.
    /// </summary>
    public class Balance : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Balance.
        /// </summary>
        public override Stats BenefitsFrom => Stats.Dexterity;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Balance.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Balance;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Balance.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Balance is.
        /// </summary>
        public override Skills SkillType => Skills.Balance;
    }
}
