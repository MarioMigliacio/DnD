using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGenerator
{
    public class SimpleMonster
    {
        public string Name { get; set; }
        public float Challenge { get; set; }
        public string MonsterType { get; set; }

        public SimpleMonster(string name, float cr, string type)
        {
            Name = name;
            Challenge = cr;
            MonsterType = type;
        }
    }
}
