using System;
using System.Collections.Generic;
using DnD.Classes.HeroFeats;
using DnD.Enums.ClassFeats;

namespace HeroMaker
{
    /// <summary>
    /// The Feats Form is responsible for managing this static object during its Run process.
    /// When it is finished Running, the Forms call Dispose() so to free up memory, in which
    /// case any thing within the form is lost. Except for static objects which were altered during run time.
    /// </summary>
    public static class PlayerFeats
    {
        /// <summary>
        /// A static property which can be called to save player Feats.
        /// </summary>
        public static List<BaseFeat> FeatsContainer { get; set; } = new List<BaseFeat>();

        /// <summary>
        /// A helper method used to populate the FeatsContainer with default feats.
        /// </summary>
        public static void PopulateContainer()
        {
            foreach (ClassFeats feat in Enum.GetValues(typeof (ClassFeats)))
            {
                if (FeatFactory.Create(feat) != null)
                {
                    FeatsContainer.Add(FeatFactory.Create(feat));
                }
            }
        }

        /// <summary>
        /// A helper method used to trim feats which have not been acquired.
        /// </summary>
        public static void TrimContainer()
        {
            List<BaseFeat> toRemove = new List<BaseFeat>();

            foreach (BaseFeat feat in FeatsContainer)
            {
                if (!feat.IsAcquired)
                {
                    toRemove.Add(feat);
                }
            }

            foreach (BaseFeat feat in toRemove)
            {
                FeatsContainer.Remove(feat);
            }
        }
    }
}
