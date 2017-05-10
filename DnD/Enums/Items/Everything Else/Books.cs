using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.Items
{
    /// <summary>
    /// The range of supported types of Books.
    /// Relevant to Clerics/Sorcerors/Wizards/Druids
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Book
    {
        /// <summary>
        /// Represents a Book which teaches the FireBolt spell.
        /// </summary>
        BookOfFireBolt,

        /// <summary>
        /// Represents a Book which teaches the FireBall spell.
        /// </summary>
        BookOfFireBall,

        /// <summary>
        /// Represents a Book which teaches the Meteor spell.
        /// </summary>
        BookOfMeteor,

        /// <summary>
        /// Represents a Book which teaches the FireWall spell.
        /// </summary>
        BookOfFireWall,

        /// <summary>
        /// Represents a Book which teaches the Hydra spell.
        /// </summary>
        BookOfHydra,

        /// <summary>
        /// Represents a Book which teaches the ChargedBolt spell.
        /// </summary>
        BookOfChargedBolt,

        /// <summary>
        /// Represents a Book which teaches the Lightning spell.
        /// </summary>
        BookOfLightning,

        /// <summary>
        /// Represents a Book which teaches the ChainLightning spell.
        /// </summary>
        BookOfChainLightning,

        /// <summary>
        /// Represents a Book which teaches the Nova spell.
        /// </summary>
        BookOfNova,

        /// <summary>
        /// Represents a Book which teaches the ThunderStorm spell.
        /// </summary>
        BookOfThunderStorm,

        /// <summary>
        /// Represents a Book which teaches the FrostBolt spell.
        /// </summary>
        BookOfFrostBolt,

        /// <summary>
        /// Represents a Book which teaches the ConeOfCold spell.
        /// </summary>
        BookOfConeOfCold,

        /// <summary>
        /// Represents a Book which teaches the FrostNova spell.
        /// </summary>
        BookOfFrostNova,

        /// <summary>
        /// Represents a Book which teaches the Blizzard spell.
        /// </summary>
        BookOfBlizzard,

        /// <summary>
        /// Represents a Book which teaches the FrozenOrb spell.
        /// </summary>
        BookOfFrozenOrb,

        /// <summary>
        /// Represents a Book which teaches the SummonRaven spell.
        /// </summary>
        BookOfSummonRaven,

        /// <summary>
        /// Represents a Book which teaches the SummonDireWolf spell.
        /// </summary>
        BookOfSummonDireWolf,

        /// <summary>
        /// Represents a Book which teaches the SummonOakSage spell.
        /// </summary>
        BookOfSummonOakSage,

        /// <summary>
        /// Represents a Book which teaches the SummonGrizzlyBear spell.
        /// </summary>
        BookOfSummonGrizzlyBear,

        /// <summary>
        /// Represents a Book which teaches the SummonPanther spell.
        /// </summary>
        BookOfSummonPanther,

        /// <summary>
        /// Represents a Book which teaches the FireStorm spell.
        /// </summary>
        BookOfFireStorm,

        /// <summary>
        /// Represents a Book which teaches the ArcticBlast spell.
        /// </summary>
        BookOfArcticBlast,

        /// <summary>
        /// Represents a Book which teaches the MoltenBoulder spell.
        /// </summary>
        BookOfMoltenBoulder,

        /// <summary>
        /// Represents a Book which teaches the Hurricane spell.
        /// </summary>
        BookOfHurricane,

        /// <summary>
        /// Represents a Book which teaches the Armageddon spell.
        /// </summary>
        BookOfArmageddon,

        /// <summary>
        /// Represents a Book which teaches the CycloneArmor spell.
        /// </summary>
        BookOfCycloneArmor,

        /// <summary>
        /// Represents a Book which teaches the BoneSpear spell.
        /// </summary>
        BookOfBoneSpear,

        /// <summary>
        /// Represents a Book which teaches the BoneSpirit spell.
        /// </summary>
        BookOfBoneSpirit,

        /// <summary>
        /// Represents a Book which teaches the PoisonNova spell.
        /// </summary>
        BookOfPoisonNova,

        /// <summary>
        /// Represents a Book which teaches the AcidCloud spell.
        /// </summary>
        BookOfAcidCloud,

        /// <summary>
        /// Represents a Book which teaches the Teeth spell.
        /// </summary>
        BookOfTeeth,

        /// <summary>
        /// Represents a Book which teaches the SummonSkeletonWarrior spell.
        /// </summary>
        BookOfSummonSkeletonWarrior,

        /// <summary>
        /// Represents a Book which teaches the SummonClayGolem spell.
        /// </summary>
        BookOfSummonClayGolem,

        /// <summary>
        /// Represents a Book which teaches the SummonSkeletonMage spell.
        /// </summary>
        BookOfSummonSkeletonMage,

        /// <summary>
        /// Represents a Book which teaches the SummonIronGolem spell.
        /// </summary>
        BookOfSummonIronGolem,

        /// <summary>
        /// Represents a Book which teaches the SummonZombieDog spell.
        /// </summary>
        BookOfSummonZombieDog,

        /// <summary>
        /// Represents a Book which teaches the HolyFire spell.
        /// </summary>
        BookOfHolyFire,

        /// <summary>
        /// Represents a Book which teaches the Prayer spell.
        /// </summary>
        BookOfPrayer,

        /// <summary>
        /// Represents a Book which teaches the Pennance spell.
        /// </summary>
        BookOfPennance,

        /// <summary>
        /// Represents a Book which teaches the HolyNova spell.
        /// </summary>
        BookOfHolyNova,

        /// <summary>
        /// Represents a Book which teaches the Consecration spell.
        /// </summary>
        BookOfConsecration,

        /// <summary>
        /// Represents a Book which teaches the TurnEvil spell.
        /// </summary>
        BookOfTurnEvil,

        /// <summary>
        /// Represents a Book which teaches the HolyLight spell.
        /// </summary>
        BookOfHolyLight,

        /// <summary>
        /// Represents a Book which teaches the ConjureWater spell.
        /// </summary>
        BookOfConjureWater,

        /// <summary>
        /// Represents a Book which teaches the ConjureFood spell.
        /// </summary>
        BookOfConjureFood,

        /// <summary>
        /// Represents a Book which teaches the PolyMorph spell.
        /// </summary>
        BookOfPolyMorph
    }
}
