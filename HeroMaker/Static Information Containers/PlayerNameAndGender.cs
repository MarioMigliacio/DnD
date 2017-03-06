namespace HeroMaker
{
    /// <summary>
    /// The PlayerNameAndGender Form is responsible for managing this static object during its Run process.
    /// When it is finished Running, the Forms call Dispose() so to free up memory, in which
    /// case any thing within the form is lost. Except for static objects which were altered during run time.
    /// </summary>
    public static class PlayerNameAndGender
    {
        /// <summary>
        /// A static property which can be called to save player Name preferences.
        /// </summary>
        public static string Name { get; set; } = null;

        /// <summary>
        /// A static property which can be called to save player Gender preferences.
        /// </summary>
        public static string Gender { get; set; } = null;
    }
}
