using DnD.Classes.CharacterClasses;
using DnD.Classes.Player;

namespace DnD.Classes.HeroFeats
{
    /// <summary>
    /// The Static Class responsible for checking if a particular feat can be acquired. Also responsible
    /// for the actual acquiring and boolean logic behind it.
    /// </summary>
    public static class FeatRequirementCheck
    {
        /// <summary>
        /// The CheckIfFeatCanBeAcquired method checks the Hero object and the Feats prerequisites.
        /// If they are compatible, the feats CanAcquire method is then set to true.
        /// </summary>
        /// <param name="theDude">The Hero player object to check against.</param>
        /// <param name="theFeat">The Feat object to check the prerequisites of.</param>
        public static void CheckIfFeatCanBeAcquired(Hero theDude, BaseFeat theFeat)
        {
            bool meetsFeatPrerequisites = false;
            bool meetsAttackPrerequisites = false;
            bool meetsClassLevelPrerequisites = false;
            bool meetsStatPrerequisites = false;

            if (theDude.BaseAttackBonus >= theFeat.AttackBonusPrerequisites)
            {
                meetsAttackPrerequisites = true;
            }

            if (theFeat.FeatPrerequisites == null)
            {
                meetsFeatPrerequisites = true;
            }
            else
            {
                foreach (BaseFeat feat in theFeat.FeatPrerequisites)
                {
                    if (theDude.PlayerFeats.Contains(feat))
                    {
                        meetsFeatPrerequisites = true;
                    }
                    else
                    {
                        meetsFeatPrerequisites = false;
                        break;
                    }
                }
            }

            if (theFeat.ClassLevelPrerequisites == null)
            {
                meetsClassLevelPrerequisites = true;
            }
            else
            {
                if ((theFeat.ClassLevelPrerequisites is Caster) &&
                    (theDude.TypeOfCharacter is Bard) ||
                    (theDude.TypeOfCharacter is Cleric) ||
                    (theDude.TypeOfCharacter is Druid) ||
                    (theDude.TypeOfCharacter is Sorcerer) ||
                    (theDude.TypeOfCharacter is Wizard))
                {
                    if (theDude.TypeOfCharacter.ClassLevel >= theFeat.ClassLevelPrerequisites.ClassLevel)
                    {
                        meetsClassLevelPrerequisites = true;
                    }
                    else
                    {
                        meetsClassLevelPrerequisites = false;
                    }
                }

                else if (theDude.TypeOfCharacter == theFeat.ClassLevelPrerequisites)
                {
                    meetsClassLevelPrerequisites = true;
                }
            }

            if (theFeat.MinimumRequiredStat == null)
            {
                meetsStatPrerequisites = true;
            }
            else
            {
                foreach (var stat in theFeat.MinimumRequiredStat)
                {
                    if (theDude.PlayerStats.ContainsKey(stat.Key) && theDude.PlayerStats[stat.Key] >= theFeat.MinimumRequiredStat[stat.Key])
                    {
                        meetsStatPrerequisites = true;
                    }
                    else
                    {
                        meetsStatPrerequisites = false;
                        break;
                    }
                }
            }

            if (meetsAttackPrerequisites && meetsClassLevelPrerequisites
                && meetsFeatPrerequisites && meetsStatPrerequisites)
            {
                theFeat.CanAcquire = true;
            }

            else
            {
                theFeat.CanAcquire = false;
            }
        }

        /// <summary>
        /// Toggles the IsAcquired boolean logic of the BaseFeat passed in to true.
        /// </summary>
        /// <param name="theFeat">The Feat to change the IsAcquired Property of.</param>
        public static void AcquireTheFeat(BaseFeat theFeat)
        {
            if (theFeat.CanAcquire)
            {
                theFeat.IsAcquired = true;
            }
        }

        /// <summary>
        /// Toggles the IsAcquired boolean logic of the BaseFeat passed in to false.
        /// </summary>
        /// <param name="theFeat">The Feat to change the IsAcquired Property of.</param>
        public static void RemoveTheFeat(BaseFeat theFeat)
        {
            if (theFeat.IsAcquired)
            {
                theFeat.IsAcquired = false;
            }
        }
    }
}
