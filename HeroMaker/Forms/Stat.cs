using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DnD.Dice;
using DnD.Enums.Stats;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The Stat form. We use this form to gather information about hero's rolled Stat attributes.
    /// </summary>
    public partial class Stat : Form
    {
        private bool _canRerollStats = true;
        private int _rerollsRemaining = 3;

        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Stat()
        {
            InitializeComponent();
            rerollCountTextBox.Text = _rerollsRemaining.ToString();
        }

        /// <summary>
        /// When we are ready to move on to the next form, the button click signals the FormControl object to change states.
        /// </summary>
        private void NextState_Click(object sender, EventArgs e)
        {
            FormControl.GS = FormControl.GetNextState();
            this.Dispose();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Stat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.GS = GameState.Final;
            this.Dispose();
        }


        #endregion

        #region Button Helper Functions

        /// <summary>
        /// ButtonsOn is a helper function that manages the state of lock in buttons and rerolling buttons.
        /// </summary>
        private void ButtonsOn()
        {
            rerollLastRollButton.Enabled = _rerollsRemaining > 0;
            charismaLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Charisma);
            constitutionLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Constitution);
            dexterityLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Dexterity);
            intellectLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Intellect);
            strengthLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Strength);
            wisdomLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Wisdom);
            rerollAllStatsButton.Enabled = PlayerStats.StatsContainer.Count == 6 && _canRerollStats;
            saveChangesButton.Enabled = PlayerStats.StatsContainer.Count == 6;
        }

        /// <summary>
        /// ButtonsOff is a helper function that manages the state of lock in buttons.
        /// </summary>
        private void ButtonsOff()
        {
            charismaLockInButton.Enabled = false;
            constitutionLockInButton.Enabled = false;
            dexterityLockInButton.Enabled = false;
            intellectLockInButton.Enabled = false;
            strengthLockInButton.Enabled = false;
            wisdomLockInButton.Enabled = false;
            rerollLastRollButton.Enabled = false;
            saveChangesButton.Enabled = PlayerStats.StatsContainer.Count == 6;
            rollStatButton.Enabled = PlayerStats.StatsContainer.Count != 6;
            rerollAllStatsButton.Enabled = PlayerStats.StatsContainer.Count == 6 && _canRerollStats;
        }

        #endregion

        #region Clicking Roll/Reroll Button Events

        /// <summary>
        /// Generates a set of Dice rolls and determines the best 3 of 4 sum. This value can then be used to set the character stat dictionary,
        /// or be rerolled.
        /// </summary>
        private void rollStatButton_Click(object sender, EventArgs e)
        {
            if (!rollStatButton.Enabled)
            {
                return;
            }

            currentDiceRollTextBox.Clear();
            statRerollTextBox.Clear();

            List<int> storage = new List<int>();
            storage.Add(Dice.D6);
            storage.Add(Dice.D6);
            storage.Add(Dice.D6);
            storage.Add(Dice.D6);
            storage.Sort();

            int sum = storage[3] + storage[2] + storage[1];
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Roll1: " + storage[0]);
            sb.AppendLine("Roll2: " + storage[1]);
            sb.AppendLine("Roll3: " + storage[2]);
            sb.AppendLine("Roll4: " + storage[3]);
            sb.AppendLine("Highest total: " + sum);

            statRerollTextBox.Text = sb.ToString();
            currentDiceRollTextBox.Text = sum.ToString();

            rollStatButton.Enabled = false;
            ButtonsOn();
        }

        /// <summary>
        /// Allows the user to attempt to roll again rather than being forced to lock in the dice set rolls. Only available for use THREE times.
        /// </summary>
        private void rerollLastRollButton_Click(object sender, EventArgs e)
        {
            if (_rerollsRemaining == 0)
            {
                return;
            }

            currentDiceRollTextBox.Clear();
            statRerollTextBox.Clear();
            _rerollsRemaining--;
            rerollCountTextBox.Text = _rerollsRemaining.ToString();
            rollStatButton.Enabled = true;

            ButtonsOff();
        }

        /// <summary>
        /// Allows the user to reroll all character stats with this button click. Only available for use ONE time.
        /// </summary>
        private void rerollAllStatsButton_Click(object sender, EventArgs e)
        {
            if (_canRerollStats)
            {
                PlayerStats.StatsContainer.Clear();
                _rerollsRemaining = 3;
                rollStatButton.Enabled = true;
                rerollLastRollButton.Enabled = false;
                _canRerollStats = false;

                charismaValueTextBox.Clear();
                constitutionValueTextBox.Clear();
                dexterityValueTextBox.Clear();
                intellectValueTextBox.Clear();
                strengthValueTextBox.Clear();
                wisdomValueTextBox.Clear();
                rerollCountTextBox.Text = _rerollsRemaining.ToString();
                statRerollTextBox.Clear();
                currentDiceRollTextBox.Clear();
            }
        }

        #endregion

        #region Lock in Stat Button Events

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Charisma value = the Dice set roll.
        /// </summary>
        private void charismaLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Charisma, int.Parse(currentDiceRollTextBox.Text));
            charismaValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }
        
        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Constitution value = the Dice set roll.
        /// </summary>
        private void constitutionLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Constitution, int.Parse(currentDiceRollTextBox.Text));
            constitutionValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Dexterity value = the Dice set roll.
        /// </summary>
        private void dexterityLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Dexterity, int.Parse(currentDiceRollTextBox.Text));
            dexterityValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Intellect value = the Dice set roll.
        /// </summary>
        private void intellectLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Intellect, int.Parse(currentDiceRollTextBox.Text));
            intellectValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Strength value = the Dice set roll.
        /// </summary>
        private void strengthLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Strength, int.Parse(currentDiceRollTextBox.Text));
            strengthValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Wisdom value = the Dice set roll.
        /// </summary>
        private void wisdomLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Wisdom, int.Parse(currentDiceRollTextBox.Text));
            wisdomValueTextBox.Text = currentDiceRollTextBox.Text;
            rollStatButton.Enabled = true;
            ButtonsOff();
        }

        #endregion
    }
}
