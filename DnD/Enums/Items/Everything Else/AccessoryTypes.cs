using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// The range of supported types of Accessoriess.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessoryType
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents an Amulet type accessory.
        /// </summary>
        Amulet,

        /// <summary>
        /// Represents a Bracelet type accessory.
        /// </summary>
        Bracelet,

        /// <summary>
        /// Represents a Charm type accessory.
        /// </summary>
        Charm,

        /// <summary>
        /// Represents a Ring type accessory.
        /// </summary>
        Ring, 

        /// <summary>
        /// Represents a Voodoo type accessory.
        /// </summary>
        Voodoo,

        /// <summary>
        /// Represents a Circlet type accessory.
        /// </summary>
        Circlet,
    }
}
