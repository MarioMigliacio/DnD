using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Disguise Skill.
    /// </summary>
    public class Disguise : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this Disguise.
        /// </summary>
        public override Stats BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Disguise.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Disguise;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Disguise.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Disguise is.
        /// </summary>
        public override Skills SkillType => Skills.Disguise;
    }
}
