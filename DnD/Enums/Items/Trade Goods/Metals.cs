using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// Represents the Trade goods of type Metal.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Metal
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents an ore of type Copper.
        /// </summary>
        Copper,

        /// <summary>
        /// Represents an ore of type Coal.
        /// </summary>
        Coal,
        
        /// <summary>
        /// Represents an ore of type Tin.
        /// </summary>
        Tin,

        /// <summary>
        /// Represents an ore of type Bronze.
        /// </summary>
        Bronze,

        /// <summary>
        /// Represents an ore of type Iron.
        /// </summary>
        Iron,

        /// <summary>
        /// Represents an ore of type Silver.
        /// </summary>
        Silver,

        /// <summary>
        /// Represents an ore of type Gold.
        /// </summary>
        Gold,

        /// <summary>
        /// Represents an ore of type Mithril.
        /// </summary>
        Mithril,

        /// <summary>
        /// Represents an ore of type Diamondium.
        /// </summary>
        Diamondium
    }
}
