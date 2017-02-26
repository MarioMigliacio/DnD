using DnD.Enums.Skills;
using DnD.Enums.Stats;

namespace DnD.Classes
{
    /// <summary>
    /// The Base Skills class is an abstract entity which represents the generic type of skill.    
    /// </summary>
    public abstract class BaseSkill
    {
        /// <summary>
        /// Returns the type of <see cref="Stats"/> that helps boost this particular type of skill.
        /// </summary>
        public abstract Stats BenefitsFrom { get; }

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

        /// <summary>
        /// Helper function which can quickly return to the caller the maximum allowed number of ranks that can be in this skill
        /// based on the Players level.
        /// </summary>
        /// <param name="characterLevel">Represents the <see cref="Player.Level"/>property.</param>
        /// <returns>The maximum number of allowed ranks that can be placed into this skill.</returns>
        public int MaxRanksPossible(int characterLevel)
        {
            return characterLevel + 3;
        }
    }
}
