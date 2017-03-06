using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DnD.Enums.ClassTypes;
using DnD.Enums.NamesByRace;
using DnD.Enums.Races;
using HeroMaker.Enums;

namespace HeroMaker.Forms
{
    /// <summary>
    /// The Race and Class form. We use this form to gather information about hero's desired race type and class type.
    /// </summary>
    public partial class RaceAndClass : Form
    {
        #region Form Essentials

        /// <summary>
        /// Upon form construction, this method is called. It is core to the construction of WinForm objects.
        /// </summary>
        public RaceAndClass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When we are ready to move on to the next form, the button click signals the FormControl object to change states.
        /// </summary>
        private void TestState_Click(object sender, EventArgs e)
        {
            FormControl.GS = FormControl.GetNextState();
            this.Dispose();
        }

        /// <summary>
        /// A failsafe for the user. If the user clicks the exit button on the top right of the application, signal that
        /// we are done using the app and want it closed.
        /// </summary>
        private void RaceAndClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormControl.GS = GameState.Final;
            this.Dispose();
        }

        #endregion

        #region Check For Valid Next State

        /// <summary>
        /// Helper function to check if the Next button is enabled or not.
        /// </summary>
        private void CheckNextStatus()
        {
            if (string.IsNullOrEmpty(PlayerNameAndGender.Name) ||
                string.IsNullOrEmpty(PlayerNameAndGender.Gender) ||
                DesiredRaceType.DesiredRace == RaceType.None ||
                DesiredClassType.DesiredClass == ClassType.None)
            {
                saveChanges.Enabled = false;
            }
            else
            {
                saveChanges.Enabled = true;
            }
        }

        #endregion

        #region Gender ToolStrip Events

