using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Stats
{
    /// <summary>
    /// Represents the enumerable types of character stats available.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Stats
    {
        /// <summary>
        /// Charisma measures a character’s force of personality, persuasiveness, personal magnetism, ability to lead, and physical attractiveness. 
        /// This ability represents actual strength of personality, not merely how one is perceived by others in a social setting. 
        /// </summary>
        Charisma,

        /// <summary>
        /// Constitution represents your character’s health and stamina. 
        /// A Constitution bonus increases a character’s hit points, so the ability is important for all classes.
        /// </summary>
        Constitution,

        /// <summary>
        /// Dexterity measures hand-eye coordination, agility, reflexes, and balance. 
        /// This ability is the most important one for rogues, but it’s also high on the list for characters 
        /// who typically wear light or medium armor (rangers and barbarians) or no armor at all (monks, wizards, and sorcerers), 
        /// and for anyone who wants to be a skilled archer.
        /// </summary>
        Dexterity,

        /// <summary>
        /// Intelligence determines how well your character learns and reasons. 
        /// This ability is important for wizards because it affects how many spells they can cast, how hard their spells are to resist, 
        /// and how powerful their spells can be. It’s also important for any character who wants to have a wide assortment of skills.
        /// </summary>
        Intellect,

        /// <summary>
        /// Strength measures your character’s muscle and physical power. 
        /// This ability is especially important for Fighters, barbarians, paladins, rangers, and monks because it helps them prevail in combat. 
        /// Strength also limits the amount of equipment your character can carry.
        /// </summary>
        Strength,

        /// <summary>
        /// Wisdom describes a character’s willpower, common sense, perception, and intuition. 
        /// While Intelligence represents one’s ability to analyze information, Wisdom represents being in tune with and aware of one’s surroundings. 
        /// Wisdom is the most important ability for clerics and druids, and it is also important for paladins and rangers. 
        /// If you want your character to have acute senses, put a high score in Wisdom. Every creature has a Wisdom score.
        /// </summary>
        Wisdom
    }
}
