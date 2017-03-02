using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                default: return null;
            }
        }
    }
}
