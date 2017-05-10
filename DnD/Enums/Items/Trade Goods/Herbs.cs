using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// Represents the Trade goods of type Herb.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Herb
    {
        /// <summary>
        /// Represents an Herb of type ShimmerLeaf.
        /// </summary>
        ShimmerLeaf,

        /// <summary>
        /// Represents an Herb of type RainBud.
        /// </summary>
        RainBud,

        /// <summary>
        /// Represents an Herb of type FrostIvy.
        /// </summary>
        FrostIvy,

        /// <summary>
        /// Represents an Herb of type NightBloom.
        /// </summary>
        NightBloom,

        /// <summary>
        /// Represents an Herb of type RadiantTruffle.
        /// </summary>
        RadiantTruffle,

        /// <summary>
        /// Represents an Herb of type CrimsonBell.
        /// </summary>
        CrimsonBell
    }
}
