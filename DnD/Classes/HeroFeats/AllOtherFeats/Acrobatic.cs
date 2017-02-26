using System;
using System.Collections.Generic;
using DnD.Classes.CharacterClass;
using DnD.Classes.Player;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Acrobatic Feat.
    /// </summary>
    public class Acrobatic : BaseFeat
    {
        /// <summary>
        /// Returns a key value pair which corresponds to KEY = <see cref="BaseCharacterClass"/> and VALUE = the level of that KEY.
        /// Null if no required KEY/VALUE pair.
        /// </summary>
        public override Dictionary<BaseCharacterClass, int> ClassLevelPrerequisites => null;

        /// <summary>
        /// Returns the associated <see cref="UserStrings.FeatStrings"/> description tag for the particular feat in question.
        /// </summary>
        public override string Description => UserStrings.FeatStrings.Acrobatic;

        /// <summary>
        /// Returns the associated List of required <see cref="Enums.Feats.FeatType"/> that this particular feat requires.
        /// Null if no required <see cref="Enums.Feats.FeatType"/>.
        /// </summary>
        public override List<Enum> FeatPrerequisites => null;
        
        /// <summary>
        /// Returns the value of required base attack that this particular feat requires.
        /// </summary>
        public override int AttackBonusPrerequisites => 0;

        /// <summary>
        /// Returns true if the character meets the minimum required stat restriction for the talent, or false otherwise.
        /// </summary>
        public override bool MeetsPlayerStatPrerequisites(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}