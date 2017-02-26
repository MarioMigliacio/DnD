using System;
using System.Collections.Generic;

// NOTE THE NAMESPACE -- THESE BELONG IN DnD.Classes.Feats!
// if u create a new file in this folder it stupidely tries to attach on .AllOtherFeats, delete that, its just for organization purposes!
namespace DnD.Classes
{
    /// <summary>
    /// The Acrobatic Feat. This shit needs to be done wayyyyy down the pipe line. This is merely a simulation, in a simulation
    /// THATS IN A SIMULATION!!!!
    /// </summary>
    public class Acrobatic : BaseFeat
    {
        public override Dictionary<BaseCharacterClass, int> ClassLevelPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override List<Enum> FeatPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool MeetsPlayerStatPrerequisites
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
