using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// The range of supported types of Armors.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ArmorType
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents the Armor type that is of type Belt.
        /// </summary>
        Belt,

        /// <summary>
        /// Represents the Armor type that is of type Boots.
        /// </summary>
        Boots,

        /// <summary>
        /// Represents the Armor type that is of type Bracers.
        /// </summary>
        Bracers,

        /// <summary>
        /// Represents the Armor type that is of type Chest.
        /// </summary>
        Chest,

        /// <summary>
        /// Represents the Armor type that is of type Gloves.
        /// </summary>
        Gloves,

        /// <summary>
        /// Represents the Armor type that is of type Helm.
        /// </summary>
        Helm,

        /// <summary>
        /// Represents the Armor type that is of type Pants.
        /// </summary>
        Pants,

        /// <summary>
        /// Represents the Armor type that is of type Shield.
        /// </summary>
        Shield,

        /// <summary>
        /// Represents the Armor type that is of type Shoulders.
        /// </summary>
        Shoulders
    }
}
