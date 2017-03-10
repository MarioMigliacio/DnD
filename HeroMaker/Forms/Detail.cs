using System;
using System.Text;
using System.Windows.Forms;
using HeroMaker.Enums;

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
            
            foreach (var item in PlayerStats.StatsContainer)
            {
                sb.AppendLine(item.Key + " : " + item.Value);
            }

            playerStatsTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in PlayerSkills.SkillsContainer)
            {
                sb.AppendLine(item.SkillType + " : " + item.NumberOfRanks);
            }

            playerSkillTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in PlayerFeats.FeatsContainer)
            {
                sb.AppendLine(item.FeatType.ToString());
            }

            playerFeatTextBox.Text = sb.ToString();

            sb.Clear();

            foreach (var item in Player.GetHero.PlayerSpecials)
            {
                sb.AppendLine(item.SpecialType.ToString());
            }

            playerSpecialTextBox.Text = sb.ToString();
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
            FormControl.Gs = FormControl.GetNextState();
            this.Dispose();
        }

        #endregion
    }
}
