using DnD.Enums.Skills;

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
                case Skills.Appraise: return new Appraise();
                case Skills.Balance: return new Balance();
                case Skills.Bluff: return new Bluff();
                case Skills.Climb: return new Climb();
                case Skills.Concentration: return new Concentration();
                case Skills.Craft: return new Craft();
                case Skills.DecipherScript: return new DecipherScript();
                case Skills.Diplomacy: return new Diplomacy();
                case Skills.DisableDevice: return new DisableDevice();
                case Skills.Disguise: return new Disguise();
                default: return null;
            }
        }
    }
}
