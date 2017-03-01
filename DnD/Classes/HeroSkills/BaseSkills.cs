using DnD.Enums.Stats;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// The Base Skills class is an abstract entity which represents the generic type of skill.    
    /// </summary>
    public abstract class BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this particular type of skill.
        /// Null, if no actual stat benefits the skill.
        /// </summary>
        public abstract Stats? BenefitsFrom { get; }

        /// <summary>
        /// Exposes the number of ranks the player has alloted into this particular skill.
        /// </summary>
        public int NumberOfRanks { get; set; } = 0;
    }
}
