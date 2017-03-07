﻿using HeroMaker.Enums;
using System.Windows.Forms;
using HeroMaker.Forms;

namespace HeroMaker
{
    /// <summary>
    /// The FormControl object is a device which is responsible for the management of GameStates.
    /// The flow of character creation is handled by this object.
    /// </summary>
    public static class FormControl
    {
        /// <summary>
        /// The GameState enumeration which is handled by this object.
        /// </summary>
        public static GameState GS { get; set; }
        
        /// <summary>
        /// Returns which Form object should be run, based on the current GameState enumeration.
        /// </summary>
        public static Form RunForm()
        {
            switch (GS)
            {
                case GameState.Init: return new Init();
                case GameState.RaceAndClass: return new RaceAndClass();
                case GameState.Stat: return new Stat();
                case GameState.Skill: return new Skill();
                default: return null;
            }
        }

        /// <summary>
        /// After running a Form, the NextGameState is called to change states.
        /// </summary>
        /// <returns></returns>
        public static GameState GetNextState()
        {
            switch (GS)
            {
                case GameState.Init: return GameState.RaceAndClass;
                case GameState.RaceAndClass: return GameState.Stat;
                case GameState.Stat: return GameState.Skill;
                case GameState.Skill: return GameState.Feat;
                case GameState.Feat: return GameState.Final;
                case GameState.Detail: return GameState.Detail;
                case GameState.Final: return GameState.Final;
                default: return GameState.Init;
            }
        }
    }
}
