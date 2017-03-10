using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// The range of supported types of Potions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Potion
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents the Potion of type Health.
        /// </summary>
        Health,

        /// <summary>
        /// Represents the Potion of type Mana.
        /// </summary>
        Mana,

        /// <summary>
        /// Represents the Potion of type Constitution.
        /// </summary>
        Constitution,

        /// <summary>
        /// Represents the Potion of type Dexterity.
        /// </summary>
        Dexterity,

        /// <summary>
        /// Represents the Potion of type Spirit.
        /// </summary>
        Spirit,

        /// <summary>
        /// Represents the Potion of type Strength.
        /// </summary>
        Strength,        
    }
}
