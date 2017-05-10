using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// Represents the Trade goods of type Leather
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Leather
    {
        /// <summary>
        /// Represents a leather of type LightLeather.
        /// </summary>
        LightLeather,

        /// <summary>
        /// Represents a leather of type LightHide.
        /// </summary>
        LightHide,

        /// <summary>
        /// Represents a leather of type MediumLeather.
        /// </summary>
        MediumLeather,

        /// <summary>
        /// Represents a leather of type MediumHide.
        /// </summary>
        MediumHide,

        /// <summary>
        /// Represents a leather of type Heavyleather.
        /// </summary>
        HeavyLeather,

        /// <summary>
        /// Represents a leather of type HeavyHide.
        /// </summary>
        HeavyHide,

        /// <summary>
        /// Represents a leather of type RuggedLeather.
        /// </summary>
        RuggedLeather,

        /// <summary>
        /// Represents a leather of type RuggedHide.
        /// </summary>
        RuggedHide
    }
}
