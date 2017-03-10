using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// Represents the Trade goods of type Cloth.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Cloth
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents a Cloth of type Linen.
        /// </summary>
        Linen,

        /// <summary>
        /// Represents a Cloth of type Wool.
        /// </summary>
        Wool,

        /// <summary>
        /// Represents a Cloth of type Silk.
        /// </summary>
        Silk,

        /// <summary>
        /// Represents a Cloth of type MageWeave.
        /// </summary>
        MageWeave,

        /// <summary>
        /// Represents a Cloth of type Runic.
        /// </summary>
        Runic,

        /// <summary>
        /// Represents a Cloth of type NetherWeave.
        /// </summary>
        NetherWeave,

        /// <summary>
        /// Represents a Cloth of type Fel.
        /// </summary>
        Fel
    }
}
