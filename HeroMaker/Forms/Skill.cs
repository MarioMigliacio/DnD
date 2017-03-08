using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DnD.Classes.HeroSkills;
using DnD.Classes.Player;
using DnD.Enums.ClassSkills;
using DnD.Enums.ClassTypes;
using DnD.Enums.Races;
using DnD.Enums.Stats;
using DnD.UserStrings;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The Skills form. We use this form to gather information about hero's desired skillset.
    /// </summary>
    public partial class Skill : Form
    {
        private readonly Hero _thusFar;
        private bool _canAdd = false;
        private bool _canRemove = false;
        private int _skillsRemaining;

        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Skill()
        {
            InitializeComponent();
            PlayerSkills.PopulateContainer();

            _thusFar = Hero.GetStageTwoHero(DesiredClassType.DesiredClass, DesiredRaceType.DesiredRace, PlayerStats.StatsContainer);
            _skillsRemaining = _thusFar.SkillRanksAvailable;
            skillCountTextBox.Text = _skillsRemaining.ToString();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Skill_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }
        
        /// <summary>
        /// When we are ready to move on to the next form, the button click signals the FormControl object to change states.
        /// </summary>
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            PlayerSkills.TrimContainer();
            FormControl.Gs = FormControl.GetNextState();
            this.Dispose();
        }

        #endregion

        #region Menu Item Click Event

        /// <summary>
        /// Event fired when the user clicks on a comboBox item. It gets the currently set rank of the skill pulled down from the menu.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox) sender;
            string selectedSkill = (string)skillsMenuBox.SelectedItem;
            int index = cb.FindStringExact(selectedSkill);

            rankCountTextBox.Clear();

            switch ((ClassSkills)index)
            {
                case ClassSkills.Appraise:
                    descriptionTextBox.Text = SkillStrings.Appraise;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Appraise].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int) ClassSkills.Appraise].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int) ClassSkills.Appraise].NumberOfRanks > 0;
                    break;
                case ClassSkills.Balance:
                    descriptionTextBox.Text = SkillStrings.Balance;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Balance].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Balance].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Balance].NumberOfRanks > 0;
                    break;
                case ClassSkills.Bluff:
                    descriptionTextBox.Text = SkillStrings.Bluff;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Bluff].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Bluff].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Bluff].NumberOfRanks > 0;
                    break;
                case ClassSkills.Climb:
                    descriptionTextBox.Text = SkillStrings.Climb;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Climb].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Climb].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Climb].NumberOfRanks > 0;
                    break;
                case ClassSkills.Concentration:
                    descriptionTextBox.Text = SkillStrings.Concentration;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Concentration].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Concentration].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Concentration].NumberOfRanks > 0;
                    break;
                case ClassSkills.Craft:
                    descriptionTextBox.Text = SkillStrings.Craft;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Craft].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Craft].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Craft].NumberOfRanks > 0;
                    break;
                case ClassSkills.DecipherScript:
                    descriptionTextBox.Text = SkillStrings.DecipherScript;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.DecipherScript].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.DecipherScript].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.DecipherScript].NumberOfRanks > 0;
                    break;
                case ClassSkills.Diplomacy:
                    descriptionTextBox.Text = SkillStrings.Diplomacy;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Diplomacy].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Diplomacy].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Diplomacy].NumberOfRanks > 0;
                    break;
                case ClassSkills.DisableDevice:
                    descriptionTextBox.Text = SkillStrings.DisableDevice;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.DisableDevice].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.DisableDevice].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.DisableDevice].NumberOfRanks > 0;
                    break;
                case ClassSkills.Disguise:
                    descriptionTextBox.Text = SkillStrings.Disguise;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Disguise].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Disguise].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Disguise].NumberOfRanks > 0;
                    break;
                case ClassSkills.EscapeArtist:
                    descriptionTextBox.Text = SkillStrings.EscapeArtist;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.EscapeArtist].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.EscapeArtist].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.EscapeArtist].NumberOfRanks > 0;
                    break;
                case ClassSkills.Forgery:
                    descriptionTextBox.Text = SkillStrings.Forgery;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Forgery].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Forgery].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Forgery].NumberOfRanks > 0;
                    break;
                case ClassSkills.GatherInformation:
                    descriptionTextBox.Text = SkillStrings.GatherInformation;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.GatherInformation].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.GatherInformation].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.GatherInformation].NumberOfRanks > 0;
                    break;
                case ClassSkills.HandleAnimal:
                    descriptionTextBox.Text = SkillStrings.HandleAnimal;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.HandleAnimal].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.HandleAnimal].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.HandleAnimal].NumberOfRanks > 0;
                    break;
                case ClassSkills.Heal:
                    descriptionTextBox.Text = SkillStrings.Heal;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Heal].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Heal].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Heal].NumberOfRanks > 0;
                    break;
                case ClassSkills.Hide:
                    descriptionTextBox.Text = SkillStrings.Hide;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Hide].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Hide].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Hide].NumberOfRanks > 0;
                    break;
                case ClassSkills.Intimidate:
                    descriptionTextBox.Text = SkillStrings.Intimidate;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Intimidate].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Intimidate].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Intimidate].NumberOfRanks > 0;
                    break;
                case ClassSkills.Jump:
                    descriptionTextBox.Text = SkillStrings.Jump;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Jump].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Jump].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Jump].NumberOfRanks > 0;
                    break;
                case ClassSkills.Knowledge:
                    descriptionTextBox.Text = SkillStrings.Knowledge;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Knowledge].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Knowledge].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Knowledge].NumberOfRanks > 0;
                    break;
                case ClassSkills.Listen:
                    descriptionTextBox.Text = SkillStrings.Listen;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Listen].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Listen].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Listen].NumberOfRanks > 0;
                    break;
                case ClassSkills.MoveSilently:
                    descriptionTextBox.Text = SkillStrings.MoveSilently;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.MoveSilently].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.MoveSilently].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.MoveSilently].NumberOfRanks > 0;
                    break;
                case ClassSkills.OpenLock:
                    descriptionTextBox.Text = SkillStrings.OpenLock;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.OpenLock].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.OpenLock].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.OpenLock].NumberOfRanks > 0;
                    break;
                case ClassSkills.Perform:
                    descriptionTextBox.Text = SkillStrings.Perform;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Perform].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Perform].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Perform].NumberOfRanks > 0;
                    break;
                case ClassSkills.Profession:
                    descriptionTextBox.Text = SkillStrings.Profession;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Profession].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Profession].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Profession].NumberOfRanks > 0;
                    break;
                case ClassSkills.Ride:
                    descriptionTextBox.Text = SkillStrings.Ride;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Ride].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Ride].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Ride].NumberOfRanks > 0;
                    break;
                case ClassSkills.Search:
                    descriptionTextBox.Text = SkillStrings.Search;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Search].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Search].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Search].NumberOfRanks > 0;
                    break;
                case ClassSkills.SenseMotive:
                    descriptionTextBox.Text = SkillStrings.SenseMotive;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.SenseMotive].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.SenseMotive].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.SenseMotive].NumberOfRanks > 0;
                    break;
                case ClassSkills.SleightOfHand:
                    descriptionTextBox.Text = SkillStrings.SleightOfHand;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.SleightOfHand].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.SleightOfHand].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.SleightOfHand].NumberOfRanks > 0;
                    break;
                case ClassSkills.SpeakLanguage:
                    descriptionTextBox.Text = SkillStrings.SpeakLanguage;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.SpeakLanguage].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.SpeakLanguage].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.SpeakLanguage].NumberOfRanks > 0;
                    break;
                case ClassSkills.Spellcraft:
                    descriptionTextBox.Text = SkillStrings.Spellcraft;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Spellcraft].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Spellcraft].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Spellcraft].NumberOfRanks > 0;
                    break;
                case ClassSkills.Spot:
                    descriptionTextBox.Text = SkillStrings.Spot;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Spot].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Spot].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Spot].NumberOfRanks > 0;
                    break;
                case ClassSkills.Survival:
                    descriptionTextBox.Text = SkillStrings.Survival;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Survival].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Survival].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Survival].NumberOfRanks > 0;
                    break;
                case ClassSkills.Swim:
                    descriptionTextBox.Text = SkillStrings.Swim;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Swim].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Swim].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Swim].NumberOfRanks > 0;
                    break;
                case ClassSkills.Tumble:
                    descriptionTextBox.Text = SkillStrings.Tumble;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.Tumble].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.Tumble].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.Tumble].NumberOfRanks > 0;
                    break;
                case ClassSkills.UseMagicDevice:
                    descriptionTextBox.Text = SkillStrings.UseMagicDevice;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.UseMagicDevice].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.UseMagicDevice].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.UseMagicDevice].NumberOfRanks > 0;
                    break;
                case ClassSkills.UseRope:
                    descriptionTextBox.Text = SkillStrings.UseRope;
                    rankCountTextBox.Text = PlayerSkills.SkillsContainer[(int)ClassSkills.UseRope].NumberOfRanks.ToString();
                    _canAdd = PlayerSkills.SkillsContainer[(int)ClassSkills.UseRope].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                    _canRemove = PlayerSkills.SkillsContainer[(int)ClassSkills.UseRope].NumberOfRanks > 0;
                    break;
            }

            rankCountTextBox.Text += "            /            " + _thusFar.SkillCap;
            addRankButton.Enabled = _canAdd;
            removeRankButton.Enabled = _canRemove;
        }

        #endregion

        #region Button Click Events

        /// <summary>
        /// Event that is fired when the user clicks on the Add Rank Button for a particular menu skill.
        /// </summary>
        private void addRankButton_Click(object sender, EventArgs e)
        {
            string selectedSkill = (string)skillsMenuBox.SelectedItem;

            if (_canAdd)
            {
                PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks++;
                _skillsRemaining--;
                
                _canAdd = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                _canRemove = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks > 0;
            }

            addRankButton.Enabled = _canAdd;
            removeRankButton.Enabled = _canRemove;
            rankCountTextBox.Text = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks.ToString();
            rankCountTextBox.Text += "            /            " + _thusFar.SkillCap;

            skillCountTextBox.Text = _skillsRemaining.ToString();
            saveChangesButton.Enabled = _skillsRemaining == 0;
        }

        /// <summary>
        /// Event that is fired when the user clicks on the Remove Rank Button for a particular menu skill.
        /// </summary>
        private void removeRankButton_Click(object sender, EventArgs e)
        {
            string selectedSkill = (string)skillsMenuBox.SelectedItem;

            if (_canRemove)
            {
                PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks--;
                _skillsRemaining++;

                _canAdd = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks < _thusFar.SkillCap && _skillsRemaining > 0;
                _canRemove = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks > 0;
            }

            removeRankButton.Enabled = _canRemove;
            addRankButton.Enabled = _canAdd;
            rankCountTextBox.Text = PlayerSkills.SkillsContainer[skillsMenuBox.FindStringExact(selectedSkill)].NumberOfRanks.ToString();
            rankCountTextBox.Text += "            /            " + _thusFar.SkillCap;

            skillCountTextBox.Text = _skillsRemaining.ToString();
            saveChangesButton.Enabled = _skillsRemaining == 0;
        }

        #endregion
    }
}
