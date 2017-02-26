using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Diplomacy Skill.
    /// </summary>
    public class Diplomacy : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Diplomacy.
        /// </summary>
        public override Stats BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Diplomacy.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Diplomacy;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Diplomacy.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Diplomacy is.
        /// </summary>
        public override Skills SkillType => Skills.Diplomacy;
    }
}
