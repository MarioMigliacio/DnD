using DnD.Classes.Player;

namespace HeroMaker
{
    /// <summary>
    /// We only want to make one Hero during the runtime of the forms applications because creating
    /// the hero alters the stats and doing the same call on the statics can start making unpredictable results.
    /// </summary>
    public static class Player
    {
        public static Hero GetHero { get; set; }
    }
}
