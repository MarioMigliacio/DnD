using System;
using System.Collections.Generic;
using DnD.Classes.HeroSkills;
using DnD.Enums.ClassSkills;

namespace HeroMaker
{
    /// <summary>
    /// The Skills Form is responsible for managing this static object during its Run process.
    /// When it is finished Running, the Forms call Dispose() so to free up memory, in which
    /// case any thing within the form is lost. Except for static objects which were altered during run time.
    /// </summary>
    public static class PlayerSkills
    {
        /// <summary>
        /// A static property which can be called to save player Skills.
        /// </summary>
        public static List<BaseSkill> SkillsContainer { get; set; } = new List<BaseSkill>();

        /// <summary>
        /// A helper method used to populate the SkillsContainer with default skills having 0 ranks in them.
        /// </summary>
        public static void PopulateContainer()
        {
            foreach (ClassSkills skill in Enum.GetValues(typeof(ClassSkills)))
            {
                if (SkillFactory.Create(skill) != null)
                {
                    SkillsContainer.Add(SkillFactory.Create(skill));
                }
            }
        }

        /// <summary>
        /// A helper method used to trim skills which have no ranks in them.
        /// </summary>
        public static void TrimContainer()
        {
            List<BaseSkill> toRemove = new List<BaseSkill>();

            foreach (BaseSkill skill in SkillsContainer)
            {
                if (skill.NumberOfRanks == 0)
                {
                    toRemove.Add(skill);
                }
            }

            foreach (BaseSkill skill in toRemove)
            {
                SkillsContainer.Remove(skill);
            }
        }
    }
}
