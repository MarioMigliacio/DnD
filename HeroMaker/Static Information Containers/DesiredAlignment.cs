using DnD.Enums.Alignment;

namespace HeroMaker
{
    /// <summary>
    /// The RaceAndClass Form is responsible for managing this static object during its Run process.
    /// When it is finished Running, the Forms call Dispose() so to free up memory, in which
    /// case any thing within the form is lost. Except for static objects which were altered during run time.
    /// </summary>
    public static class DesiredAlignment
    {
        /// <summary>
        /// A static property which can be called to save player Race preferences.
        /// </summary>
        public static Alignment DesiredAlign { get; set; } = Alignment.None;
    }
}
