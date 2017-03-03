using DnD.Enums.ClassFeats;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// A useful factory tool which needs not be constructed. Simply pass in the Enum which corresponds to a feat, 
    /// and receive that feat as a new object.
    /// </summary>
    public static class FeatFactory
    {
        /// <summary>
        /// The design pattern of the Factory. Creates a new feat and returns it to the caller.
        /// </summary>
        /// <param name="which">Represents the <see cref="ClassFeats"/>enum.</param>
        /// <returns>The particular Feat object which is represented by that enum.</returns>
        public static BaseFeat Create(ClassFeats which)
        {
            switch (which)
            {
                case ClassFeats.Acrobatic: return new Acrobatic();
                case ClassFeats.Agile: return new Agile();
                case ClassFeats.Alertness: return new Alertness();
                case ClassFeats.AnimalAffinity: return new AnimalAffinity();
                case ClassFeats.Athletic: return new Athletic();
                case ClassFeats.AugmentSummoning: return new AugmentSummoning();
                case ClassFeats.BlindFight: return new BlindFight();
                case ClassFeats.BrewPotion: return new BrewPotion();
                case ClassFeats.Cleave: return new Cleave();
                case ClassFeats.CombatCasting: return new CombatCasting();
                case ClassFeats.CombatExpertise: return new CombatExpertise();
                case ClassFeats.CombatReflexes: return new CombatReflexes();
                case ClassFeats.CraftMagicArmsAndArmor: return new CraftMagicArmsAndArmor();
                case ClassFeats.CraftRod: return new CraftRod();
                case ClassFeats.CraftStaff: return new CraftStaff();
                case ClassFeats.CraftWand: return new CraftWand();
                case ClassFeats.CraftWondrousItem: return new CraftWondrousItem();
                case ClassFeats.Deceitful: return new Deceitful();
                case ClassFeats.DeflectArrows: return new DeflectArrows();
                case ClassFeats.DeftHands: return new DeftHands();
                case ClassFeats.Diehard: return new Diehard();
                case ClassFeats.Diligent: return new Diligent();
                case ClassFeats.Dodge: return new Dodge();
                case ClassFeats.EmpowerSpell: return new EmpowerSpell();
                case ClassFeats.Endurance: return new Endurance();
                case ClassFeats.EnlargeSpell: return new EnlargeSpell();
                case ClassFeats.EschewMaterials: return new EschewMaterials();
                case ClassFeats.ExoticWeaponProficiency: return new ExoticWeaponProficiency();
                case ClassFeats.ExtendSpell: return new ExtendSpell();
                case ClassFeats.ExtraTurning: return new ExtraTurning();
                case ClassFeats.FarShot: return new FarShot();
                case ClassFeats.ForgeRing: return new ForgeRing();
                case ClassFeats.GreatCleave: return new GreatCleave();
                case ClassFeats.GreatFortitude: return new GreatFortitude();
                case ClassFeats.GreaterSpellFocus: return new GreaterSpellFocus();
                case ClassFeats.GreaterSpellPenetration: return new GreaterSpellPenetration();
                case ClassFeats.GreaterTwoWeaponFighting: return new GreaterTwoWeaponFighting();
                case ClassFeats.GreaterWeaponFocus: return new GreaterWeaponFocus();
                case ClassFeats.GreaterWeaponSpecialization: return new GreaterWeaponSpecialization();
                case ClassFeats.HeavyArmorProficiency: return new HeavyArmorProficiency();
                case ClassFeats.HeightenSpell: return new HeightenSpell();
                case ClassFeats.ImprovedBullRush: return new ImprovedBullRush();
                case ClassFeats.ImprovedCounterspell: return new ImprovedCounterspell();
                case ClassFeats.ImprovedCritical: return new ImprovedCritical();
                case ClassFeats.ImprovedDisarm: return new ImprovedDisarm();
                case ClassFeats.ImprovedFeint: return new ImprovedFeint();
                case ClassFeats.ImprovedGrapple: return new ImprovedGrapple();
                case ClassFeats.ImprovedInitiative: return new ImprovedInitiative();
                case ClassFeats.ImprovedOverrun: return new ImprovedOverrun();
                case ClassFeats.ImprovedPreciseShot: return new ImprovedPreciseShot();
                case ClassFeats.ImprovedShieldBash: return new ImprovedShieldBash();
                case ClassFeats.ImprovedSunder: return new ImprovedSunder();
                case ClassFeats.ImprovedTrip: return new ImprovedTrip();
                case ClassFeats.ImprovedTurning: return new ImprovedTurning();
                case ClassFeats.ImprovedTwoWeaponFighting: return new ImprovedTwoWeaponFighting();
                case ClassFeats.ImprovedUnarmedStrike: return new ImprovedUnarmedStrike();
                case ClassFeats.Investigator: return new Investigator();
                case ClassFeats.IronWill: return new IronWill();
                case ClassFeats.LightArmorProficiency: return new LightArmorProficiency();
                case ClassFeats.LightningReflexes: return new LightningReflexes();
                case ClassFeats.MagicalAptitude: return new MagicalAptitude();
                case ClassFeats.Manyshot: return new Manyshot();
                case ClassFeats.MartialWeaponProficiency: return new MartialWeaponProficiency();
                case ClassFeats.MaximizeSpell: return new MaximizeSpell();
                case ClassFeats.MediumArmorProficiency: return new MediumArmorProficiency();
                case ClassFeats.Mobility: return new Mobility();
                case ClassFeats.MountedArchery: return new MountedArchery();
                case ClassFeats.MountedCombat: return new MountedCombat();
                case ClassFeats.NaturalSpell: return new NaturalSpell();
                case ClassFeats.Negotiator: return new Negotiator();
                case ClassFeats.NimbleFingers: return new NimbleFingers();
                case ClassFeats.Persuasive: return new Persuasive();
                case ClassFeats.PointBlankShot: return new PointBlankShot();
                case ClassFeats.PowerAttack: return new PowerAttack();
                case ClassFeats.PreciseShot: return new PreciseShot();
                case ClassFeats.Quickdraw: return new Quickdraw();
                case ClassFeats.QuickenSpell: return new QuickenSpell();
                case ClassFeats.RapidReload: return new RapidReload();
                case ClassFeats.RapidShot: return new RapidShot();
                case ClassFeats.RideByAttack: return new RideByAttack();
                case ClassFeats.Run: return new Run();
                case ClassFeats.ScribeScroll: return new ScribeScroll();
                case ClassFeats.SelfSufficient: return new SelfSufficient();
                case ClassFeats.ShieldProficiency: return new ShieldProficiency();
                case ClassFeats.ShotOnTheRun: return new ShotOnTheRun();
                case ClassFeats.SilentSpell: return new SilentSpell();
                case ClassFeats.SimpleWeaponProficiency: return new SimpleWeaponProficiency();
                case ClassFeats.SkillFocus: return new SkillFocus();
                case ClassFeats.SnatchArrows: return new SnatchArrows();
                case ClassFeats.SpellFocus: return new SpellFocus();
                case ClassFeats.SpellMastery: return new SpellMastery();
                case ClassFeats.SpellPenetration: return new SpellPenetration();
                case ClassFeats.SpiritedCharge: return new SpiritedCharge();
                case ClassFeats.SpringAttack: return new SpringAttack();
                case ClassFeats.Stealthy: return new Stealthy();
                case ClassFeats.StillSpell: return new StillSpell();
                case ClassFeats.StunningFist: return new StunningFist();
                case ClassFeats.Toughness: return new Toughness();
                case ClassFeats.TowerShieldProficiency: return new TowerShieldProficiency();
                case ClassFeats.Track: return new Track();
                case ClassFeats.Trample: return new Trample();
                case ClassFeats.TwoWeaponFighting: return new TwoWeaponFighting();
                case ClassFeats.WeaponFinesse: return new WeaponFinesse();
                case ClassFeats.WeaponFocus: return new WeaponFocus();
                case ClassFeats.WeaponSpecialization: return new WeaponSpecialization();
                case ClassFeats.WhirlwindAttack: return new WhirlwindAttack();
                case ClassFeats.WidenSpell: return new WidenSpell();
                default: return null;
            }
        }
    }
}