        /// <summary>
        /// The event that fires when the user clicks on the Gender toolstrip menu, MALE item.
        /// Sets the Players Gender to Male. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void maleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerNameAndGender.Gender = "Male";
            chooseGenderToolStripMenuItem.Text = "Male";
        }

        /// <summary>
        /// The event that fires when the user clicks on the Gender toolstrip menu, FEMALE item.
        /// Sets the Players Gender to Female. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerNameAndGender.Gender = "Female";
            chooseGenderToolStripMenuItem.Text = "Female";
        }

        #endregion

        #region Class ToolStrip Events

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, BARBARIAN item.
        /// Sets the Players Class to Barbarian. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void barbarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Barbarian;
            chooseClassToolStripMenuItem.Text = "Barbarian";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Barbarian;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, BARD item.
        /// Sets the Players Class to Bard. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void bardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Bard;
            chooseClassToolStripMenuItem.Text = "Bard";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Bard;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, CLERIC item.
        /// Sets the Players Class to Cleric. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void clericToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Cleric;
            chooseClassToolStripMenuItem.Text = "Cleric";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Cleric;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, DRUID item.
        /// Sets the Players Class to Druid. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void druidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Druid;
            chooseClassToolStripMenuItem.Text = "Druid";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Druid;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, FIGHTER item.
        /// Sets the Players Class to Fighter. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void fighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Fighter;
            chooseClassToolStripMenuItem.Text = "Fighter";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Fighter;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, MONK item.
        /// Sets the Players Class to Monk. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void monkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Monk;
            chooseClassToolStripMenuItem.Text = "Monk";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Monk;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, PALADIN item.
        /// Sets the Players Class to Paladin. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void paladinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Paladin;
            chooseClassToolStripMenuItem.Text = "Paladin";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Paladin;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, RANGER item.
        /// Sets the Players Class to Ranger. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void rangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Ranger;
            chooseClassToolStripMenuItem.Text = "Ranger";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Ranger;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, ROGUE item.
        /// Sets the Players Class to Rogue. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void rogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Rogue;
            chooseClassToolStripMenuItem.Text = "Rogue";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Rogue;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, SORCERER item.
        /// Sets the Players Class to Sorcerer. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void sorcererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Sorcerer;
            chooseClassToolStripMenuItem.Text = "Sorcerer";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Sorcerer;
            CheckNextStatus();
        }

        /// <summary>
        /// The event that fires when the user clicks on the Class toolstrip menu, WIZARD item.
        /// Sets the Players Class to Wizard. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void wizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredClassType.DesiredClass = ClassType.Wizard;
            chooseClassToolStripMenuItem.Text = "Wizard";
            classDescriptionTextBox.Text = DnD.UserStrings.ClassStrings.Wizard;
            CheckNextStatus();
        }

        #endregion

        #region Race ToolStrip Events

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, DWARF item.
        /// Sets the Players Race to Dwarf. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void dwarfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.Dwarf;
            chooseRaceToolStripMenuItem.Text = "Dwarf";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.Dwarf;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, ELF item.
        /// Sets the Players Race to Elf. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void elfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.Elf;
            chooseRaceToolStripMenuItem.Text = "Elf";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.Elf;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, GNOME item.
        /// Sets the Players Race to Gnome. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void gnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.Gnome;
            chooseRaceToolStripMenuItem.Text = "Gnome";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.Gnome;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, HALFELF item.
        /// Sets the Players Race to HalfElf. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void halfElfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.HalfElf;
            chooseRaceToolStripMenuItem.Text = "HalfElf";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.HalfElf;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, HALFORC item.
        /// Sets the Players Race to HalfOrc. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void halfOrcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.HalfOrc;
            chooseRaceToolStripMenuItem.Text = "HalfOrc";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.HalfOrc;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, HALFLING item.
        /// Sets the Players Race to Halfling. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void halflingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.Halfling;
            chooseRaceToolStripMenuItem.Text = "Halfling";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.Halfling;
        }

        /// <summary>
        /// The event that fires when the user clicks on the Race toolstrip menu, HUMAN item.
        /// Sets the Players Race to Human. And the Text on the toolstrip reflects this event fire.
        /// </summary>
        private void humanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesiredRaceType.DesiredRace = RaceType.Human;
            chooseRaceToolStripMenuItem.Text = "Human";
            raceDescriptionTextBox.Text = DnD.UserStrings.RaceStrings.Human;
        }

        #endregion

        #region Random Name Generation Events

        /// <summary>
        /// The event that fires when the user clicks on the RANDOM! button item.
        /// Sets the Players Name textbox to a randomly generated name. Results in error if the gender or race is not yet set.
        /// </summary>
        private void randomNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerNameAndGender.Gender) && (DesiredRaceType.DesiredRace == RaceType.None))
            {
                errorMessageTextBox.Text = "Gender has not yet been set." + "\r\nRace has not yet been set.";
            }
            else if (string.IsNullOrEmpty(PlayerNameAndGender.Gender) && (DesiredRaceType.DesiredRace != RaceType.None))
            {
                errorMessageTextBox.Text = "Gender has not yet been set.";
            }
            else if (DesiredRaceType.DesiredRace == RaceType.None && !string.IsNullOrEmpty(PlayerNameAndGender.Gender))
            {
                errorMessageTextBox.Text = "Race has not yet been set.";
            }

            if (PlayerNameAndGender.Gender == "Male" && DesiredRaceType.DesiredRace != RaceType.None)
            {
                switch(DesiredRaceType.DesiredRace)
                {
                    case RaceType.Dwarf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Dwarf, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Elf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Elf, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Gnome:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Gnome, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.HalfElf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.HalfElf, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.HalfOrc:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.HalfOrc, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Halfling:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Halfling, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Human:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Human, "Male");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                }
            }
            else if (PlayerNameAndGender.Gender == "Female" && DesiredRaceType.DesiredRace != RaceType.None)
            {
                switch (DesiredRaceType.DesiredRace)
                {
                    case RaceType.Dwarf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Dwarf, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Elf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Elf, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Gnome:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Gnome, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.HalfElf:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.HalfElf, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.HalfOrc:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.HalfOrc, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Halfling:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Halfling, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                    case RaceType.Human:
                        suggestedNamesTextBox.Text = generateRandomName(RaceType.Human, "Female");
                        herosNameTextBox.Text = suggestedNamesTextBox.Text;
                        errorMessageTextBox.Text = null;
                        break;
                }
            }

            CheckNextStatus();
        }

        /// <summary>
        /// Helper function which will generate a name from a list of predefined names found in Dnd.Enums.NamesByRace.
        /// </summary>
        private string generateRandomName(RaceType race, string gender)
        {
            List<string> nameList = new List<string>();
            Random rng = new Random();

            if (gender == "Male")
            {
                switch (race)
                {
                    case RaceType.Dwarf:
                        foreach (NamesDwarfMale name in Enum.GetValues(typeof (NamesDwarfMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)]; 
                    case RaceType.Elf:
                        foreach (NamesElfMale name in Enum.GetValues(typeof(NamesElfMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Gnome:
                        foreach (NamesGnomeMale name in Enum.GetValues(typeof(NamesGnomeMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.HalfElf:
                        foreach (NamesElfMale name in Enum.GetValues(typeof(NamesElfMale))) { nameList.Add(name.ToString()); }
                        foreach (NamesHumanMale name in Enum.GetValues(typeof(NamesHumanMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.HalfOrc:
                        foreach (NamesHalfOrcMale name in Enum.GetValues(typeof(NamesHalfOrcMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Halfling:
                        foreach (NamesHalflingMale name in Enum.GetValues(typeof(NamesHalflingMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Human:
                        foreach (NamesHumanMale name in Enum.GetValues(typeof(NamesHumanMale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                }
            }

            else if (gender == "Female")
            {
                switch (race)
                {
                    case RaceType.Dwarf:
                        foreach (NamesDwarfFemale name in Enum.GetValues(typeof(NamesDwarfFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Elf:
                        foreach (NamesElfFemale name in Enum.GetValues(typeof(NamesElfFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Gnome:
                        foreach (NamesGnomeFemale name in Enum.GetValues(typeof(NamesGnomeFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.HalfElf:
                        foreach (NamesElfFemale name in Enum.GetValues(typeof(NamesElfFemale))) { nameList.Add(name.ToString()); }
                        foreach (NamesHumanFemale name in Enum.GetValues(typeof(NamesHumanFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.HalfOrc:
                        foreach (NamesHalfOrcFemale name in Enum.GetValues(typeof(NamesHalfOrcFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Halfling:
                        foreach (NamesHalflingFemale name in Enum.GetValues(typeof(NamesHalflingFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                    case RaceType.Human:
                        foreach (NamesHumanFemale name in Enum.GetValues(typeof(NamesHumanFemale))) { nameList.Add(name.ToString()); }
                        return nameList[rng.Next(0, nameList.Count)];
                }
            }

            // the default just in case something is not right.
            return null;
        }

        #endregion

        #region Hero Name Box Events

        /// <summary>
        /// The event that fires when the user generates a name in the herosNameTextBox field by any means.
        /// Sets the Players Name to the value.
        /// </summary>
        private void herosNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PlayerNameAndGender.Name = herosNameTextBox.Text;
        }

        #endregion
    }
}
