using DnD.Enums.SavingThrows;

namespace DnD.Enums.Pets
{
    /// <summary>
    /// The various types of Wizard or Sorcerer Familiars available.
    /// </summary>
    public enum FamiliarType
    {
        /// <summary>
        /// A Bat companion. Provides +3 bonus on <see cref="Skills.Listen"/> for the master.
        /// </summary>
        Bat,

        /// <summary>
        /// A Cat companion. Provides +3 bonus on <see cref="Skills.MoveSilently"/> for the master.
        /// </summary>
        Cat,

        /// <summary>
        /// A Hawk companion. Provides +3 bonus on <see cref="Skills.Spot"/> in bright light for the master.
        /// </summary>
        Hawk,

        /// <summary>
        /// A Lizard companion. Provides +3 bonus on <see cref="Skills.Climb"/> for the master.
        /// </summary>
        Lizard,

        /// <summary>
        /// An Owl companion. Provides +3 bonus on <see cref="Skills.Spot"/> in darkness for the master.
        /// </summary>
        Owl,

        /// <summary>
        /// A Rat companion. Provides +2 bonus on <see cref="SavingThrowType.Fortitude"/> for the master.
        /// </summary>
        Rat,

        /// <summary>
        /// A Raven companion. Provides +3 bonus on <see cref="Skills.Appraise"/> for the master.
        /// </summary>
        Raven,

        /// <summary>
        /// A Snake companion. Provides +3 bonus on <see cref="Skills.Bluff"/> for the master.
        /// </summary>
        Snake,

        /// <summary>
        /// A Toad companion. Provides +3 bonus to hit points for the master.
        /// </summary>
        Toad,

        /// <summary>
        /// A Rat companion. Provides +2 bonus on <see cref="SavingThrowType.Reflex"/> for the master.
        /// </summary>
        Weasel
    }
}
