using DnD.Enums.Skills;
using DnD.Enums.Stats;
using System;

namespace DnD.Classes
{
    /// <summary>
    /// A useful factory tool which needs not be constructed. Simply pass in the Enum which corresponds to a skill, 
    /// and receive that skill as a new object.
    /// </summary>
    public static class SkillFactory
    {
        /// <summary>
        /// The interface usage of the Factory. Creates a new skill and returns it to the caller.
        /// </summary>
        /// <param name="which">Represents the <see cref="Skills"/>enum.</param>
        /// <returns>The particular Skill object which is represented by that enum.</returns>
        public static BaseSkill Create(Skills which)
        {
            switch (which)
            {
                case Skills.Appraise:
                    return new Appraise();
                default: return null;
            }
        }
    }
}
