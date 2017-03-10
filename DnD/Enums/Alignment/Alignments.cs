using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Alignment
{
    /// <summary>
    /// The various forms of character alignment in the standard v3.5 Dungeons and Dragons.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Alignment
    {
        /// <summary>
        /// Defaulting purposes.
        /// </summary>
        None,

        /// <summary>
        /// Represents the Alignment status Good.
        /// </summary>
        Good,

        /// <summary>
        /// Represents the Alignment status Neutral.
        /// </summary>
        Neutral,

        /// <summary>
        /// Represents the Alignment status Evil.
        /// </summary>
        Evil,

        /// <summary>
        /// Represents the Alignment status ChaoticGood.
        /// </summary>
        ChaoticGood,

        /// <summary>
        /// Represents the Alignment status ChaoticNeutral.
        /// </summary>
        ChaoticNeutral,

        /// <summary>
        /// Represents the Alignment status ChaoticEvil.
        /// </summary>
        ChaoticEvil,

        /// <summary>
        /// Represents the Alignment status LawfulGood.
        /// </summary>
        LawfulGood,

        /// <summary>
        /// Represents the Alignment status LawfulNeutral.
        /// </summary>
        LawfulNeutral,

        /// <summary>
        /// Represents the Alignment status LawfulEvil.
        /// </summary>
        LawfulEvil
    }
}
