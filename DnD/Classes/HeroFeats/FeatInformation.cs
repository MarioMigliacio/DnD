using DnD.Enums.ClassFeats;
using DnD.UserStrings;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// This information turned out to be vital for the application, so condensing the functions into a static class 
    /// helped reduce the same code over and over again. :)
    /// </summary>
    public static class FeatInformation
    {
        /// <summary>
        /// GetDescription is a helper function which gets the appropriate UserString for the Feat.
        /// </summary>
        /// <param name="which">What Feat do we need to look at to gather the correct FeatString.</param>
        /// <returns>A string description of the Feat.</returns>
        public static string GetDescription(ClassFeats which)
        {
            switch (which)
            {
                case ClassFeats.Acrobatic: return FeatStrings.Acrobatic;
                case ClassFeats.Agile: return FeatStrings.Agile;
                case ClassFeats.Alertness: return FeatStrings.Alertness;
                case ClassFeats.AnimalAffinity: return FeatStrings.AnimalAffinity;
                case ClassFeats.Athletic: return FeatStrings.Athletic;
                case ClassFeats.AugmentSummoning: return FeatStrings.AugmentSummoning;
                case ClassFeats.BlindFight: return FeatStrings.BlindFight;
                case ClassFeats.BrewPotion: return FeatStrings.BrewPotion;
                case ClassFeats.Cleave: return FeatStrings.Cleave;
                case ClassFeats.CombatCasting: return FeatStrings.CombatCasting;
                case ClassFeats.CombatExpertise: return FeatStrings.CombatExpertise;
                case ClassFeats.CombatReflexes: return FeatStrings.CombatReflexes;
                case ClassFeats.CraftMagicArmsAndArmor: return FeatStrings.CraftMagicArmsAndArmor;
                case ClassFeats.CraftRod: return FeatStrings.CraftRod;
                case ClassFeats.CraftStaff: return FeatStrings.CraftStaff;
                case ClassFeats.CraftWand: return FeatStrings.CraftWand;
                case ClassFeats.CraftWondrousItem: return FeatStrings.CraftWondrousItem;
                case ClassFeats.Deceitful: return FeatStrings.Deceitful;
                case ClassFeats.DeflectArrows: return FeatStrings.DeflectArrows;
                case ClassFeats.DeftHands: return FeatStrings.DeftHands;
                case ClassFeats.Diehard: return FeatStrings.Diehard;
                case ClassFeats.Diligent: return FeatStrings.Diligent;
                case ClassFeats.Dodge: return FeatStrings.Dodge;
                case ClassFeats.EmpowerSpell: return FeatStrings.EmpowerSpell;
                case ClassFeats.Endurance: return FeatStrings.Endurance;
                case ClassFeats.EnlargeSpell: return FeatStrings.EnlargeSpell;
                case ClassFeats.EschewMaterials: return FeatStrings.EschewMaterials;
                case ClassFeats.ExoticWeaponProficiency: return FeatStrings.ExoticWeaponProficiency;
                case ClassFeats.ExtendSpell: return FeatStrings.ExtendSpell;
                case ClassFeats.ExtraTurning: return FeatStrings.ExtraTurning;
                case ClassFeats.FarShot: return FeatStrings.FarShot;
                case ClassFeats.ForgeRing: return FeatStrings.ForgeRing;
                case ClassFeats.GreatCleave: return FeatStrings.GreatCleave;
                case ClassFeats.GreatFortitude: return FeatStrings.GreatFortitude;
                case ClassFeats.GreaterSpellFocus: return FeatStrings.GreaterSpellFocus;
                case ClassFeats.GreaterSpellPenetration: return FeatStrings.GreaterSpellPenetration;
                case ClassFeats.GreaterTwoWeaponFighting: return FeatStrings.GreaterTwoWeaponFighting;
                case ClassFeats.GreaterWeaponFocus: return FeatStrings.GreaterWeaponFocus;
                case ClassFeats.GreaterWeaponSpecialization: return FeatStrings.GreaterWeaponSpecialization;
                case ClassFeats.HeavyArmorProficiency: return FeatStrings.HeavyArmorProficiency;
                case ClassFeats.HeightenSpell: return FeatStrings.HeightenSpell;
                case ClassFeats.ImprovedBullRush: return FeatStrings.ImprovedBullRush;
                case ClassFeats.ImprovedCounterspell: return FeatStrings.ImprovedCounterspell;
                case ClassFeats.ImprovedCritical: return FeatStrings.ImprovedCritical;
                case ClassFeats.ImprovedDisarm: return FeatStrings.ImprovedDisarm;
                case ClassFeats.ImprovedFeint: return FeatStrings.ImprovedFeint;
                case ClassFeats.ImprovedGrapple: return FeatStrings.ImprovedGrapple;
                case ClassFeats.ImprovedInitiative: return FeatStrings.ImprovedInitiative;
                case ClassFeats.ImprovedOverrun: return FeatStrings.ImprovedOverrun;
                case ClassFeats.ImprovedPreciseShot: return FeatStrings.ImprovedPreciseShot;
                case ClassFeats.ImprovedShieldBash: return FeatStrings.ImprovedShieldBash;
                case ClassFeats.ImprovedSunder: return FeatStrings.ImprovedSunder;
                case ClassFeats.ImprovedTrip: return FeatStrings.ImprovedTrip;
                case ClassFeats.ImprovedTurning: return FeatStrings.ImprovedTurning;
                case ClassFeats.ImprovedTwoWeaponFighting: return FeatStrings.ImprovedTwoWeaponFighting;
                case ClassFeats.ImprovedUnarmedStrike: return FeatStrings.ImprovedUnarmedStrike;
                case ClassFeats.Investigator: return FeatStrings.Investigator;
                case ClassFeats.IronWill: return FeatStrings.IronWill;
                case ClassFeats.LightArmorProficiency: return FeatStrings.LightArmorProficiency;
                case ClassFeats.LightningReflexes: return FeatStrings.LightningReflexes;
                case ClassFeats.MagicalAptitude: return FeatStrings.MagicalAptitude;
                case ClassFeats.Manyshot: return FeatStrings.Manyshot;
                case ClassFeats.MartialWeaponProficiency: return FeatStrings.MartialWeaponProficiency;
                case ClassFeats.MaximizeSpell: return FeatStrings.MaximizeSpell;
                case ClassFeats.MediumArmorProficiency: return FeatStrings.MediumArmorProficiency;
                case ClassFeats.Mobility: return FeatStrings.Mobility;
                case ClassFeats.MountedArchery: return FeatStrings.MountedArchery;
                case ClassFeats.MountedCombat: return FeatStrings.MountedCombat;
                case ClassFeats.NaturalSpell: return FeatStrings.NaturalSpell;
                case ClassFeats.Negotiator: return FeatStrings.Negotiator;
                case ClassFeats.NimbleFingers: return FeatStrings.NimbleFingers;
                case ClassFeats.Persuasive: return FeatStrings.Persuasive;
                case ClassFeats.PointBlankShot: return FeatStrings.PointBlankShot;
                case ClassFeats.PowerAttack: return FeatStrings.PowerAttack;
                case ClassFeats.PreciseShot: return FeatStrings.PreciseShot;
                case ClassFeats.Quickdraw: return FeatStrings.Quickdraw;
                case ClassFeats.QuickenSpell: return FeatStrings.QuickenSpell;
                case ClassFeats.RapidReload: return FeatStrings.RapidReload;
                case ClassFeats.RapidShot: return FeatStrings.RapidShot;
                case ClassFeats.RideByAttack: return FeatStrings.RideByAttack;
                case ClassFeats.Run: return FeatStrings.Run;
                case ClassFeats.ScribeScroll: return FeatStrings.ScribeScroll;
                case ClassFeats.SelfSufficient: return FeatStrings.SelfSufficient;
                case ClassFeats.ShieldProficiency: return FeatStrings.ShieldProficiency;
                case ClassFeats.ShotOnTheRun: return FeatStrings.ShotOnTheRun;
                case ClassFeats.SilentSpell: return FeatStrings.SilentSpell;
                case ClassFeats.SimpleWeaponProficiency: return FeatStrings.SimpleWeaponProficiency;
                case ClassFeats.SkillFocus: return FeatStrings.SkillFocus;
                case ClassFeats.SnatchArrows: return FeatStrings.SnatchArrows;
                case ClassFeats.SpellFocus: return FeatStrings.SpellFocus;
                case ClassFeats.SpellMastery: return FeatStrings.SpellMastery;
                case ClassFeats.SpellPenetration: return FeatStrings.SpellPenetration;
                case ClassFeats.SpiritedCharge: return FeatStrings.SpiritedCharge;
                case ClassFeats.SpringAttack: return FeatStrings.SpringAttack;
                case ClassFeats.Stealthy: return FeatStrings.Stealthy;
                case ClassFeats.StillSpell: return FeatStrings.StillSpell;
                case ClassFeats.StunningFist: return FeatStrings.StunningFist;
                case ClassFeats.Toughness: return FeatStrings.Toughness;
                case ClassFeats.TowerShieldProficiency: return FeatStrings.TowerShieldProficiency;
                case ClassFeats.Track: return FeatStrings.Track;
                case ClassFeats.Trample: return FeatStrings.Trample;
                case ClassFeats.TwoWeaponFighting: return FeatStrings.TwoWeaponFighting;
                case ClassFeats.WeaponFinesse: return FeatStrings.WeaponFinesse;
                case ClassFeats.WeaponFocus: return FeatStrings.WeaponFocus;
                case ClassFeats.WeaponSpecialization: return FeatStrings.WeaponSpecialization;
                case ClassFeats.WhirlwindAttack: return FeatStrings.WhirlwindAttack;
                case ClassFeats.WidenSpell: return FeatStrings.WidenSpell;
                default: return null;
            }
        }

        /// <summary>
        /// Acquire the particular feats prerequisites all in one handy string description!
        /// </summary>
        /// <param name="which">Which feat are we looking at here?</param>
        /// <returns>The RequirementsString for the particular enumeration type of Feat.</returns>
        public static string GetPrerequisitesString(ClassFeats which)
        {
            switch (which)
            {
                case ClassFeats.Acrobatic: return FeatFactory.Create(ClassFeats.Acrobatic).RequirementsString();
                case ClassFeats.Agile: return FeatFactory.Create(ClassFeats.Agile).RequirementsString();
                case ClassFeats.Alertness: return FeatFactory.Create(ClassFeats.Alertness).RequirementsString();
                case ClassFeats.AnimalAffinity: return FeatFactory.Create(ClassFeats.AnimalAffinity).RequirementsString();
                case ClassFeats.Athletic: return FeatFactory.Create(ClassFeats.Athletic).RequirementsString();
                case ClassFeats.AugmentSummoning: return FeatFactory.Create(ClassFeats.AugmentSummoning).RequirementsString();
                case ClassFeats.BlindFight: return FeatFactory.Create(ClassFeats.BlindFight).RequirementsString();
                case ClassFeats.BrewPotion: return FeatFactory.Create(ClassFeats.BrewPotion).RequirementsString();
                case ClassFeats.Cleave: return FeatFactory.Create(ClassFeats.Cleave).RequirementsString();
                case ClassFeats.CombatCasting: return FeatFactory.Create(ClassFeats.CombatCasting).RequirementsString();
                case ClassFeats.CombatExpertise: return FeatFactory.Create(ClassFeats.CombatExpertise).RequirementsString();
                case ClassFeats.CombatReflexes: return FeatFactory.Create(ClassFeats.CombatReflexes).RequirementsString();
                case ClassFeats.CraftMagicArmsAndArmor: return FeatFactory.Create(ClassFeats.CraftMagicArmsAndArmor).RequirementsString();
                case ClassFeats.CraftRod: return FeatFactory.Create(ClassFeats.CraftRod).RequirementsString();
                case ClassFeats.CraftStaff: return FeatFactory.Create(ClassFeats.CraftStaff).RequirementsString();
                case ClassFeats.CraftWand: return FeatFactory.Create(ClassFeats.CraftWand).RequirementsString();
                case ClassFeats.CraftWondrousItem: return FeatFactory.Create(ClassFeats.CraftWondrousItem).RequirementsString();
                case ClassFeats.Deceitful: return FeatFactory.Create(ClassFeats.Deceitful).RequirementsString();
                case ClassFeats.DeflectArrows: return FeatFactory.Create(ClassFeats.DeflectArrows).RequirementsString();
                case ClassFeats.DeftHands: return FeatFactory.Create(ClassFeats.DeftHands).RequirementsString();
                case ClassFeats.Diehard: return FeatFactory.Create(ClassFeats.Diehard).RequirementsString();
                case ClassFeats.Diligent: return FeatFactory.Create(ClassFeats.Diligent).RequirementsString();
                case ClassFeats.Dodge: return FeatFactory.Create(ClassFeats.Dodge).RequirementsString();
                case ClassFeats.EmpowerSpell: return FeatFactory.Create(ClassFeats.EmpowerSpell).RequirementsString();
                case ClassFeats.Endurance: return FeatFactory.Create(ClassFeats.Endurance).RequirementsString();
                case ClassFeats.EnlargeSpell: return FeatFactory.Create(ClassFeats.EnlargeSpell).RequirementsString();
                case ClassFeats.EschewMaterials: return FeatFactory.Create(ClassFeats.EschewMaterials).RequirementsString();
                case ClassFeats.ExoticWeaponProficiency: return FeatFactory.Create(ClassFeats.ExoticWeaponProficiency).RequirementsString();
                case ClassFeats.ExtendSpell: return FeatFactory.Create(ClassFeats.ExtendSpell).RequirementsString();
                case ClassFeats.ExtraTurning: return FeatFactory.Create(ClassFeats.ExtraTurning).RequirementsString();
                case ClassFeats.FarShot: return FeatFactory.Create(ClassFeats.FarShot).RequirementsString();
                case ClassFeats.ForgeRing: return FeatFactory.Create(ClassFeats.ForgeRing).RequirementsString();
                case ClassFeats.GreatCleave: return FeatFactory.Create(ClassFeats.GreatCleave).RequirementsString();
                case ClassFeats.GreatFortitude: return FeatFactory.Create(ClassFeats.GreatFortitude).RequirementsString();
                case ClassFeats.GreaterSpellFocus: return FeatFactory.Create(ClassFeats.GreaterSpellFocus).RequirementsString();
                case ClassFeats.GreaterSpellPenetration: return FeatFactory.Create(ClassFeats.GreaterSpellPenetration).RequirementsString();
                case ClassFeats.GreaterTwoWeaponFighting: return FeatFactory.Create(ClassFeats.GreaterTwoWeaponFighting).RequirementsString();
                case ClassFeats.GreaterWeaponFocus: return FeatFactory.Create(ClassFeats.GreaterWeaponFocus).RequirementsString();
                case ClassFeats.GreaterWeaponSpecialization: return FeatFactory.Create(ClassFeats.GreaterWeaponSpecialization).RequirementsString();
                case ClassFeats.HeavyArmorProficiency: return FeatFactory.Create(ClassFeats.HeavyArmorProficiency).RequirementsString();
                case ClassFeats.HeightenSpell: return FeatFactory.Create(ClassFeats.HeightenSpell).RequirementsString();
                case ClassFeats.ImprovedBullRush: return FeatFactory.Create(ClassFeats.ImprovedBullRush).RequirementsString();
                case ClassFeats.ImprovedCounterspell: return FeatFactory.Create(ClassFeats.ImprovedCounterspell).RequirementsString();
                case ClassFeats.ImprovedCritical: return FeatFactory.Create(ClassFeats.ImprovedCritical).RequirementsString();
                case ClassFeats.ImprovedDisarm: return FeatFactory.Create(ClassFeats.ImprovedDisarm).RequirementsString();
                case ClassFeats.ImprovedFeint: return FeatFactory.Create(ClassFeats.ImprovedFeint).RequirementsString();
                case ClassFeats.ImprovedGrapple: return FeatFactory.Create(ClassFeats.ImprovedGrapple).RequirementsString();
                case ClassFeats.ImprovedInitiative: return FeatFactory.Create(ClassFeats.ImprovedInitiative).RequirementsString();
                case ClassFeats.ImprovedOverrun: return FeatFactory.Create(ClassFeats.ImprovedOverrun).RequirementsString();
                case ClassFeats.ImprovedPreciseShot: return FeatFactory.Create(ClassFeats.ImprovedPreciseShot).RequirementsString();
                case ClassFeats.ImprovedShieldBash: return FeatFactory.Create(ClassFeats.ImprovedShieldBash).RequirementsString();
                case ClassFeats.ImprovedSunder: return FeatFactory.Create(ClassFeats.ImprovedSunder).RequirementsString();
                case ClassFeats.ImprovedTrip: return FeatFactory.Create(ClassFeats.ImprovedTrip).RequirementsString();
                case ClassFeats.ImprovedTurning: return FeatFactory.Create(ClassFeats.ImprovedTurning).RequirementsString();
                case ClassFeats.ImprovedTwoWeaponFighting: return FeatFactory.Create(ClassFeats.ImprovedTwoWeaponFighting).RequirementsString();
                case ClassFeats.ImprovedUnarmedStrike: return FeatFactory.Create(ClassFeats.ImprovedUnarmedStrike).RequirementsString();
                case ClassFeats.Investigator: return FeatFactory.Create(ClassFeats.Investigator).RequirementsString();
                case ClassFeats.IronWill: return FeatFactory.Create(ClassFeats.IronWill).RequirementsString();
                case ClassFeats.LightArmorProficiency: return FeatFactory.Create(ClassFeats.LightArmorProficiency).RequirementsString();
                case ClassFeats.LightningReflexes: return FeatFactory.Create(ClassFeats.LightningReflexes).RequirementsString();
                case ClassFeats.MagicalAptitude: return FeatFactory.Create(ClassFeats.MagicalAptitude).RequirementsString();
                case ClassFeats.Manyshot: return FeatFactory.Create(ClassFeats.Manyshot).RequirementsString();
                case ClassFeats.MartialWeaponProficiency: return FeatFactory.Create(ClassFeats.MartialWeaponProficiency).RequirementsString();
                case ClassFeats.MaximizeSpell: return FeatFactory.Create(ClassFeats.MaximizeSpell).RequirementsString();
                case ClassFeats.MediumArmorProficiency: return FeatFactory.Create(ClassFeats.MediumArmorProficiency).RequirementsString();
                case ClassFeats.Mobility: return FeatFactory.Create(ClassFeats.Mobility).RequirementsString();
                case ClassFeats.MountedArchery: return FeatFactory.Create(ClassFeats.MountedArchery).RequirementsString();
                case ClassFeats.MountedCombat: return FeatFactory.Create(ClassFeats.MountedCombat).RequirementsString();
                case ClassFeats.NaturalSpell: return FeatFactory.Create(ClassFeats.NaturalSpell).RequirementsString();
                case ClassFeats.Negotiator: return FeatFactory.Create(ClassFeats.Negotiator).RequirementsString();
                case ClassFeats.NimbleFingers: return FeatFactory.Create(ClassFeats.NimbleFingers).RequirementsString();
                case ClassFeats.Persuasive: return FeatFactory.Create(ClassFeats.Persuasive).RequirementsString();
                case ClassFeats.PointBlankShot: return FeatFactory.Create(ClassFeats.PointBlankShot).RequirementsString();
                case ClassFeats.PowerAttack: return FeatFactory.Create(ClassFeats.PowerAttack).RequirementsString();
                case ClassFeats.PreciseShot: return FeatFactory.Create(ClassFeats.PreciseShot).RequirementsString();
                case ClassFeats.Quickdraw: return FeatFactory.Create(ClassFeats.Quickdraw).RequirementsString();
                case ClassFeats.QuickenSpell: return FeatFactory.Create(ClassFeats.QuickenSpell).RequirementsString();
                case ClassFeats.RapidReload: return FeatFactory.Create(ClassFeats.RapidReload).RequirementsString();
                case ClassFeats.RapidShot: return FeatFactory.Create(ClassFeats.RapidShot).RequirementsString();
                case ClassFeats.RideByAttack: return FeatFactory.Create(ClassFeats.RideByAttack).RequirementsString();
                case ClassFeats.Run: return FeatFactory.Create(ClassFeats.Run).RequirementsString();
                case ClassFeats.ScribeScroll: return FeatFactory.Create(ClassFeats.ScribeScroll).RequirementsString();
                case ClassFeats.SelfSufficient: return FeatFactory.Create(ClassFeats.SelfSufficient).RequirementsString();
                case ClassFeats.ShieldProficiency: return FeatFactory.Create(ClassFeats.ShieldProficiency).RequirementsString();
                case ClassFeats.ShotOnTheRun: return FeatFactory.Create(ClassFeats.ShotOnTheRun).RequirementsString();
                case ClassFeats.SilentSpell: return FeatFactory.Create(ClassFeats.SilentSpell).RequirementsString();
                case ClassFeats.SimpleWeaponProficiency: return FeatFactory.Create(ClassFeats.SimpleWeaponProficiency).RequirementsString();
                case ClassFeats.SkillFocus: return FeatFactory.Create(ClassFeats.SkillFocus).RequirementsString();
                case ClassFeats.SnatchArrows: return FeatFactory.Create(ClassFeats.SnatchArrows).RequirementsString();
                case ClassFeats.SpellFocus: return FeatFactory.Create(ClassFeats.SpellFocus).RequirementsString();
                case ClassFeats.SpellMastery: return FeatFactory.Create(ClassFeats.SpellMastery).RequirementsString();
                case ClassFeats.SpellPenetration: return FeatFactory.Create(ClassFeats.SpellPenetration).RequirementsString();
                case ClassFeats.SpiritedCharge: return FeatFactory.Create(ClassFeats.SpiritedCharge).RequirementsString();
                case ClassFeats.SpringAttack: return FeatFactory.Create(ClassFeats.SpringAttack).RequirementsString();
                case ClassFeats.Stealthy: return FeatFactory.Create(ClassFeats.Stealthy).RequirementsString();
                case ClassFeats.StillSpell: return FeatFactory.Create(ClassFeats.StillSpell).RequirementsString();
                case ClassFeats.StunningFist: return FeatFactory.Create(ClassFeats.StunningFist).RequirementsString();
                case ClassFeats.Toughness: return FeatFactory.Create(ClassFeats.Toughness).RequirementsString();
                case ClassFeats.TowerShieldProficiency: return FeatFactory.Create(ClassFeats.TowerShieldProficiency).RequirementsString();
                case ClassFeats.Track: return FeatFactory.Create(ClassFeats.Track).RequirementsString();
                case ClassFeats.Trample: return FeatFactory.Create(ClassFeats.Trample).RequirementsString();
                case ClassFeats.TwoWeaponFighting: return FeatFactory.Create(ClassFeats.TwoWeaponFighting).RequirementsString();
                case ClassFeats.WeaponFinesse: return FeatFactory.Create(ClassFeats.WeaponFinesse).RequirementsString();
                case ClassFeats.WeaponFocus: return FeatFactory.Create(ClassFeats.WeaponFocus).RequirementsString();
                case ClassFeats.WeaponSpecialization: return FeatFactory.Create(ClassFeats.WeaponSpecialization).RequirementsString();
                case ClassFeats.WhirlwindAttack: return FeatFactory.Create(ClassFeats.WhirlwindAttack).RequirementsString();
                case ClassFeats.WidenSpell: return FeatFactory.Create(ClassFeats.WidenSpell).RequirementsString();
                default: return null;
            }
        }

        /// <summary>
        /// If the user can get a string of the Feat, we need a way to gather the correct enumeration which corresponds to that string.
        /// </summary>
        /// <param name="hwat">DAMNIT BOBBEH!!!</param>
        /// <returns>The correct ClassFeats enumeration field according to the string passed in.</returns>
        public static ClassFeats? GetEnumFromString(string hwat)
        {
            switch (hwat)
            {
                case "Acrobatic": return ClassFeats.Acrobatic;
                case "Agile": return ClassFeats.Agile;
                case "Alertness": return ClassFeats.Alertness;
                case "AnimalAffinity": return ClassFeats.AnimalAffinity;
                case "Athletic": return ClassFeats.Athletic;
                case "AugmentSummoning": return ClassFeats.AugmentSummoning;
                case "BlindFight": return ClassFeats.BlindFight;
                case "BrewPotion": return ClassFeats.BrewPotion;
                case "Cleave": return ClassFeats.Cleave;
                case "CombatCasting": return ClassFeats.CombatCasting;
                case "CombatExpertise": return ClassFeats.CombatExpertise;
                case "CombatReflexes": return ClassFeats.CombatReflexes;
                case "CraftMagicArmsAndArmor": return ClassFeats.CraftMagicArmsAndArmor;
                case "CraftRod": return ClassFeats.CraftRod;
                case "CraftStaff": return ClassFeats.CraftStaff;
                case "CraftWand": return ClassFeats.CraftWand;
                case "CraftWondrousItem": return ClassFeats.CraftWondrousItem;
                case "Deceitful": return ClassFeats.Deceitful;
                case "DeflectArrows": return ClassFeats.DeflectArrows;
                case "DeftHands": return ClassFeats.DeftHands;
                case "Diehard": return ClassFeats.Diehard;
                case "Diligent": return ClassFeats.Diligent;
                case "Dodge": return ClassFeats.Dodge;
                case "EmpowerSpell": return ClassFeats.EmpowerSpell;
                case "Endurance": return ClassFeats.Endurance;
                case "EnlargeSpell": return ClassFeats.EnlargeSpell;
                case "EschewMaterials": return ClassFeats.EschewMaterials;
                case "ExoticWeaponProficiency": return ClassFeats.ExoticWeaponProficiency;
                case "ExtendSpell": return ClassFeats.ExtendSpell;
                case "ExtraTurning": return ClassFeats.ExtraTurning;
                case "FarShot": return ClassFeats.FarShot;
                case "ForgeRing": return ClassFeats.ForgeRing;
                case "GreatCleave": return ClassFeats.GreatCleave;
                case "GreatFortitude": return ClassFeats.GreatFortitude;
                case "GreaterSpellFocus": return ClassFeats.GreaterSpellFocus;
                case "GreaterSpellPenetration": return ClassFeats.GreaterSpellPenetration;
                case "GreaterTwoWeaponFighting": return ClassFeats.GreaterTwoWeaponFighting;
                case "GreaterWeaponFocus": return ClassFeats.GreaterWeaponFocus;
                case "GreaterWeaponSpecialization": return ClassFeats.GreaterWeaponSpecialization;
                case "HeavyArmorProficiency": return ClassFeats.HeavyArmorProficiency;
                case "HeightenSpell": return ClassFeats.HeightenSpell;
                case "ImprovedBullRush": return ClassFeats.ImprovedBullRush;
                case "ImprovedCounterspell": return ClassFeats.ImprovedCounterspell;
                case "ImprovedCritical": return ClassFeats.ImprovedCritical;
                case "ImprovedDisarm": return ClassFeats.ImprovedDisarm;
                case "ImprovedFeint": return ClassFeats.ImprovedFeint;
                case "ImprovedGrapple": return ClassFeats.ImprovedGrapple;
                case "ImprovedInitiative": return ClassFeats.ImprovedInitiative;
                case "ImprovedOverrun": return ClassFeats.ImprovedOverrun;
                case "ImprovedPreciseShot": return ClassFeats.ImprovedPreciseShot;
                case "ImprovedShieldBash": return ClassFeats.ImprovedShieldBash;
                case "ImprovedSunder": return ClassFeats.ImprovedSunder;
                case "ImprovedTrip": return ClassFeats.ImprovedTrip;
                case "ImprovedTurning": return ClassFeats.ImprovedTurning;
                case "ImprovedTwoWeaponFighting": return ClassFeats.ImprovedTwoWeaponFighting;
                case "ImprovedUnarmedStrike": return ClassFeats.ImprovedUnarmedStrike;
                case "Investigator": return ClassFeats.Investigator;
                case "IronWill": return ClassFeats.IronWill;
                case "LightArmorProficiency": return ClassFeats.LightArmorProficiency;
                case "LightningReflexes": return ClassFeats.LightningReflexes;
                case "MagicalAptitude": return ClassFeats.MagicalAptitude;
                case "Manyshot": return ClassFeats.Manyshot;
                case "MartialWeaponProficiency": return ClassFeats.MartialWeaponProficiency;
                case "MaximizeSpell": return ClassFeats.MaximizeSpell;
                case "MediumArmorProficiency": return ClassFeats.MediumArmorProficiency;
                case "Mobility": return ClassFeats.Mobility;
                case "MountedArchery": return ClassFeats.MountedArchery;
                case "MountedCombat": return ClassFeats.MountedCombat;
                case "NaturalSpell": return ClassFeats.NaturalSpell;
                case "Negotiator": return ClassFeats.Negotiator;
                case "NimbleFingers": return ClassFeats.NimbleFingers;
                case "Persuasive": return ClassFeats.Persuasive;
                case "PointBlankShot": return ClassFeats.PointBlankShot;
                case "PowerAttack": return ClassFeats.PowerAttack;
                case "PreciseShot": return ClassFeats.PreciseShot;
                case "Quickdraw": return ClassFeats.Quickdraw;
                case "QuickenSpell": return ClassFeats.QuickenSpell;
                case "RapidReload": return ClassFeats.RapidReload;
                case "RapidShot": return ClassFeats.RapidShot;
                case "RideByAttack": return ClassFeats.RideByAttack;
                case "Run": return ClassFeats.Run;
                case "ScribeScroll": return ClassFeats.ScribeScroll;
                case "SelfSufficient": return ClassFeats.SelfSufficient;
                case "ShieldProficiency": return ClassFeats.ShieldProficiency;
                case "ShotOnTheRun": return ClassFeats.ShotOnTheRun;
                case "SilentSpell": return ClassFeats.SilentSpell;
                case "SimpleWeaponProficiency": return ClassFeats.SimpleWeaponProficiency;
                case "SkillFocus": return ClassFeats.SkillFocus;
                case "SnatchArrows": return ClassFeats.SnatchArrows;
                case "SpellFocus": return ClassFeats.SpellFocus;
                case "SpellMastery": return ClassFeats.SpellMastery;
                case "SpellPenetration": return ClassFeats.SpellPenetration;
                case "SpiritedCharge": return ClassFeats.SpiritedCharge;
                case "SpringAttack": return ClassFeats.SpringAttack;
                case "Stealthy": return ClassFeats.Stealthy;
                case "StillSpell": return ClassFeats.StillSpell;
                case "StunningFist": return ClassFeats.StunningFist;
                case "Toughness": return ClassFeats.Toughness;
                case "TowerShieldProficiency": return ClassFeats.TowerShieldProficiency;
                case "Track": return ClassFeats.Track;
                case "Trample": return ClassFeats.Trample;
                case "TwoWeaponFighting": return ClassFeats.TwoWeaponFighting;
                case "WeaponFinesse": return ClassFeats.WeaponFinesse;
                case "WeaponFocus": return ClassFeats.WeaponFocus;
                case "WeaponSpecialization": return ClassFeats.WeaponSpecialization;
                case "WhirlwindAttack": return ClassFeats.WhirlwindAttack;
                case "WidenSpell": return ClassFeats.WidenSpell;
                default: return null;
            }
        }
    }
}
