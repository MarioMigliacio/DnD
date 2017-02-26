using System;
using System.Collections.Generic;
using DnD.Classes.CharacterClass;

// NOTE THE NAMESPACE -- THESE BELONG IN DnD.Classes.Feats!
// if u create a new file in this folder it stupidely tries to attach on .AllOtherFeats, delete that, its just for organization purposes!
namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Acrobatic Feat. This shit needs to be done wayyyyy down the pipe line. This is merely a simulation, in a simulation
    /// THATS IN A SIMULATION!!!!
    /// </summary>
    public class Acrobatic : BaseFeat
    {
        /// <summary>
        /// Returns a key value pair which corresponds to KEY = <see cref="BaseCharacterClass"/> and VALUE = the level of that KEY.
        /// Null if no required KEY/VALUE pair.
        /// </summary>
        public override Dictionary<BaseCharacterClass, int> ClassLevelPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for the particular feat in question.
        /// </summary>
        public override string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the associated List of required <see cref="Enums.Feats.FeatType"/> that this particular feat requires.
        /// Null if no required <see cref="DnD.Enums.Feats.FeatType"/>.
        /// </summary>
        public override List<Enum> FeatPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns true if the character meets the minimum required stat restriction for the talent, or false otherwise.
        /// </summary>
        public override bool MeetsPlayerStatPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
