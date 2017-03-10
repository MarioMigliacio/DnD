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
        private Queue<int> _diceRolls;
        private int _rerollsRemaining = 3;

        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Stat()
        {
            InitializeComponent();
            rerollCountTextBox.Text = _rerollsRemaining.ToString();
            _diceRolls = new Queue<int>();
        }

        /// <summary>
        /// When we are ready to move on to the next form, the button click signals the FormControl object to change states.
        /// </summary>
        private void NextState_Click(object sender, EventArgs e)
        {
            FormControl.Gs = FormControl.GetNextState();
            this.Dispose();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Stat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }
        
        #endregion

        #region Button Helper Functions

        /// <summary>
        /// ButtonsOn is a helper function that manages the state of lock in buttons and rerolling buttons.
        /// </summary>
        private void ButtonsOn()
        {
            charismaLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Charisma);
            constitutionLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Constitution);
            dexterityLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Dexterity);
            intellectLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Intellect);
            strengthLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Strength);
            wisdomLockInButton.Enabled = !PlayerStats.StatsContainer.ContainsKey(Stats.Wisdom);
            saveChangesButton.Enabled = PlayerStats.StatsContainer.Count == 6;
            rerollAllStatsButton.Enabled = _rerollsRemaining > 0;
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
            rerollAllStatsButton.Enabled = false;
            saveChangesButton.Enabled = false;
            rollStatButton.Enabled = true;
        }

        #endregion

        #region Clicking Roll/Reroll Button Events

        /// <summary>
        /// Generates a set of Dice rolls and determines the best 3 of 4 sum. This value can then be used to set the character stat dictionary,
        /// or be rerolled.
        /// </summary>
        private void rollStatButton_Click(object sender, EventArgs e)
        {
            currentDiceRollTextBox.Clear();
            statRollsTextBox.Clear();

            List<int> storage = new List<int>();
            StringBuilder sb = new StringBuilder();
            int sum = 0;

            sb.AppendLine("You rolled 6 sets of Dice, Your values are as follows:");

            for (int i = 1; i <= 6; i++)
            {
                storage.Clear();
                storage.Add(Dice.D6);
                storage.Add(Dice.D6);
                storage.Add(Dice.D6);
                storage.Add(Dice.D6);
                storage.Sort();
                sum = storage[3] + storage[2] + storage[1];
                sb.AppendLine("Roll" + i + ": " + sum);

                _diceRolls.Enqueue(sum);
            }
            
            
            statRollsTextBox.Text = sb.ToString();
            currentDiceRollTextBox.Text = _diceRolls.Peek().ToString();

            rollStatButton.Enabled = false;
            ButtonsOn();
        }
        
        /// <summary>
        /// When the user hates RNG and wishes to try again, fire this event!
        /// </summary>
        private void rerollAllStatsButton_Click(object sender, EventArgs e)
        {
            _rerollsRemaining--;
            rerollCountTextBox.Text = _rerollsRemaining.ToString();

            _diceRolls = new Queue<int>();
            PlayerStats.StatsContainer = new Dictionary<Stats, int>();

            charismaValueTextBox.Clear();
            constitutionValueTextBox.Clear();
            dexterityValueTextBox.Clear();
            intellectValueTextBox.Clear();
            strengthValueTextBox.Clear();
            wisdomValueTextBox.Clear();
            currentDiceRollTextBox.Clear();
            statRollsTextBox.Clear();

            ButtonsOff();
        }

        #endregion

        #region Lock in Stat Button Events

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Charisma value = the Dice set roll.
        /// </summary>
        private void charismaLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Charisma, _diceRolls.Peek());
            charismaValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }
        
        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Constitution value = the Dice set roll.
        /// </summary>
        private void constitutionLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Constitution, _diceRolls.Peek());
            constitutionValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Dexterity value = the Dice set roll.
        /// </summary>
        private void dexterityLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Dexterity, _diceRolls.Peek());
            dexterityValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Intellect value = the Dice set roll.
        /// </summary>
        private void intellectLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Intellect, _diceRolls.Peek());
            intellectValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Strength value = the Dice set roll.
        /// </summary>
        private void strengthLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Strength, _diceRolls.Peek());
            strengthValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }

        /// <summary>
        /// Populates the Static Player Dictionary of Stats with a Wisdom value = the Dice set roll.
        /// </summary>
        private void wisdomLockInButton_Click(object sender, EventArgs e)
        {
            PlayerStats.StatsContainer.Add(Stats.Wisdom, _diceRolls.Peek());
            wisdomValueTextBox.Text = _diceRolls.Dequeue().ToString();
            currentDiceRollTextBox.Text = _diceRolls.Count > 0 ? _diceRolls.Peek().ToString() : null;
            ButtonsOn();
        }

        #endregion
    }
}
