using DnD.Enums.ClassSkills;
using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The HandleAnimal Skill.
    /// </summary>
    public class HandleAnimal : BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost HandleAnimal.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public override Stats? BenefitsFrom => Stats.Charisma;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for HandleAnimal.
        /// </summary>  
        public override string Description => UserStrings.SkillStrings.HandleAnimal;

        /// <summary>
        /// Represents the number of ranks the player has alloted into HandleAnimal.
        /// </summary>
        public override int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="ClassSkills"/> HandleAnimal is.
        /// </summary>
        public override ClassSkills SkillType => ClassSkills.HandleAnimal;
    }
}
