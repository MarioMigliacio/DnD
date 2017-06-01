using DnD.UserStrings;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// A static helper class used to gather the skill string description of a skill.
    /// </summary>
    public static class SkillInformation
    {
        /// <summary>
        /// A static method which looks at the input and returns the <see cref="SkillStrings"/> description associated with the key.
        /// </summary>
        /// <param name="input">The string with which to locate the description.</param>
        /// <returns>The <see cref="SkillStrings"/> matching the input.</returns>
        public static string GetDescription(string input)
        {
            string description = string.Empty;

            switch (input)
            {
                case "Appraise": description = SkillStrings.Appraise; break;
                case "Balance": description = SkillStrings.Balance; break;
                case "Bluff": description = SkillStrings.Bluff; break;
                case "Climb": description = SkillStrings.Climb; break;
                case "Concentration": description = SkillStrings.Concentration; break;
                case "Craft": description = SkillStrings.Craft; break;
                case "DecipherScript": description = SkillStrings.DecipherScript; break;
                case "Diplomacy": description = SkillStrings.Diplomacy; break;
                case "DisableDevice": description = SkillStrings.DisableDevice; break;
                case "Disguise": description = SkillStrings.Disguise; break;
                case "EscapeArtist": description = SkillStrings.EscapeArtist; break;
                case "Forgery": description = SkillStrings.Forgery; break;
                case "GatherInformation": description = SkillStrings.GatherInformation; break;
                case "HandleAnimal": description = SkillStrings.HandleAnimal; break;
                case "Heal": description = SkillStrings.Heal; break;
                case "Hide": description = SkillStrings.Hide; break;
                case "Intimidate": description = SkillStrings.Intimidate; break;
                case "Jump": description = SkillStrings.Jump; break;
                case "Knowledge": description = SkillStrings.Knowledge; break;
                case "Listen": description = SkillStrings.Listen; break;
                case "MoveSilently": description = SkillStrings.MoveSilently; break;
                case "OpenLock": description = SkillStrings.OpenLock; break;
                case "Perform": description = SkillStrings.Perform; break;
                case "Profession": description = SkillStrings.Profession; break;
                case "Ride": description = SkillStrings.Ride; break;
                case "Search": description = SkillStrings.Search; break;
                case "SenseMotive": description = SkillStrings.SenseMotive; break;
                case "SleightOfHand": description = SkillStrings.SleightOfHand; break;
                case "SpeakLanguage": description = SkillStrings.SpeakLanguage; break;
                case "Spellcraft": description = SkillStrings.Spellcraft; break;
                case "Spot": description = SkillStrings.Spot; break;
                case "Survival": description = SkillStrings.Survival; break;
                case "Swim": description = SkillStrings.Swim; break;
                case "Tumble": description = SkillStrings.Tumble; break;
                case "UseMagicDevice": description = SkillStrings.UseMagicDevice; break;
                case "UseRope": description = SkillStrings.UseRope; break;
                default: description = "That is not a valid skill."; break;
            }

            return description;
        }
    }
}
