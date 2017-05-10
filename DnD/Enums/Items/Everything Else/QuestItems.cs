using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// The range of supported types of Quest items.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuestItem
    {
        /// <summary>
        /// Represents the Quest item that is of type Cursed Necklace.
        /// </summary>
        CursedNecklace,

        /// <summary>
        /// Represents the Quest item that is of type Abrasive Arm Band.
        /// </summary>
        AbrasiveArmBand
    }
}
