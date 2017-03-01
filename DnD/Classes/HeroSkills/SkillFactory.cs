using DnD.Enums.ClassSkills;

namespace DnD.Classes.HeroSkills
{
    /// <summary>
    /// A useful factory tool which needs not be constructed. Simply pass in the Enum which corresponds to a skill, 
    /// and receive that skill as a new object.
    /// </summary>
    public static class SkillFactory
    {
        /// <summary>
        /// The design pattern of the Factory. Creates a new skill and returns it to the caller.
        /// </summary>
        /// <param name="which">Represents the <see cref="ClassSkills"/>enum.</param>
        /// <returns>The particular Skill object which is represented by that enum.</returns>
        public static BaseSkill Create(ClassSkills which)
        {
            switch (which)
            {
                case ClassSkills.Appraise: return new Appraise();
                case ClassSkills.Balance: return new Balance();
                case ClassSkills.Bluff: return new Bluff();
                case ClassSkills.Climb: return new Climb();
                case ClassSkills.Concentration: return new Concentration();
                case ClassSkills.Craft: return new Craft();
                case ClassSkills.DecipherScript: return new DecipherScript();
                case ClassSkills.Diplomacy: return new Diplomacy();
                case ClassSkills.DisableDevice: return new DisableDevice();
                case ClassSkills.Disguise: return new Disguise();
                case ClassSkills.EscapeArtist: return new EscapeArtist();
                case ClassSkills.Forgery: return new Forgery();
                case ClassSkills.GatherInformation: return new GatherInformation();
                case ClassSkills.HandleAnimal: return new HandleAnimal();
                case ClassSkills.Heal: return new Heal();
                case ClassSkills.Hide: return new Hide();
                case ClassSkills.Intimidate: return  new Intimidate();
                case ClassSkills.Jump: return new Jump();
                case ClassSkills.Knowledge: return new Knowledge();
                case ClassSkills.Listen: return new Listen();
                case ClassSkills.MoveSilently: return new MoveSilently();
                case ClassSkills.OpenLock: return new OpenLock();
                case ClassSkills.Perform: return new Perform();
                case ClassSkills.Profession: return new Profession();
                case ClassSkills.Ride: return new Ride();
                case ClassSkills.Search: return new Search();
                case ClassSkills.SenseMotive: return new SenseMotive();
                case ClassSkills.SleightOfHand: return new SleightOfHand();
                case ClassSkills.SpeakLanguage: return new SpeakLanguage();
                case ClassSkills.Spellcraft: return new Spellcraft();
                case ClassSkills.Spot: return new Spot();
                case ClassSkills.Survival: return new Survival();
                case ClassSkills.Swim: return new Swim();
                case ClassSkills.Tumble: return new Tumble();
                case ClassSkills.UseMagicDevice: return new UseMagicDevice();
                case ClassSkills.UseRope: return  new UseRope();
                default: return null;
            }
        }
    }
}
