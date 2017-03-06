using System.Collections.Generic;
using DnD.Enums.Stats;

namespace HeroMaker
{
    /// <summary>
    /// The Stats Form is responsible for managing this static object during its Run process.
    /// When it is finished Running, the Forms call Dispose() so to free up memory, in which
    /// case any thing within the form is lost. Except for static objects which were altered during run time.
    /// </summary>
    public static class PlayerStats
    {
        /// <summary>
        /// A static property which can be called to save player Stats.
        /// </summary>
        public static Dictionary<Stats, int> StatsContainer { get; set; } = new Dictionary<Stats, int>();
    }
}
