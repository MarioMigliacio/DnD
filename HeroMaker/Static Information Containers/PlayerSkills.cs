using System.Collections.Generic;
using DnD.Classes.HeroSkills;

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
        public static List<BaseSkill> SkillsContainter { get; set; } = new List<BaseSkill>();
    }
}
