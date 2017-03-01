using DnD.Enums.ClassSpecials;

namespace DnD.Classes.HeroSpecials
{
    /// <summary>
    /// A useful factory tool which needs not be constructed. Simply pass in the Enum which corresponds to a special, 
    /// and receive that special as a new object.
    /// </summary>
    public static class SpecialFactory
    {
        /// <summary>
        /// The design pattern of the Factory. Creates a new special and returns it to the caller.
        /// </summary>
        /// <param name="which">Represents the <see cref="ClassSpecial"/>enum.</param>
        /// <returns>The particular Special object which is represented by that enum.</returns>
        public static BaseSpecial Create(ClassSpecial which)
        {
            switch (which)
            {
                case ClassSpecial.AbundantStep: return new AbundantStep();
                case ClassSpecial.AnimalCompanion: return new AnimalCompanion();
                case ClassSpecial.AuraOfCourage: return new AuraOfCourage();
                case ClassSpecial.AuraOfGood: return new AuraOfGood();
                case ClassSpecial.BardicKnowledge: return new BardicKnowledge();
                case ClassSpecial.BardicMusic: return new BardicMusic();
                case ClassSpecial.BonusFeat: return new BonusFeat();
                case ClassSpecial.Camouflage: return new Camouflage();
                case ClassSpecial.CombatStyle: return new CombatStyle();
                case ClassSpecial.CombatStyleMastery: return new CombatStyleMastery();
                case ClassSpecial.CounterSong: return new CounterSong();
                case ClassSpecial.CripplingStrike: return new CripplingStrike();
                case ClassSpecial.DamageReduction: return new DamageReduction();
                case ClassSpecial.DefensiveRoll: return new DefensiveRoll();
                case ClassSpecial.DetectEvil: return new DetectEvil();
                case ClassSpecial.DiamondBody: return new DiamondBody();
                case ClassSpecial.DiamondSoul: return new DiamondSoul();
                case ClassSpecial.DivineGrace: return new DivineGrace();
                case ClassSpecial.DivineHealth: return new DivineHealth();
                case ClassSpecial.EmptyBody: return new EmptyBody();
                case ClassSpecial.Endurance: return new Endurance();
                case ClassSpecial.Evasion: return new Evasion();
                case ClassSpecial.Fascinate: return new Fascinate();
                case ClassSpecial.FastMovement: return new FastMovement();
                case ClassSpecial.FavoredEnemy: return new FavoredEnemy();
                case ClassSpecial.FlurryOfBlows: return new FlurryOfBlows();
                case ClassSpecial.GreaterFlurry: return new GreaterFlurry();
                case ClassSpecial.GreaterRage: return new GreaterRage();
                case ClassSpecial.HideInPlainSight: return new HideInPlainSight();
                case ClassSpecial.Illiteracy: return new Illiteracy();
                case ClassSpecial.ImprovedCombatStyle: return new ImprovedCombatStyle();
                case ClassSpecial.ImprovedEvasion: return new ImprovedEvasion();
                case ClassSpecial.ImprovedUncannyDodge: return new ImprovedUncannyDodge();
                case ClassSpecial.IndomitableWill: return new IndomitableWill();
                case ClassSpecial.InspireCompetence: return new InspireCompetence();
                case ClassSpecial.InspireCourage: return new InspireCourage();
                case ClassSpecial.InspireGreatness: return new InspireGreatness();
                case ClassSpecial.InspireHeroics: return new InspireHeroics();
                case ClassSpecial.KiStrike: return new KiStrike();
                case ClassSpecial.LayOnHands: return new LayOnHands();
                case ClassSpecial.MassSuggestion: return new MassSuggestion();
                case ClassSpecial.MightyRage: return new MightyRage();
                case ClassSpecial.NatureSense: return new NatureSense();
                case ClassSpecial.Opportunist: return new Opportunist();
                case ClassSpecial.PerfectSelf: return new PerfectSelf();
                case ClassSpecial.PurityOfBody: return new PurityOfBody();
                case ClassSpecial.QuiveringPalm: return new QuiveringPalm();
                case ClassSpecial.Rage: return new Rage();
                case ClassSpecial.RemoveDisease: return new RemoveDisease();
                case ClassSpecial.ResistNaturesLure: return new ResistNaturesLure();
                case ClassSpecial.ScribeScroll: return new ScribeScroll();
                case ClassSpecial.SkillMastery: return new SkillMastery();
                case ClassSpecial.SlipperyMind: return new SlipperyMind();
                case ClassSpecial.SlowFall: return new SlowFall();
                case ClassSpecial.SmiteEvil: return new SmiteEvil();
                case ClassSpecial.SneakAttack: return new SneakAttack();
                case ClassSpecial.SongOfFreedom: return new SongOfFreedom();
                case ClassSpecial.SpecialMount: return new SpecialMount();
                case ClassSpecial.StillMind: return new StillMind();
                case ClassSpecial.Suggestion: return new Suggestion();
                case ClassSpecial.SummonFamiliar: return new SummonFamiliar();
                case ClassSpecial.SwiftTracker: return new SwiftTracker();
                case ClassSpecial.ThousandFaces: return new ThousandFaces();
                case ClassSpecial.TimelessBody: return new TimelessBody();
                case ClassSpecial.TirelessRage: return new TirelessRage();
                case ClassSpecial.TongueOfTheSunAndMoon: return new TongueOfTheSunAndMoon();
                case ClassSpecial.Track: return new Track();
                case ClassSpecial.TracklessStep: return new TracklessStep();
                case ClassSpecial.TrapFinding: return new TrapFinding();
                case ClassSpecial.TrapSense: return new TrapSense();
                case ClassSpecial.TurnOrRebukeUndead: return new TurnOrRebukeUndead();
                case ClassSpecial.TurnUndead: return new TurnUndead();
                case ClassSpecial.UnarmedStrike: return new UnarmedStrike();
                case ClassSpecial.UncannyDodge: return new UncannyDodge();
                case ClassSpecial.VenomImmunity: return new VenomImmunity();
                case ClassSpecial.WholenessOfBody: return new WholenessOfBody();
                case ClassSpecial.WildEmpathy: return new WildEmpathy();
                case ClassSpecial.WildShape: return new WildShape();
                case ClassSpecial.WoodlandStride: return new WoodlandStride();
                default: return null;
            }
        }
    }
}
