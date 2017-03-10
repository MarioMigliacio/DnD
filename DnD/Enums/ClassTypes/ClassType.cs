using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.ClassTypes
{
    /// <summary>
    /// The various types of character Class Types available.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassType
    {
        /// <summary>
        /// Defaulting purposes.
        /// </summary>
        None,

        /// <summary>
        /// Represents the Barbarian Class Type.
        /// </summary>
        Barbarian,

        /// <summary>
        /// Represents the Bard Class Type.
        /// </summary>
        Bard,

        /// <summary>
        /// Represents the Cleric Class Type.
        /// </summary>
        Cleric,

        /// <summary>
        /// Represents the Druid Class Type.
        /// </summary>
        Druid,

        /// <summary>
        /// Represents the Fighter Class Type.
        /// </summary>
        Fighter,

        /// <summary>
        /// Represents the BarbarianMonk Class Type.
        /// </summary>
        Monk,

        /// <summary>
        /// Represents the Paladin Class Type.
        /// </summary>
        Paladin,

        /// <summary>
        /// Represents the Ranger Class Type.
        /// </summary>
        Ranger,

        /// <summary>
        /// Represents the Rogue Class Type.
        /// </summary>
        Rogue,

        /// <summary>
        /// Represents the Sorcerer Class Type.
        /// </summary>
        Sorcerer,

        /// <summary>
        /// Represents the Wizard Class Type.
        /// </summary>
        Wizard,

        /// <summary>
        /// Representative of all characters requiring a particular caster level.
        /// </summary>
        Caster
    }
}
