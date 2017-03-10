using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DnD.Enums.ClassFeats
{
    /// <summary>
    /// Feats are unique and boost character individuality, they bolster some aspect to a hero in various ways.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClassFeats
    {
        /// <summary>
        /// The Acrobatic Feat.
        /// </summary>
        Acrobatic,

        /// <summary>
        /// The Agile Feat.
        /// </summary>
        Agile,

        /// <summary>
        /// The Alertness Feat.
        /// </summary>
        Alertness,

        /// <summary>
        /// The Animal Affinity Feat.
        /// </summary>
        AnimalAffinity,

        /// <summary>
        /// The Armor Proficiency (light) Feat.
        /// </summary>
        LightArmorProficiency,

        /// <summary>
        /// The Armor Proficiency (medium) Feat.
        /// </summary>
        MediumArmorProficiency,

        /// <summary>
        /// The Armor Proficiency (heavy) Feat.
        /// </summary>
        HeavyArmorProficiency,

        /// <summary>
        /// The Athletic Feat.
        /// </summary>
        Athletic,

        /// <summary>
        /// The Augment Summoning Feat.
        /// </summary>
        AugmentSummoning,

        /// <summary>
        /// The Blind Fight Feat.
        /// </summary>
        BlindFight,

        /// <summary>
        /// The Combat Casting Feat.
        /// </summary>
        CombatCasting,

        /// <summary>
        /// The Combat Expertise Feat.
        /// </summary>
        CombatExpertise,

        /// <summary>
        /// The Improved Disarm Feat.
        /// </summary>
        ImprovedDisarm,

        /// <summary>
        /// The Improved Feint Feat.
        /// </summary>
        ImprovedFeint,

        /// <summary>
        /// The Improved Trip Feat.
        /// </summary>
        ImprovedTrip,

        /// <summary>
        /// The Whirlwind Attack Feat.
        /// </summary>
        WhirlwindAttack,

        /// <summary>
        /// The Combat Reflexes Feat.
        /// </summary>
        CombatReflexes,

        /// <summary>
        /// The Deceitful Feat.
        /// </summary>
        Deceitful,

        /// <summary>
        /// The Deft Hands Feat.
        /// </summary>
        DeftHands,

        /// <summary>
        /// The Diligent Feat.
        /// </summary>
        Diligent,

        /// <summary>
        /// The Dodge Feat.
        /// </summary>
        Dodge,

        /// <summary>
        /// The Mobility Feat.
        /// </summary>
        Mobility,

        /// <summary>
        /// The Spring Attack Feat.
        /// </summary>
        SpringAttack,

        /// <summary>
        /// The Endurance Feat.
        /// </summary>
        Endurance,

        /// <summary>
        /// The Diehard Feat.
        /// </summary>
        Diehard,

        /// <summary>
        /// The Eschew Materials Feat.
        /// </summary>
        EschewMaterials,

        /// <summary>
        /// The Exotic Weapon Proficiency Feat.
        /// </summary>
        ExoticWeaponProficiency,

        /// <summary>
        /// The Extra Turning Feat.
        /// </summary>
        ExtraTurning,

        /// <summary>
        /// The Great Fortitude Feat.
        /// </summary>
        GreatFortitude,

        /// <summary>
        /// The Improved Counterspell Feat.
        /// </summary>
        ImprovedCounterspell,

        /// <summary>
        /// The Improved Critical Feat.
        /// </summary>
        ImprovedCritical,

        /// <summary>
        /// The Improved Initiative Feat.
        /// </summary>
        ImprovedInitiative,

        /// <summary>
        /// The Improved Turning Feat.
        /// </summary>
        ImprovedTurning,

        /// <summary>
        /// The Improved Unarmed Strike Feat.
        /// </summary>
        ImprovedUnarmedStrike,

        /// <summary>
        /// The Improved Grapple Feat.
        /// </summary>
        ImprovedGrapple,

        /// <summary>
        /// The Deflect Arrows Feat.
        /// </summary>
        DeflectArrows,

        /// <summary>
        /// The Snatch Arrows Feat.
        /// </summary>
        SnatchArrows,

        /// <summary>
        /// The Stunning Fist Feat.
        /// </summary>
        StunningFist,

        /// <summary>
        /// The Investigator Feat.
        /// </summary>
        Investigator,

        /// <summary>
        /// The Iron Will Feat.
        /// </summary>
        IronWill,

        /// <summary>
        /// The Lightning Reflexes Feat.
        /// </summary>
        LightningReflexes,

        /// <summary>
        /// The Magical Aptitude Feat.
        /// </summary>
        MagicalAptitude,

        /// <summary>
        /// The Martial Weapon Proficiency Feat.
        /// </summary>
        MartialWeaponProficiency,

        /// <summary>
        /// The Mounted Combat Feat.
        /// </summary>
        MountedCombat,

        /// <summary>
        /// The Mounted Archery Feat.
        /// </summary>
        MountedArchery,

        /// <summary>
        /// The Ride By Attack Feat.
        /// </summary>
        RideByAttack,

        /// <summary>
        /// The Spirited Charge Feat.
        /// </summary>
        SpiritedCharge,

        /// <summary>
        /// The Trample Feat.
        /// </summary>
        Trample,

        /// <summary>
        /// The Natural Spell Feat.
        /// </summary>
        NaturalSpell,

        /// <summary>
        /// The Negotiator Feat.
        /// </summary>
        Negotiator,

        /// <summary>
        /// The Nimble Fingers Feat.
        /// </summary>
        NimbleFingers,

        /// <summary>
        /// The Persuasive Feat.
        /// </summary>
        Persuasive,

        /// <summary>
        /// The Point Blank Shot Feat.
        /// </summary>
        PointBlankShot,

        /// <summary>
        /// The Far Shot Feat.
        /// </summary>
        FarShot,

        /// <summary>
        /// The Precise Shot Feat.
        /// </summary>
        PreciseShot,

        /// <summary>
        /// The Improved Precise Shot Feat.
        /// </summary>
        ImprovedPreciseShot,

        /// <summary>
        /// The Rapid Shot Feat.
        /// </summary>
        RapidShot,

        /// <summary>
        /// The Manyshot Feat.
        /// </summary>
        Manyshot,

        /// <summary>
        /// The Shot On The Run Feat.
        /// </summary>
        ShotOnTheRun,

        /// <summary>
        /// The Power Attack Feat.
        /// </summary>
        PowerAttack,

        /// <summary>
        /// The Cleave Feat.
        /// </summary>
        Cleave,

        /// <summary>
        /// The Great Cleave Feat.
        /// </summary>
        GreatCleave,

        /// <summary>
        /// The Improved Bull Rush Feat.
        /// </summary>
        ImprovedBullRush,

        /// <summary>
        /// The Improved Overrun Feat.
        /// </summary>
        ImprovedOverrun,

        /// <summary>
        /// The Improved Sunder Feat.
        /// </summary>
        ImprovedSunder,

        /// <summary>
        /// The Quickdraw Feat.
        /// </summary>
        Quickdraw,

        /// <summary>
        /// The Rapid Reload Feat.
        /// </summary>
        RapidReload,

        /// <summary>
        /// The Run Feat.
        /// </summary>
        Run,

        /// <summary>
        /// The Self Sufficient Feat.
        /// </summary>
        SelfSufficient,

        /// <summary>
        /// The Shield Proficiency Feat.
        /// </summary>
        ShieldProficiency,

        /// <summary>
        /// The Improved Shield Bash Feat.
        /// </summary>
        ImprovedShieldBash,

        /// <summary>
        /// The Tower Shield Proficiency Feat.
        /// </summary>
        TowerShieldProficiency,

        /// <summary>
        /// The Simple Weapon Proficiency Feat.
        /// </summary>
        SimpleWeaponProficiency,

        /// <summary>
        /// The Skill Focus Feat.
        /// </summary>
        SkillFocus,

        /// <summary>
        /// The Spell Focus Feat.
        /// </summary>
        SpellFocus,

        /// <summary>
        /// The Greater Spell Focus Feat.
        /// </summary>
        GreaterSpellFocus,

        /// <summary>
        /// The Spell Mastery Feat.
        /// </summary>
        SpellMastery,

        /// <summary>
        /// The Spell Penetration Feat.
        /// </summary>
        SpellPenetration,

        /// <summary>
        /// The Greater Spell Penetration Feat.
        /// </summary>
        GreaterSpellPenetration,

        /// <summary>
        /// The Stealthy Feat.
        /// </summary>
        Stealthy,

        /// <summary>
        /// The Toughness Feat.
        /// </summary>
        Toughness,

        /// <summary>
        /// The Track Feat.
        /// </summary>
        Track,

        /// <summary>
        /// The Two Weapon Fighting Feat.
        /// </summary>
        TwoWeaponFighting,

        /// <summary>
        /// The Improved Two Weapon Fighting Feat.
        /// </summary>
        ImprovedTwoWeaponFighting,

        /// <summary>
        /// The Greater Two Weapon Fighting Feat.
        /// </summary>
        GreaterTwoWeaponFighting,

        /// <summary>
        /// The Weapon Finesse Feat.
        /// </summary>
        WeaponFinesse,

        /// <summary>
        /// The Weapon Focus Feat.
        /// </summary>
        WeaponFocus,

        /// <summary>
        /// The Weapon Specialization Feat.
        /// </summary>
        WeaponSpecialization,

        /// <summary>
        /// The Greater Weapon Focus Feat.
        /// </summary>
        GreaterWeaponFocus,

        /// <summary>
        /// The Greater Weapon Specialization Feat.
        /// </summary>
        GreaterWeaponSpecialization,

        /// <summary>
        /// The Brew Potion Feat.
        /// </summary>
        BrewPotion,

        /// <summary>
        /// The Craft Magical Arms and Armor Feat.
        /// </summary>
        CraftMagicArmsAndArmor,

        /// <summary>
        /// The Craft Rod Feat.
        /// </summary>
        CraftRod,

        /// <summary>
        /// The Craft Staff Feat.
        /// </summary>
        CraftStaff,

        /// <summary>
        /// The Craft Wand Feat.
        /// </summary>
        CraftWand,

        /// <summary>
        /// The Craft Wondrous Item Feat.
        /// </summary>
        CraftWondrousItem,

        /// <summary>
        /// The Forge Ring Feat.
        /// </summary>
        ForgeRing,

        /// <summary>
        /// The Scribe Scroll Feat.
        /// </summary>
        ScribeScroll,

        /// <summary>
        /// The Empower Spell Feat.
        /// </summary>
        EmpowerSpell,

        /// <summary>
        /// The Enlarge Spell Feat.
        /// </summary>
        EnlargeSpell,

        /// <summary>
        /// The Extend Spell Feat.
        /// </summary>
        ExtendSpell,

        /// <summary>
        /// The Heighten Spell Feat.
        /// </summary>
        HeightenSpell,

        /// <summary>
        /// The Maximize Spell Feat.
        /// </summary>
        MaximizeSpell,

        /// <summary>
        /// The Quicken Spell Feat.
        /// </summary>
        QuickenSpell,

        /// <summary>
        /// The Silent Spell Feat.
        /// </summary>
        SilentSpell,

        /// <summary>
        /// The Still Spell Feat.
        /// </summary>
        StillSpell,

        /// <summary>
        /// The Widen Spell Feat.
        /// </summary>
        WidenSpell
    }
}
