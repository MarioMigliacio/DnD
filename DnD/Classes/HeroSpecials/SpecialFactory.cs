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
                default: return null;
            }
        }
    }
}
