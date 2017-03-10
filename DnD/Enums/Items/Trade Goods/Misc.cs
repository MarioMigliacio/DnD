using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// Represents the Trade goods of type miscellaneous.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Misc
    {
        /// <summary>
        /// A default status.
        /// </summary>
        None,

        /// <summary>
        /// Represents a Misc item of type SpellBook.
        /// </summary>
        SpellBook,

        /// <summary>
        /// Represents a Misc item of type MiningPick.
        /// </summary>
        MiningPick,

        /// <summary>
        /// Represents a Misc item of type SkinningKnife.
        /// </summary>
        SkinningKnife,

        /// <summary>
        /// Represents a Misc item of type SewingNeedle.
        /// </summary>
        SewingNeedle,

        /// <summary>
        /// Represents a Misc item of type GardeningGloves.
        /// </summary>
        GardeningGloves,

        /// <summary>
        /// Represents a Misc item of type SteelTongs.
        /// </summary>
        SteelTongs,

        /// <summary>
        /// Represents a Misc item of type SmithingHammer.
        /// </summary>
        SmithingHammer,

        /// <summary>
        /// Represents a Misc item of type JewelersKit.
        /// </summary>
        JewelersKit,

        /// <summary>
        /// Represents a Misc item of type ChefsTools.
        /// </summary>
        ChefsTools,

        /// <summary>
        /// Represents a Misc item of type MagnifyingGlass.
        /// </summary>
        MagnifyingGlass,

        /// <summary>
        /// Represents a Misc item of type FlintAndTinder.
        /// </summary>
        FlintAndTinder,

        /// <summary>
        /// Represents a Misc item of type ClimbersKit.
        /// </summary>
        ClimbersKit,

        /// <summary>
        /// Represents a Misc item of type ArtisansTools.
        /// </summary>
        ArtisansTools,

        /// <summary>
        /// Represents a Misc item of type ThickRope.
        /// </summary>
        ThickRope,

        /// <summary>
        /// Represents a Misc item of type FrayedRope.
        /// </summary>
        FrayedRope,

        /// <summary>
        /// Represents a Misc item of type PaperScribblings.
        /// </summary>
        PaperScribblings,

        // MANY MANY MORE PROBABLY TODO!!
    }
}
