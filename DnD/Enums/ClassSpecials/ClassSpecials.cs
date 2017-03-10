using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.ClassSpecials
{
    /// <summary>
    /// Class Specials are unique to each Character class. Many classes have special fighting styles,
    /// favored enemies, or various enhancements that are similar to feats - but vary slightly enough to need 
    /// a new classification altogether.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassSpecial
    {
        // The Barbarian's specials:

        /// <summary>
        /// Represents the Fast Movement Special.
        /// </summary>
        FastMovement,

        /// <summary>
        /// Represents the Illiteracy Special.
        /// </summary>
        Illiteracy,

        /// <summary>
        /// Represents the Rage Special.
        /// Ranges from 1-6.
        /// </summary>
        Rage,

        /// <summary>
        /// Represents the Uncanny Dodge Special.
        /// </summary>
        UncannyDodge,

        /// <summary>
        /// Represents the Trap Sense Special.
        /// Ranges from 1-6.
        /// </summary>
        TrapSense,

        /// <summary>
        /// Represents the Improved Uncanny Dodge Special.
        /// </summary>
        ImprovedUncannyDodge,

        /// <summary>
        /// Represents the Damage Reduction Special.
        /// Ranges from 1-5.
        /// </summary>
        DamageReduction,

        /// <summary>
        /// Represents the Greater Rage Special.
        /// </summary>
        GreaterRage,

        /// <summary>
        /// Represents the Indomitable Will Special.
        /// </summary>
        IndomitableWill,

        /// <summary>
        /// Represents the Tireless Rage Special.
        /// </summary>
        TirelessRage,

        /// <summary>
        /// Represents the Mighty Rage Special.
        /// </summary>
        MightyRage,

        // The Bard's specials:

        /// <summary>
        /// Represents the Bardic Music Special.
        /// </summary>
        BardicMusic,

        /// <summary>
        /// Represents the Bardic Knowledge Special.
        /// </summary>
        BardicKnowledge,

        /// <summary>
        /// Represents the Counter Song Special.
        /// </summary>
        CounterSong,

        /// <summary>
        /// Represents the Fascinate Special.
        /// </summary>
        Fascinate,

        /// <summary>
        /// Represents the Inspire Courage Special.
        /// Ranges from 1-4.
        /// </summary>
        InspireCourage,

        /// <summary>
        /// Represents the Inspire Competence Special.
        /// </summary>
        InspireCompetence,

        /// <summary>
        /// Represents the Suggestion Special.
        /// </summary>
        Suggestion,

        /// <summary>
        /// Represents the Inspire Greatness Special.
        /// </summary>
        InspireGreatness,

        /// <summary>
        /// Represents the Song of Freedom Special.
        /// </summary>
        SongOfFreedom,

        /// <summary>
        /// Represents the Inspire Heroics Special.
        /// </summary>
        InspireHeroics,

        /// <summary>
        /// Represents the Mass Suggestion Special.
        /// </summary>
        MassSuggestion,

        /// <summary>
        /// Represents the Bonus Feat Special
        /// </summary>
        BonusFeat,

        // The Cleric's specials:

        /// <summary>
        /// Represents the Turn or Rebuke Undead Special.
        /// </summary>
        TurnOrRebukeUndead,

        // The Druid's specials:
        
        /// <summary>
        /// Represents the Animal Companion Special.
        /// </summary>
        AnimalCompanion,

        /// <summary>
        /// Represents the Nature Sense Special.
        /// </summary>
        NatureSense,

        /// <summary>
        /// Represents the Wild Empathy Special.
        /// </summary>
        WildEmpathy,

        /// <summary>
        /// Represents the Woodland Stride Special.
        /// </summary>
        WoodlandStride,

        /// <summary>
        /// Represents the Trackless Step Special.
        /// </summary>
        TracklessStep,

        /// <summary>
        /// Represents the Resist Natures Lure Special.
        /// </summary>
        ResistNaturesLure,

        /// <summary>
        /// Represents the Wild Shape Special.
        /// Ranges with shapes and 1-3 uses/day.
        /// </summary>
        WildShape,

        /// <summary>
        /// Represents the Venom Immunity Special.
        /// </summary>
        VenomImmunity,

        /// <summary>
        /// Represents the Thousand Faces Special.
        /// </summary>
        ThousandFaces,

        /// <summary>
        /// Represents the Timeless Body Special.
        /// </summary>
        TimelessBody,

        // The Monk's specials:

        /// <summary>
        /// Represents the Flurry of Blows Special.
        /// </summary>
        FlurryOfBlows,

        /// <summary>
        /// Represents the Unarmed Strike Special.
        /// </summary>
        UnarmedStrike,

        /// <summary>
        /// Represents the Evasion Special.
        /// </summary>
        Evasion,

        /// <summary>
        /// Represents the Still Mind Special.
        /// </summary>
        StillMind,

        /// <summary>
        /// Represents the Ki Strike Special.
        /// </summary>
        KiStrike,

        /// <summary>
        /// Represents the Slow Fall Special.
        /// Ranges from 20-90+ feet. (Any height at max)
        /// </summary>
        SlowFall,

        /// <summary>
        /// Represents the Purity of Body Special.
        /// </summary>
        PurityOfBody,

        /// <summary>
        /// Represents the Wholeness of Body Special.
        /// </summary>
        WholenessOfBody,

        /// <summary>
        /// Represents the Improved Evasion Special.
        /// </summary>
        ImprovedEvasion,

        /// <summary>
        /// Represents the Diamond Body Special.
        /// </summary>
        DiamondBody,

        /// <summary>
        /// Represents the Greater Flurry Special.
        /// </summary>
        GreaterFlurry,

        /// <summary>
        /// Represents the Abundant Step Special.
        /// </summary>
        AbundantStep,

        /// <summary>
        /// Represents the Diamond Soul Special.
        /// </summary>
        DiamondSoul,

        /// <summary>
        /// Represents the Quivering Palm Special.
        /// </summary>
        QuiveringPalm,
        
        /// <summary>
        /// Represents the Tongue of the Sun and Moon Special.
        /// </summary>
        TongueOfTheSunAndMoon,

        /// <summary>
        /// Represents the Empty Body Special.
        /// </summary>
        EmptyBody,

        /// <summary>
        /// Represents the Perfect Self Special.
        /// </summary>
        PerfectSelf,

        // The Paladin's specials:
        
        /// <summary>
        /// Represents the Aura of Good Special.
        /// </summary>
        AuraOfGood,

        /// <summary>
        /// Represents the Detect Evil Special.
        /// </summary>
        DetectEvil,

        /// <summary>
        /// Represents the Smite Evil Special.
        /// Ranges from 1-5 uses/day.
        /// </summary>
        SmiteEvil,

        /// <summary>
        /// Represents the Divine Grace Special.
        /// </summary>
        DivineGrace,

        /// <summary>
        /// Represents the Lay on Hands Special.
        /// </summary>
        LayOnHands,

        /// <summary>
        /// Represents the Aura of Courage Special.
        /// </summary>
        AuraOfCourage,

        /// <summary>
        /// Represents the Divine Health Special.
        /// </summary>
        DivineHealth,

        /// <summary>
        /// Represents the Turn Undead Special.
        /// Slight variation to the Cleric version.
        /// </summary>
        TurnUndead,

        /// <summary>
        /// Represents the Special Mount Special.
        /// </summary>
        SpecialMount,

        /// <summary>
        /// Represents the Remove Disease Special.
        /// Ranges from 1-5 uses/week.
        /// </summary>
        RemoveDisease,

        // The Ranger's specials:

        /// <summary>
        /// Represents the Favored Enemy Special.
        /// Ranges from 1-5 different enemy types.
        /// </summary>
        FavoredEnemy,

        /// <summary>
        /// Represents the Track Special.
        /// </summary>
        Tracking,

        /// <summary>
        /// Represents the Combat Style Special.
        /// </summary>
        CombatStyle,

        /// <summary>
        /// Represents the Endurance Special.
        /// </summary>
        Endurance,

        /// <summary>
        /// Represents the Improved Combat Style Special.
        /// </summary>
        ImprovedCombatStyle,

        /// <summary>
        /// Represents the Swift Tracker Special.
        /// </summary>
        SwiftTracker,

        /// <summary>
        /// Represents the Combat Style Mastery Special.
        /// </summary>
        CombatStyleMastery,

        /// <summary>
        /// Represents the Camouflage Special.
        /// </summary>
        Camouflage,

        /// <summary>
        /// Represents the Hide in Plain Sight Special.
        /// </summary>
        HideInPlainSight,

        // The Rogue's specials:

        /// <summary>
        /// Represents the Sneak Attack Special.
        /// Ranges in D6 Dice rolls, up to 10.
        /// </summary>
        SneakAttack,

        /// <summary>
        /// Represents the Trap Finding Special.
        /// </summary>
        TrapFinding,
        
        /// <summary>
        /// Represents the Crippling Strike Special.
        /// Can be selected as one of Rogues extra special abilities
        /// at level 10, 13, 16, 19. Or a bonus feat may be chosen.
        /// </summary>
        CripplingStrike,

        /// <summary>
        /// Represents the Defensive Roll Special.
        /// Can be selected as one of Rogues extra special abilities
        /// at level 10, 13, 16, 19. Or a bonus feat may be chosen.
        /// </summary>
        DefensiveRoll,

        /// <summary>
        /// Represents the Opportunist Special.
        /// Can be selected as one of Rogues extra special abilities
        /// at level 10, 13, 16, 19. Or a bonus feat may be chosen.
        /// </summary>
        Opportunist,

        /// <summary>
        /// Represents the Skill Mastery Special.
        /// Can be selected as one of Rogues extra special abilities
        /// at level 10, 13, 16, 19. Or a bonus feat may be chosen.
        /// </summary>
        SkillMastery,

        /// <summary>
        /// Represents the Slippery Mind Special.
        /// Can be selected as one of Rogues extra special abilities
        /// at level 10, 13, 16, 19. Or a bonus feat may be chosen.
        /// </summary>
        SlipperyMind,

        // The Sorcerer's Specials:

        /// <summary>
        /// Represents the Summon Familiar Special.
        /// </summary>
        SummonFamiliar,

        // The Wizard's Specials:

        /// <summary>
        /// Represents the Scribe Scroll Special.
        /// </summary>
        EnscribeScroll
    }
}
