using DnD.Enums.Skills;
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
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for the particular feat in question.
        /// </summary>        
        public abstract string Description { get; }

        /// <summary>
        /// Represents the number of ranks the player has alloted into this particular skill.
        /// </summary>
        public abstract int NumberOfRanks { get; set; }

        /// <summary>
        /// Returns the associated <see cref="Skills"/> Enumeration type that this skill is.
        /// </summary>
        public abstract Skills SkillType { get; }
    }
}
