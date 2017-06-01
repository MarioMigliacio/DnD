using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DnD.Classes.HeroFeats;
using DnD.Classes.HeroSkills;
using DnD.Enums.Alignment;
using DnD.Enums.ClassTypes;
using DnD.Enums.Races;
using DnD.Enums.Stats;
using HeroMaker.Enums;
using DnD.Enums.ClassSpecials;
using DnD.Enums.ClassSkills;
using DnD.Enums.ClassFeats;
using DnD.Classes.Player;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The Details form. We use this form to show all the information gathered about the hero.
    /// </summary>
    public partial class Detail : Form
    {
        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Detail()
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();
            
            playerGenderTextBox.Text = PlayerNameAndGender.Gender;
            playerNameTextBox.Text = PlayerNameAndGender.Name;
            playerClassTextBox.Text = DesiredClassType.DesiredClass.ToString();
            playerRaceTextBox.Text = DesiredRaceType.DesiredRace.ToString();

            // Since these complex entities are formed from abstract bases, JSON doesnt know how to make them. It does however,
            // Understand how to use lists of enumerations thankfully. So we can populate the actual Hero fields later.
            Player.GetHero.HeroesSpecials = new List<ClassSpecial>();
            Player.GetHero.HeroesFeats = new List<ClassFeats>();
            Player.GetHero.HeroesSkills = new Dictionary<ClassSkills, int>();
            
            foreach (var item in PlayerStats.StatsContainer)
            {
                sb.AppendLine(item.Key + " : " + item.Value);
            }

            playerStatsTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in PlayerSkills.SkillsContainer)
            {
                Player.GetHero.HeroesSkills.Add(item.SkillType, item.NumberOfRanks);

                sb.AppendLine(item.SkillType + " : " + item.NumberOfRanks);
            }

            playerSkillTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in PlayerFeats.FeatsContainer)
            {
                Player.GetHero.HeroesFeats.Add(item.FeatType);

                sb.AppendLine(item.FeatType.ToString());
            }

            playerFeatTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in Player.GetHero.PlayerSpecials)
            {
                Player.GetHero.HeroesSpecials.Add(item.SpecialType);

                sb.AppendLine(item.SpecialType.ToString());
            }

            playerSpecialTextBox.Text = sb.ToString();
            
            Player.GetHero.PlayerFeats = PlayerFeats.FeatsContainer;
            Player.GetHero.PlayerSkills = PlayerSkills.SkillsContainer;
            Player.GetHero.Name = PlayerNameAndGender.Name;
            Player.GetHero.Gender = PlayerNameAndGender.Gender;

            // only Non-lawful for these guys.
            if (Player.GetHero.CharacterClassType == ClassType.Barbarian || Player.GetHero.CharacterClassType == ClassType.Bard)
            {
                lawfulEvilToolStripMenuItem.Visible = false;
                lawfulGoodToolStripMenuItem.Visible = false;
                lawfulNeutralToolStripMenuItem.Visible = false;
            }

            // Your Neutralness!
            if (Player.GetHero.CharacterClassType == ClassType.Druid)
            {
                lawfulEvilToolStripMenuItem.Visible = false;
                lawfulGoodToolStripMenuItem.Visible = false;
                evilToolStripMenuItem.Visible = false;
                goodToolStripMenuItem.Visible = false;
                chaoticEvilToolStripMenuItem.Visible = false;
                chaoticGoodToolStripMenuItem.Visible = false;
            }

            // only lawful for monks!
            if (Player.GetHero.CharacterClassType == ClassType.Monk)
            {
                chaoticEvilToolStripMenuItem.Visible = false;
                chaoticGoodToolStripMenuItem.Visible = false;
                chaoticNeutralToolStripMenuItem.Visible = false;
                goodToolStripMenuItem.Visible = false;
                neutralToolStripMenuItem.Visible = false;
                evilToolStripMenuItem.Visible = false;
            }

            // only lawful good for paladins! strict diet! yeeesh.
            if (Player.GetHero.CharacterClassType == ClassType.Paladin)
            {
                chaoticEvilToolStripMenuItem.Visible = false;
                chaoticGoodToolStripMenuItem.Visible = false;
                chaoticNeutralToolStripMenuItem.Visible = false;
                goodToolStripMenuItem.Visible = false;
                neutralToolStripMenuItem.Visible = false;
                evilToolStripMenuItem.Visible = false;
                lawfulEvilToolStripMenuItem.Visible = false;
                lawfulNeutralToolStripMenuItem.Visible = false;
            }
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }

        /// <summary>
        /// When we are ready to move on to saving the hero, the button click signals the FormControl object to change states.
        /// </summary>
        private void saveStateButton_Click(object sender, EventArgs e)
        {
            Player.GetHero.PlayerAlignment = DesiredAlignment.DesiredAlign;
            SaveLoadInfo.Serialize(Player.GetHero);
            FormControl.Gs = FormControl.GetNextState();
            this.Dispose();
        }

        /// <summary>
        /// Seriously, sometimes RNG just isnt on your side and you wanna start again with another chance.
        /// </summary>
        private void rerunButton_Click(object sender, EventArgs e)
        {
            Player.GetHero = null;
            DesiredAlignment.DesiredAlign = Alignment.None;
            DesiredClassType.DesiredClass = ClassType.None;
            DesiredRaceType.DesiredRace = RaceType.None;
            PlayerFeats.FeatsContainer = new List<BaseFeat>();
            PlayerSkills.SkillsContainer = new List<BaseSkill>();
            PlayerStats.StatsContainer = new Dictionary<Stats, int>();
            PlayerNameAndGender.Gender = null;
            PlayerNameAndGender.Name = null;
            FormControl.Gs = GameState.Init;
            this.Dispose();
        }

        #endregion

        #region Menu Strip Events

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void chaoticEvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.ChaoticEvil.ToString();
            DesiredAlignment.DesiredAlign = Alignment.ChaoticEvil;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void chaoticNeutralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.ChaoticNeutral.ToString();
            DesiredAlignment.DesiredAlign = Alignment.ChaoticNeutral;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void chaoticGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.ChaoticGood.ToString();
            DesiredAlignment.DesiredAlign = Alignment.ChaoticGood;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void evilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.Evil.ToString();
            DesiredAlignment.DesiredAlign = Alignment.Evil;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void neutralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.Neutral.ToString();
            DesiredAlignment.DesiredAlign = Alignment.Neutral;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void goodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.Good.ToString();
            DesiredAlignment.DesiredAlign = Alignment.Good;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void lawfulEvilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.LawfulEvil.ToString();
            DesiredAlignment.DesiredAlign = Alignment.LawfulEvil;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void lawfulNeutralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.LawfulNeutral.ToString();
            DesiredAlignment.DesiredAlign = Alignment.LawfulNeutral;
            saveStateButton.Enabled = true;
        }

        /// <summary>
        /// When the user clicks to change the Alignment for their hero this event is fired.
        /// </summary>
        private void lawfulGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputYourHeroAlignmentToolStripMenuItem.Text = Alignment.LawfulGood.ToString();
            DesiredAlignment.DesiredAlign = Alignment.LawfulGood;
            saveStateButton.Enabled = true;
        }

        #endregion
    }
}
