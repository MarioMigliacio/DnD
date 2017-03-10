using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.SavingThrows
{
    /// <summary>
    /// There are times when additional checks need to be made against particular actions.
    /// Saving Throws in dungeons and dragons adds complexity to actions in many ways.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SavingThrowType
    {
        /// <summary>
        /// Represents the Fortitude save.
        /// Applies <see cref="Stats.Constitution"/> bonus towards fotitude saves.
        /// </summary>
        Fortitude,

        /// <summary>
        /// Represents the Reflex save.
        /// Applies <see cref="Stats.Dexterity"/> bonus towards reflex saves.
        /// </summary>
        Reflex,

        /// <summary>
        /// Represents the Will save.
        /// Applies the <see cref="Stats.Wisdom"/> bonus towards will saves.
        /// </summary>
        Will
    }
}
