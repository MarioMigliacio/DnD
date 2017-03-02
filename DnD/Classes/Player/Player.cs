using System.Collections.Generic;
using DnD.Classes.HeroFeats;
using DnD.Classes.HeroSkills;
using DnD.Classes.HeroSpecials;
using DnD.Enums.Stats;

namespace DnD.Classes.Player
{
    /// <summary>
    /// Represents the main player character that is to be created and utilized.
    /// </summary>
    public class Hero
    {
        public int Level { get; set; }
        public List<BaseSkill> PlayerSkills { get; }
        public List<BaseSpecial> PlayerSpecials { get; } 
        public List<BaseFeat> PlayerFeats { get; } 
        public Dictionary<Stats, int> PlayerStats { get; }
        public int SkillCap => Level + 3;

        public Hero()
        {
            PlayerSkills = new List<BaseSkill>();
            PlayerSpecials = new List<BaseSpecial>();
            PlayerFeats = new List<BaseFeat>();
            PlayerStats = new Dictionary<Stats, int>();
        }
    }
}
