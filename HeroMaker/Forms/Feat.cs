using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD.Classes.CharacterClasses;
using DnD.Classes.HeroFeats;
using DnD.Classes.Player;
using DnD.Enums.ClassFeats;
using DnD.Enums.ClassTypes;
using DnD.Enums.Races;
using DnD.Enums.Stats;
using DnD.UserStrings;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The Feats form. We use this form to gather information about hero's desired Feats.
    /// </summary>
    public partial class Feat : Form
    {
        private readonly Hero _thusFar;
        private int _featsRemaining;
        private bool _canAdd = false;
        private bool _canRemove = false;

        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public Feat()
        {
            InitializeComponent();
            PlayerFeats.PopulateContainer();

            // debugging purposes:
            DesiredClassType.DesiredClass = ClassType.Monk;
            DesiredRaceType.DesiredRace = RaceType.Human;
            PlayerStats.StatsContainer = new Dictionary<Stats, int>
            {
                {Stats.Charisma, 10},
                {Stats.Constitution, 10},
                {Stats.Dexterity, 10},
                {Stats.Intellect, 10},
                {Stats.Strength, 10},
                {Stats.Wisdom, 10}
            };

            _thusFar = Hero.GetStageTwoHero(DesiredClassType.DesiredClass, DesiredRaceType.DesiredRace, PlayerStats.StatsContainer);
            _featsRemaining = _thusFar.FeatsAvailable;
            featCountTextBox.Text = _featsRemaining.ToString();
            bonusMonkFeatsMenuBox.Enabled = _thusFar.TypeOfCharacter is Monk;
            bonusFighterFeatsMenuBox.Enabled = _thusFar.TypeOfCharacter is Fighter;
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void Feat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }

        /// <summary>
        /// When we are ready to move on to the next form, the button click signals the FormControl object to change states.
        /// </summary>
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            FormControl.Gs = GameState.Final;
            this.Dispose();
        }


        #endregion
        
        private void bonusFighterFeatsMenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            featsMenuBox.Text = string.Empty;
            bonusMonkFeatsMenuBox.Text = string.Empty;
            descriptionTextBox.Clear();
            isAcquiredTextBox.Clear();

            string selectedFeat = (string)bonusFighterFeatsMenuBox.SelectedItem;

            foreach (BaseFeat bf in PlayerFeats.FeatsContainer)
            {
                if (FeatInformation.GetEnumFromString(selectedFeat) == bf.FeatType)
                {
                    descriptionTextBox.Text = "(" + bf.FeatType + ")\r\n";
                    descriptionTextBox.Text += FeatInformation.GetDescription(bf.FeatType);
                    descriptionTextBox.Text += "\r\n\r\n\r\nThis Feat Requires the following:\r\n";
                    descriptionTextBox.Text += FeatInformation.GetPrerequisitesString(bf.FeatType);
                    isAcquiredTextBox.Text = bf.IsAcquired ? "True" : "False";
                    FeatRequirementCheck.CheckIfFeatCanBeAcquired(_thusFar, bf);
                    _canAdd = bf.CanAcquire;
                    _canRemove = bf.IsAcquired;
                    break;
                }
            }
        }

        private void bonusMonkFeatsMenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            featsMenuBox.Text = string.Empty;
            bonusFighterFeatsMenuBox.Text = string.Empty;
            descriptionTextBox.Clear();
            isAcquiredTextBox.Clear();
            
            string selectedFeat = (string)bonusMonkFeatsMenuBox.SelectedItem;

            foreach (BaseFeat bf in PlayerFeats.FeatsContainer)
            {
                if (FeatInformation.GetEnumFromString(selectedFeat) == bf.FeatType)
                {
                    descriptionTextBox.Text = "(" + bf.FeatType + ")\r\n";
                    descriptionTextBox.Text += FeatInformation.GetDescription(bf.FeatType);
                    descriptionTextBox.Text += "\r\n\r\n\r\nThis Feat Requires the following:\r\n";
                    descriptionTextBox.Text += FeatInformation.GetPrerequisitesString(bf.FeatType);
                    isAcquiredTextBox.Text = bf.IsAcquired ? "True" : "False";
                    FeatRequirementCheck.CheckIfFeatCanBeAcquired(_thusFar, bf);
                    _canAdd = bf.CanAcquire;
                    _canRemove = bf.IsAcquired;
                    break;
                }
            }
        }
        
        private void featsMenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bonusFighterFeatsMenuBox.Text = string.Empty;
            bonusMonkFeatsMenuBox.Text = string.Empty;
            descriptionTextBox.Clear();
            isAcquiredTextBox.Clear();
            
            string selectedFeat = (string)featsMenuBox.SelectedItem;

            foreach (BaseFeat bf in PlayerFeats.FeatsContainer)
            {
                if (FeatInformation.GetEnumFromString(selectedFeat) == bf.FeatType)
                {
                    descriptionTextBox.Text = "(" + bf.FeatType + ")\r\n";
                    descriptionTextBox.Text += FeatInformation.GetDescription(bf.FeatType);
                    descriptionTextBox.Text += "\r\n\r\n\r\nThis Feat Requires the following:\r\n";
                    descriptionTextBox.Text += FeatInformation.GetPrerequisitesString(bf.FeatType);
                    isAcquiredTextBox.Text = bf.IsAcquired ? "True" : "False";
                    FeatRequirementCheck.CheckIfFeatCanBeAcquired(_thusFar, bf);
                    _canAdd = bf.CanAcquire;
                    _canRemove = bf.IsAcquired;
                    break;
                }
            }
        }
        

    }
}
