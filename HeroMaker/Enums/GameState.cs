using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker.Enums
{
    /// <summary>
    /// GameState enumeration type to control which type of form we need to transition into.
    /// </summary>
    public enum GameState
    {
        /// <summary>
        /// The beginning form should be displayed.
        /// </summary>
        Init,

        /// <summary>
        /// The Race and Class form should be displayed.
        /// </summary>
        RaceAndClass,

        /// <summary>
        /// The Stat selection form should be displayed.
        /// </summary>
        Stat,

        /// <summary>
        /// The Skill selection form should be displayed.
        /// </summary>
        Skill,

        /// <summary>
        /// The Feat selection form should be displayed.
        /// </summary>
        Feat,

        /// <summary>
        /// The Last form should be displayed.
        /// </summary>
        Final
    }
}
