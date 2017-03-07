namespace HeroMaker.Forms
{
    partial class RaceAndClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.verticalBar = new System.Windows.Forms.Label();
            this.suggestedNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.randomNameButton = new System.Windows.Forms.Button();
            this.suggestedNamesTextBox = new System.Windows.Forms.TextBox();
            this.heroNameBox = new System.Windows.Forms.GroupBox();
            this.herosNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barbarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clericToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paladinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorcererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwarfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gnomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfElfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfOrcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halflingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.classDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.raceDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.raceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.errorGroupBox = new System.Windows.Forms.GroupBox();
            this.errorMessageTextBox = new System.Windows.Forms.TextBox();
            this.suggestedNamesGroupBox.SuspendLayout();
            this.heroNameBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.classDescriptionGroupBox.SuspendLayout();
            this.raceDescriptionGroupBox.SuspendLayout();
            this.errorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Location = new System.Drawing.Point(550, 550);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(200, 50);
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.TestState_Click);
            // 
            // verticalBar
            // 
            this.verticalBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalBar.Location = new System.Drawing.Point(500, 35);
            this.verticalBar.Name = "verticalBar";
            this.verticalBar.Size = new System.Drawing.Size(2, 470);
            this.verticalBar.TabIndex = 5;
            // 
            // suggestedNamesGroupBox
            // 
            this.suggestedNamesGroupBox.Controls.Add(this.randomNameButton);
            this.suggestedNamesGroupBox.Controls.Add(this.suggestedNamesTextBox);
            this.suggestedNamesGroupBox.Location = new System.Drawing.Point(250, 485);
            this.suggestedNamesGroupBox.Name = "suggestedNamesGroupBox";
            this.suggestedNamesGroupBox.Size = new System.Drawing.Size(500, 60);
            this.suggestedNamesGroupBox.TabIndex = 6;
            this.suggestedNamesGroupBox.TabStop = false;
            this.suggestedNamesGroupBox.Text = "Suggested Names";
            // 
            // randomNameButton
            // 
            this.randomNameButton.Location = new System.Drawing.Point(317, 20);
            this.randomNameButton.Name = "randomNameButton";
            this.randomNameButton.Size = new System.Drawing.Size(155, 20);
            this.randomNameButton.TabIndex = 8;
            this.randomNameButton.Text = "RANDOM!";
            this.randomNameButton.UseVisualStyleBackColor = true;
            this.randomNameButton.Click += new System.EventHandler(this.randomNameButton_Click);
            // 
            // suggestedNamesTextBox
            // 
            this.suggestedNamesTextBox.Location = new System.Drawing.Point(7, 20);
            this.suggestedNamesTextBox.Name = "suggestedNamesTextBox";
            this.suggestedNamesTextBox.ReadOnly = true;
            this.suggestedNamesTextBox.Size = new System.Drawing.Size(281, 20);
            this.suggestedNamesTextBox.TabIndex = 0;
            // 
            // heroNameBox
            // 
            this.heroNameBox.Controls.Add(this.herosNameTextBox);
            this.heroNameBox.Location = new System.Drawing.Point(250, 550);
            this.heroNameBox.Name = "heroNameBox";
            this.heroNameBox.Size = new System.Drawing.Size(294, 49);
            this.heroNameBox.TabIndex = 7;
            this.heroNameBox.TabStop = false;
            this.heroNameBox.Text = "HeroName";
            // 
            // herosNameTextBox
            // 
            this.herosNameTextBox.Location = new System.Drawing.Point(7, 20);
            this.herosNameTextBox.MaxLength = 30;
            this.herosNameTextBox.Name = "herosNameTextBox";
            this.herosNameTextBox.Size = new System.Drawing.Size(281, 20);
            this.herosNameTextBox.TabIndex = 0;
            this.herosNameTextBox.TextChanged += new System.EventHandler(this.herosNameTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseGenderToolStripMenuItem,
            this.chooseClassToolStripMenuItem,
            this.chooseRaceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseGenderToolStripMenuItem
            // 
            this.chooseGenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem});
            this.chooseGenderToolStripMenuItem.Name = "chooseGenderToolStripMenuItem";
            this.chooseGenderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.chooseGenderToolStripMenuItem.Text = "Choose Gender";
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            this.maleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.maleToolStripMenuItem.Text = "Male";
            this.maleToolStripMenuItem.Click += new System.EventHandler(this.maleToolStripMenuItem_Click);
            // 
            // femaleToolStripMenuItem
            // 
            this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
            this.femaleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.femaleToolStripMenuItem.Text = "Female";
            this.femaleToolStripMenuItem.Click += new System.EventHandler(this.femaleToolStripMenuItem_Click);
            // 
            // chooseClassToolStripMenuItem
            // 
            this.chooseClassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbarianToolStripMenuItem,
            this.bardToolStripMenuItem,
            this.clericToolStripMenuItem,
            this.druidToolStripMenuItem,
            this.fighterToolStripMenuItem,
            this.monkToolStripMenuItem,
            this.paladinToolStripMenuItem,
            this.rangerToolStripMenuItem,
            this.rogueToolStripMenuItem,
            this.sorcererToolStripMenuItem,
            this.wizardToolStripMenuItem});
            this.chooseClassToolStripMenuItem.Name = "chooseClassToolStripMenuItem";
            this.chooseClassToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.chooseClassToolStripMenuItem.Text = "Choose Class";
            // 
            // barbarianToolStripMenuItem
            // 
            this.barbarianToolStripMenuItem.Name = "barbarianToolStripMenuItem";
            this.barbarianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.barbarianToolStripMenuItem.Text = "Barbarian";
            this.barbarianToolStripMenuItem.Click += new System.EventHandler(this.barbarianToolStripMenuItem_Click);
            // 
            // bardToolStripMenuItem
            // 
            this.bardToolStripMenuItem.Name = "bardToolStripMenuItem";
            this.bardToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.bardToolStripMenuItem.Text = "Bard";
            this.bardToolStripMenuItem.Click += new System.EventHandler(this.bardToolStripMenuItem_Click);
            // 
            // clericToolStripMenuItem
            // 
            this.clericToolStripMenuItem.Name = "clericToolStripMenuItem";
            this.clericToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clericToolStripMenuItem.Text = "Cleric";
            this.clericToolStripMenuItem.Click += new System.EventHandler(this.clericToolStripMenuItem_Click);
            // 
            // druidToolStripMenuItem
            // 
            this.druidToolStripMenuItem.Name = "druidToolStripMenuItem";
            this.druidToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.druidToolStripMenuItem.Text = "Druid";
            this.druidToolStripMenuItem.Click += new System.EventHandler(this.druidToolStripMenuItem_Click);
            // 
            // fighterToolStripMenuItem
            // 
            this.fighterToolStripMenuItem.Name = "fighterToolStripMenuItem";
            this.fighterToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fighterToolStripMenuItem.Text = "Fighter";
            this.fighterToolStripMenuItem.Click += new System.EventHandler(this.fighterToolStripMenuItem_Click);
            // 
            // monkToolStripMenuItem
            // 
            this.monkToolStripMenuItem.Name = "monkToolStripMenuItem";
            this.monkToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.monkToolStripMenuItem.Text = "Monk";
            this.monkToolStripMenuItem.Click += new System.EventHandler(this.monkToolStripMenuItem_Click);
            // 
            // paladinToolStripMenuItem
            // 
            this.paladinToolStripMenuItem.Name = "paladinToolStripMenuItem";
            this.paladinToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.paladinToolStripMenuItem.Text = "Paladin";
            this.paladinToolStripMenuItem.Click += new System.EventHandler(this.paladinToolStripMenuItem_Click);
            // 
            // rangerToolStripMenuItem
            // 
            this.rangerToolStripMenuItem.Name = "rangerToolStripMenuItem";
            this.rangerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rangerToolStripMenuItem.Text = "Ranger";
            this.rangerToolStripMenuItem.Click += new System.EventHandler(this.rangerToolStripMenuItem_Click);
            // 
            // rogueToolStripMenuItem
            // 
            this.rogueToolStripMenuItem.Name = "rogueToolStripMenuItem";
            this.rogueToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rogueToolStripMenuItem.Text = "Rogue";
            this.rogueToolStripMenuItem.Click += new System.EventHandler(this.rogueToolStripMenuItem_Click);
            // 
            // sorcererToolStripMenuItem
            // 
            this.sorcererToolStripMenuItem.Name = "sorcererToolStripMenuItem";
            this.sorcererToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sorcererToolStripMenuItem.Text = "Sorcerer";
            this.sorcererToolStripMenuItem.Click += new System.EventHandler(this.sorcererToolStripMenuItem_Click);
            // 
            // wizardToolStripMenuItem
            // 
            this.wizardToolStripMenuItem.Name = "wizardToolStripMenuItem";
            this.wizardToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.wizardToolStripMenuItem.Text = "Wizard";
            this.wizardToolStripMenuItem.Click += new System.EventHandler(this.wizardToolStripMenuItem_Click);
            // 
            // chooseRaceToolStripMenuItem
            // 
            this.chooseRaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dwarfToolStripMenuItem,
            this.elfToolStripMenuItem,
            this.gnomeToolStripMenuItem,
            this.halfElfToolStripMenuItem,
            this.halfOrcToolStripMenuItem,
            this.halflingToolStripMenuItem,
            this.humanToolStripMenuItem});
            this.chooseRaceToolStripMenuItem.Name = "chooseRaceToolStripMenuItem";
            this.chooseRaceToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.chooseRaceToolStripMenuItem.Text = "Choose Race";
            // 
            // dwarfToolStripMenuItem
            // 
            this.dwarfToolStripMenuItem.Name = "dwarfToolStripMenuItem";
            this.dwarfToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.dwarfToolStripMenuItem.Text = "Dwarf";
            this.dwarfToolStripMenuItem.Click += new System.EventHandler(this.dwarfToolStripMenuItem_Click);
            // 
            // elfToolStripMenuItem
            // 
            this.elfToolStripMenuItem.Name = "elfToolStripMenuItem";
            this.elfToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.elfToolStripMenuItem.Text = "Elf";
            this.elfToolStripMenuItem.Click += new System.EventHandler(this.elfToolStripMenuItem_Click);
            // 
            // gnomeToolStripMenuItem
            // 
            this.gnomeToolStripMenuItem.Name = "gnomeToolStripMenuItem";
            this.gnomeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gnomeToolStripMenuItem.Text = "Gnome";
            this.gnomeToolStripMenuItem.Click += new System.EventHandler(this.gnomeToolStripMenuItem_Click);
            // 
            // halfElfToolStripMenuItem
            // 
            this.halfElfToolStripMenuItem.Name = "halfElfToolStripMenuItem";
            this.halfElfToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.halfElfToolStripMenuItem.Text = "HalfElf";
            this.halfElfToolStripMenuItem.Click += new System.EventHandler(this.halfElfToolStripMenuItem_Click);
            // 
            // halfOrcToolStripMenuItem
            // 
            this.halfOrcToolStripMenuItem.Name = "halfOrcToolStripMenuItem";
            this.halfOrcToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.halfOrcToolStripMenuItem.Text = "HalfOrc";
            this.halfOrcToolStripMenuItem.Click += new System.EventHandler(this.halfOrcToolStripMenuItem_Click);
            // 
            // halflingToolStripMenuItem
            // 
            this.halflingToolStripMenuItem.Name = "halflingToolStripMenuItem";
            this.halflingToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.halflingToolStripMenuItem.Text = "Halfling";
            this.halflingToolStripMenuItem.Click += new System.EventHandler(this.halflingToolStripMenuItem_Click);
            // 
            // humanToolStripMenuItem
            // 
            this.humanToolStripMenuItem.Name = "humanToolStripMenuItem";
            this.humanToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.humanToolStripMenuItem.Text = "Human";
            this.humanToolStripMenuItem.Click += new System.EventHandler(this.humanToolStripMenuItem_Click);
            // 
            // classDescriptionGroupBox
            // 
            this.classDescriptionGroupBox.Controls.Add(this.classDescriptionTextBox);
            this.classDescriptionGroupBox.Location = new System.Drawing.Point(13, 35);
            this.classDescriptionGroupBox.Name = "classDescriptionGroupBox";
            this.classDescriptionGroupBox.Size = new System.Drawing.Size(481, 444);
            this.classDescriptionGroupBox.TabIndex = 9;
            this.classDescriptionGroupBox.TabStop = false;
            this.classDescriptionGroupBox.Text = "Class Description";
            // 
            // classDescriptionTextBox
            // 
            this.classDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDescriptionTextBox.Location = new System.Drawing.Point(7, 20);
            this.classDescriptionTextBox.Multiline = true;
            this.classDescriptionTextBox.Name = "classDescriptionTextBox";
            this.classDescriptionTextBox.ReadOnly = true;
            this.classDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.classDescriptionTextBox.Size = new System.Drawing.Size(468, 418);
            this.classDescriptionTextBox.TabIndex = 0;
            // 
            // raceDescriptionGroupBox
            // 
            this.raceDescriptionGroupBox.Controls.Add(this.raceDescriptionTextBox);
            this.raceDescriptionGroupBox.Location = new System.Drawing.Point(509, 35);
            this.raceDescriptionGroupBox.Name = "raceDescriptionGroupBox";
            this.raceDescriptionGroupBox.Size = new System.Drawing.Size(463, 444);
            this.raceDescriptionGroupBox.TabIndex = 10;
            this.raceDescriptionGroupBox.TabStop = false;
            this.raceDescriptionGroupBox.Text = "Race Description";
            // 
            // raceDescriptionTextBox
            // 
            this.raceDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceDescriptionTextBox.Location = new System.Drawing.Point(7, 20);
            this.raceDescriptionTextBox.Multiline = true;
            this.raceDescriptionTextBox.Name = "raceDescriptionTextBox";
            this.raceDescriptionTextBox.ReadOnly = true;
            this.raceDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.raceDescriptionTextBox.Size = new System.Drawing.Size(450, 418);
            this.raceDescriptionTextBox.TabIndex = 0;
            // 
            // errorGroupBox
            // 
            this.errorGroupBox.Controls.Add(this.errorMessageTextBox);
            this.errorGroupBox.Location = new System.Drawing.Point(756, 490);
            this.errorGroupBox.Name = "errorGroupBox";
            this.errorGroupBox.Size = new System.Drawing.Size(200, 109);
            this.errorGroupBox.TabIndex = 11;
            this.errorGroupBox.TabStop = false;
            this.errorGroupBox.Text = "ERROR MESSAGE";
            // 
            // errorMessageTextBox
            // 
            this.errorMessageTextBox.Location = new System.Drawing.Point(7, 20);
            this.errorMessageTextBox.Multiline = true;
            this.errorMessageTextBox.Name = "errorMessageTextBox";
            this.errorMessageTextBox.ReadOnly = true;
            this.errorMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorMessageTextBox.Size = new System.Drawing.Size(187, 80);
            this.errorMessageTextBox.TabIndex = 0;
            // 
            // RaceAndClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.errorGroupBox);
            this.Controls.Add(this.raceDescriptionGroupBox);
            this.Controls.Add(this.classDescriptionGroupBox);
            this.Controls.Add(this.heroNameBox);
            this.Controls.Add(this.suggestedNamesGroupBox);
            this.Controls.Add(this.verticalBar);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RaceAndClass";
            this.Text = "RaceAndClass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaceAndClass_FormClosing);
            this.suggestedNamesGroupBox.ResumeLayout(false);
            this.suggestedNamesGroupBox.PerformLayout();
            this.heroNameBox.ResumeLayout(false);
            this.heroNameBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.classDescriptionGroupBox.ResumeLayout(false);
            this.classDescriptionGroupBox.PerformLayout();
            this.raceDescriptionGroupBox.ResumeLayout(false);
            this.raceDescriptionGroupBox.PerformLayout();
            this.errorGroupBox.ResumeLayout(false);
            this.errorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label verticalBar;
        private System.Windows.Forms.GroupBox suggestedNamesGroupBox;
        private System.Windows.Forms.Button randomNameButton;
        private System.Windows.Forms.TextBox suggestedNamesTextBox;
        private System.Windows.Forms.GroupBox heroNameBox;
        private System.Windows.Forms.TextBox herosNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseGenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barbarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clericToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paladinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorcererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwarfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gnomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfElfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfOrcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halflingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanToolStripMenuItem;
        private System.Windows.Forms.GroupBox classDescriptionGroupBox;
        private System.Windows.Forms.GroupBox raceDescriptionGroupBox;
        private System.Windows.Forms.TextBox classDescriptionTextBox;
        private System.Windows.Forms.TextBox raceDescriptionTextBox;
        private System.Windows.Forms.GroupBox errorGroupBox;
        private System.Windows.Forms.TextBox errorMessageTextBox;
    }
}