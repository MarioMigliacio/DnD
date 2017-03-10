using DnD.Classes.CharacterClasses;
using DnD.Enums.Stats;
using System.Collections.Generic;
using System.Text;
using DnD.Enums.ClassFeats;
using Newtonsoft.Json;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Base Feat class is an abstract entity which satisfies the required generic prerequisites for any type of feat.
    /// Whether it be a list of Feat type enums, Particular character class levels, or minimum stat requirements.
    /// Also supports a description of the feat.
    /// </summary>
    public abstract class BaseFeat
    {
        /// <summary>
        /// Returns the value of required base attack that this particular feat requires.
        /// </summary>
        [JsonIgnore]
        public abstract int AttackBonusPrerequisites { get; }

        /// <summary>
        /// Returns the associated List of required feats that this particular feat requires.
        /// Null if no required feat.
        /// </summary>
        [JsonIgnore]
        public abstract List<BaseFeat> FeatPrerequisites { get; }

        /// <summary>
        /// Returns a Class type with a Level if there is a required Class restriction on this feat.
        /// </summary>
        [JsonIgnore]
        public abstract BaseCharacterClass ClassLevelPrerequisites { get; }

        /// <summary>
        /// Returns a dictionary where KEY represents the required stat and VALUE = the value of that stat.
        /// </summary>
        [JsonIgnore]
        public abstract Dictionary<Stats, int> MinimumRequiredStat { get; }

        /// <summary>
        /// The associated Description tag for the string, found within the respective UserStrings files.
        /// </summary>
        [JsonIgnore]
        public abstract string Description { get; }

        /// <summary>
        /// Returns the enumeration type of Feat this particular Feat represents.
        /// </summary>
        public abstract ClassFeats FeatType { get; }

        /// <summary>
        /// Returns whether or not the Feat can be Acquired.
        /// </summary>
        [JsonIgnore]
        public bool CanAcquire { get; set; } = false;

        /// <summary>
        /// Returns whether or not the Feat has been Acquired.
        /// </summary>
        [JsonIgnore]
        public bool IsAcquired { get; set; } = false;

        /// <summary>
        /// In the event we need to look at the details of the requirements for the Feat, this method returns the appropriate string.
        /// </summary>
        /// <returns>The string description of what is a requirement for the Feat.</returns>
        public string RequirementsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Base Attack Bonus: " + AttackBonusPrerequisites + ".");

            if (FeatPrerequisites != null)
            {
                foreach (BaseFeat bf in FeatPrerequisites)
                {
                    sb.AppendLine("Requires Feat: " + bf.FeatType + ".");
                }
            }
            else
            {
                sb.AppendLine("No required Feats.");
            }

            if (ClassLevelPrerequisites != null)
            {
                sb.AppendLine("Requires a " + ClassLevelPrerequisites.CharacterClassType + " Level of: " +
                              ClassLevelPrerequisites.ClassLevel + ".");
            }
            else
            {
                sb.AppendLine("No required levels.");
            }

            if (MinimumRequiredStat != null)
            {
                foreach (var item in  MinimumRequiredStat)
                {
                    sb.AppendLine("Requires " + item.Value + " " + item.Key + ".");
                }
            }
            else
            {
                sb.AppendLine("No required stats.");
            }

            return sb.ToString();
        }
    }
}
