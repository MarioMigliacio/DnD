using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Spellcraft Skill.
    /// </summary>
    public class Spellcraft : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost Spellcraft.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Intellect;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for Spellcraft.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.Spellcraft;

        /// <summary>
        /// Represents the number of ranks the player has alloted into Spellcraft.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Spellcraft is.
        /// </summary>
        public override Skills SkillType => Skills.Spellcraft;
    }
}
