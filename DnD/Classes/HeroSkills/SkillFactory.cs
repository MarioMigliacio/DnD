using DnD.Enums.Skills;

namespace DnD.Classes.HeroSkills
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
                case Skills.EscapeArtist: return new EscapeArtist();
                case Skills.Forgery: return new Forgery();
                case Skills.GatherInformation: return new GatherInformation();
                case Skills.HandleAnimal: return new HandleAnimal();
                case Skills.Heal: return new Heal();
                case Skills.Hide: return new Hide();
                case Skills.Intimidate: return  new Intimidate();
                case Skills.Jump: return new Jump();
                case Skills.Knowledge: return new Knowledge();
                case Skills.Listen: return new Listen();
                case Skills.MoveSilently: return new MoveSilently();
                case Skills.OpenLock: return new OpenLock();
                case Skills.Perform: return new Perform();
                case Skills.Profession: return new Profession();
                case Skills.Ride: return new Ride();
                case Skills.Search: return new Search();
                case Skills.SenseMotive: return new SenseMotive();
                case Skills.SleightOfHand: return new SleightOfHand();
                case Skills.SpeakLanguage: return new SpeakLanguage();
                case Skills.Spellcraft: return new Spellcraft();
                case Skills.Spot: return new Spot();
                case Skills.Survival: return new Survival();
                case Skills.Swim: return new Swim();
                case Skills.Tumble: return new Tumble();
                case Skills.UseMagicDevice: return new UseMagicDevice();
                case Skills.UseRope: return  new UseRope();
                default: return null;
            }
        }
    }
}
