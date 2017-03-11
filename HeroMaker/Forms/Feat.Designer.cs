namespace HeroMaker.Forms
{
    partial class Feat
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
            this.featsMenuBox = new System.Windows.Forms.ComboBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.bonusFighterFeatsMenuBox = new System.Windows.Forms.ComboBox();
            this.bonusMonkFeatsMenuBox = new System.Windows.Forms.ComboBox();
            this.featsRemainingGroupBox = new System.Windows.Forms.GroupBox();
            this.featCountTextBox = new System.Windows.Forms.TextBox();
            this.learnMonkFeatButton = new System.Windows.Forms.Button();
            this.removeMonkFeatButton = new System.Windows.Forms.Button();
            this.fighterBonusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.knownFeatsGroupBox = new System.Windows.Forms.GroupBox();
            this.knownFeatsTextBox = new System.Windows.Forms.TextBox();
            this.learnFighterFeatButton = new System.Windows.Forms.Button();
            this.removeFighterFeatButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.learnFeatButton = new System.Windows.Forms.Button();
            this.removeFeatButton = new System.Windows.Forms.Button();
            this.descriptionGroupBox.SuspendLayout();
            this.featsRemainingGroupBox.SuspendLayout();
            this.knownFeatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Location = new System.Drawing.Point(838, 21);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(134, 31);
            this.saveChangesButton.TabIndex = 1;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // featsMenuBox
            // 
            this.featsMenuBox.FormattingEnabled = true;
            this.featsMenuBox.Items.AddRange(new object[] {
            "Acrobatic",
            "Agile",
            "Alertness",
            "AnimalAffinity",
            "LightArmorProficiency",
            "MediumArmorProficiency",
            "HeavyArmorProficiency",
            "Athletic",
            "AugmentSummoning",
            "BlindFight",
            "CombatCasting",
            "CombatExpertise",
            "ImprovedDisarm",
            "ImprovedFeint",
            "ImprovedTrip",
            "WhirlwindAttack",
            "CombatReflexes",
            "Deceitful",
            "DeftHands",
            "Diligent",
            "Dodge",
            "Mobility",
            "SpringAttack",
            "Endurance",
            "Diehard",
            "EschewMaterials",
            "ExoticWeaponProficiency",
            "ExtraTurning",
            "GreatFortitude",
            "ImprovedCounterspell",
            "ImprovedCritical",
            "ImprovedInitiative",
            "ImprovedTurning",
            "ImprovedUnarmedStrike",
            "ImprovedGrapple",
            "DeflectArrows",
            "SnatchArrows",
            "StunningFist",
            "Investigator",
            "IronWill",
            "LightningReflexes",
            "MagicalAptitude",
            "MartialWeaponProficiency",
            "MountedCombat",
            "MountedArchery",
            "RideByAttack",
            "SpiritedCharge",
            "Trample",
            "NaturalSpell",
            "Negotiator",
            "NimbleFingers",
            "Persuasive",
            "PointBlankShot",
            "FarShot",
            "PreciseShot",
            "ImprovedPreciseShot",
            "RapidShot",
            "Manyshot",
            "ShotOnTheRun",
            "PowerAttack",
            "Cleave",
            "GreatCleave",
            "ImprovedBullRush",
            "ImprovedOverrun",
            "ImprovedSunder",
            "Quickdraw",
            "RapidReload",
            "Run",
            "SelfSufficient",
            "ShieldProficiency",
            "ImprovedShieldBash",
            "TowerShieldProficiency",
            "SimpleWeaponProficiency",
            "SkillFocus",
            "SpellFocus",
            "GreaterSpellFocus",
            "SpellMastery",
            "SpellPenetration",
            "GreaterSpellPenetration",
            "Stealthy",
            "Toughness",
            "Track",
            "TwoWeaponFighting",
            "ImprovedTwoWeaponFighting",
            "GreaterTwoWeaponFighting",
            "WeaponFinesse",
            "WeaponFocus",
            "WeaponSpecialization",
            "GreaterWeaponFocus",
            "GreaterWeaponSpecialization",
            "BrewPotion",
            "CraftMagicArmsAndArmor",
            "CraftRod",
            "CraftStaff",
            "CraftWand",
            "CraftWondrousItem",
            "ForgeRing",
            "ScribeScroll",
            "EmpowerSpell",
            "EnlargeSpell",
            "ExtendSpell",
            "HeightenSpell",
            "MaximizeSpell",
            "QuickenSpell",
            "SilentSpell",
            "StillSpell",
            "WidenSpell"});
            this.featsMenuBox.Location = new System.Drawing.Point(12, 76);
            this.featsMenuBox.Name = "featsMenuBox";
            this.featsMenuBox.Size = new System.Drawing.Size(160, 21);
            this.featsMenuBox.TabIndex = 2;
            this.featsMenuBox.SelectedIndexChanged += new System.EventHandler(this.featsMenuBox_SelectedIndexChanged);
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.descriptionTextBox);
            this.descriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionGroupBox.Location = new System.Drawing.Point(355, 66);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(617, 537);
            this.descriptionGroupBox.TabIndex = 3;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Feat Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 25);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(605, 506);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // bonusFighterFeatsMenuBox
            // 
            this.bonusFighterFeatsMenuBox.Enabled = false;
            this.bonusFighterFeatsMenuBox.FormattingEnabled = true;
            this.bonusFighterFeatsMenuBox.Items.AddRange(new object[] {
            "BlindFight",
            "CombatExpertise",
            "ImprovedDisarm",
            "ImprovedFeint",
            "ImprovedTrip",
            "CombatReflexes",
            "Dodge",
            "Mobility",
            "ShotOnTheRun",
            "SpringAttack",
            "WhirlwindAttack",
            "ExoticWeaponProficiency",
            "ImprovedCritical",
            "ImprovedShieldBash",
            "ImprovedUnarmedStrike",
            "DeflectArrows",
            "SnatchArrows",
            "ImprovedGrapple",
            "StunningFist",
            "MountedCombat",
            "MountedArchery",
            "RideByAttack",
            "SpiritedCharge",
            "Trample",
            "PointBlankShot",
            "FarShot",
            "PreciseShot",
            "ImprovedPreciseShot",
            "RapidShot",
            "Manyshot",
            "PowerAttack",
            "Cleave",
            "GreatCleave",
            "ImprovedBullRush",
            "ImprovedOverrun",
            "ImprovedSunder",
            "Quickdraw",
            "RapidReload",
            "TwoWeaponFighting",
            "ImprovedTwoWeaponFighting",
            "GreaterTwoWeaponFighting",
            "WeaponFinesse",
            "WeaponFocus",
            "GreaterWeaponFocus",
            "WeaponSpecialization",
            "GreaterWeaponSpecialization"});
            this.bonusFighterFeatsMenuBox.Location = new System.Drawing.Point(12, 211);
            this.bonusFighterFeatsMenuBox.Name = "bonusFighterFeatsMenuBox";
            this.bonusFighterFeatsMenuBox.Size = new System.Drawing.Size(159, 21);
            this.bonusFighterFeatsMenuBox.TabIndex = 4;
            this.bonusFighterFeatsMenuBox.SelectedIndexChanged += new System.EventHandler(this.bonusFighterFeatsMenuBox_SelectedIndexChanged);
            // 
            // bonusMonkFeatsMenuBox
            // 
            this.bonusMonkFeatsMenuBox.Enabled = false;
            this.bonusMonkFeatsMenuBox.FormattingEnabled = true;
            this.bonusMonkFeatsMenuBox.Items.AddRange(new object[] {
            "ImprovedGrapple",
            "StunningFist"});
            this.bonusMonkFeatsMenuBox.Location = new System.Drawing.Point(12, 344);
            this.bonusMonkFeatsMenuBox.Name = "bonusMonkFeatsMenuBox";
            this.bonusMonkFeatsMenuBox.Size = new System.Drawing.Size(159, 21);
            this.bonusMonkFeatsMenuBox.TabIndex = 5;
            this.bonusMonkFeatsMenuBox.SelectedIndexChanged += new System.EventHandler(this.bonusMonkFeatsMenuBox_SelectedIndexChanged);
            // 
            // featsRemainingGroupBox
            // 
            this.featsRemainingGroupBox.Controls.Add(this.featCountTextBox);
            this.featsRemainingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featsRemainingGroupBox.Location = new System.Drawing.Point(683, 6);
            this.featsRemainingGroupBox.Name = "featsRemainingGroupBox";
            this.featsRemainingGroupBox.Size = new System.Drawing.Size(149, 54);
            this.featsRemainingGroupBox.TabIndex = 4;
            this.featsRemainingGroupBox.TabStop = false;
            this.featsRemainingGroupBox.Text = "Feats Remaining";
            // 
            // featCountTextBox
            // 
            this.featCountTextBox.Enabled = false;
            this.featCountTextBox.Location = new System.Drawing.Point(7, 20);
            this.featCountTextBox.Name = "featCountTextBox";
            this.featCountTextBox.ReadOnly = true;
            this.featCountTextBox.Size = new System.Drawing.Size(129, 26);
            this.featCountTextBox.TabIndex = 0;
            // 
            // learnMonkFeatButton
            // 
            this.learnMonkFeatButton.Enabled = false;
            this.learnMonkFeatButton.Location = new System.Drawing.Point(177, 344);
            this.learnMonkFeatButton.Name = "learnMonkFeatButton";
            this.learnMonkFeatButton.Size = new System.Drawing.Size(83, 33);
            this.learnMonkFeatButton.TabIndex = 0;
            this.learnMonkFeatButton.Text = "Learn";
            this.learnMonkFeatButton.UseVisualStyleBackColor = true;
            this.learnMonkFeatButton.Click += new System.EventHandler(this.learnMonkFeatButton_Click);
            // 
            // removeMonkFeatButton
            // 
            this.removeMonkFeatButton.Enabled = false;
            this.removeMonkFeatButton.Location = new System.Drawing.Point(177, 383);
            this.removeMonkFeatButton.Name = "removeMonkFeatButton";
            this.removeMonkFeatButton.Size = new System.Drawing.Size(83, 33);
            this.removeMonkFeatButton.TabIndex = 1;
            this.removeMonkFeatButton.Text = "Remove";
            this.removeMonkFeatButton.UseVisualStyleBackColor = true;
            this.removeMonkFeatButton.Click += new System.EventHandler(this.removeMonkFeatButton_Click);
            // 
            // fighterBonusLabel
            // 
            this.fighterBonusLabel.AutoSize = true;
            this.fighterBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighterBonusLabel.Location = new System.Drawing.Point(8, 188);
            this.fighterBonusLabel.Name = "fighterBonusLabel";
            this.fighterBonusLabel.Size = new System.Drawing.Size(164, 18);
            this.fighterBonusLabel.TabIndex = 8;
            this.fighterBonusLabel.Text = "Fighter\'s Bonus Feat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monk\'s Bonus Feat";
            // 
            // knownFeatsGroupBox
            // 
            this.knownFeatsGroupBox.Controls.Add(this.knownFeatsTextBox);
            this.knownFeatsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knownFeatsGroupBox.Location = new System.Drawing.Point(12, 441);
            this.knownFeatsGroupBox.Name = "knownFeatsGroupBox";
            this.knownFeatsGroupBox.Size = new System.Drawing.Size(337, 162);
            this.knownFeatsGroupBox.TabIndex = 10;
            this.knownFeatsGroupBox.TabStop = false;
            this.knownFeatsGroupBox.Text = "Known Feats";
            // 
            // knownFeatsTextBox
            // 
            this.knownFeatsTextBox.Location = new System.Drawing.Point(6, 25);
            this.knownFeatsTextBox.Multiline = true;
            this.knownFeatsTextBox.Name = "knownFeatsTextBox";
            this.knownFeatsTextBox.ReadOnly = true;
            this.knownFeatsTextBox.Size = new System.Drawing.Size(325, 131);
            this.knownFeatsTextBox.TabIndex = 0;
            // 
            // learnFighterFeatButton
            // 
            this.learnFighterFeatButton.Enabled = false;
            this.learnFighterFeatButton.Location = new System.Drawing.Point(177, 211);
            this.learnFighterFeatButton.Name = "learnFighterFeatButton";
            this.learnFighterFeatButton.Size = new System.Drawing.Size(83, 33);
            this.learnFighterFeatButton.TabIndex = 11;
            this.learnFighterFeatButton.Text = "Learn";
            this.learnFighterFeatButton.UseVisualStyleBackColor = true;
            this.learnFighterFeatButton.Click += new System.EventHandler(this.learnFighterFeatButton_Click);
            // 
            // removeFighterFeatButton
            // 
            this.removeFighterFeatButton.Enabled = false;
            this.removeFighterFeatButton.Location = new System.Drawing.Point(177, 250);
            this.removeFighterFeatButton.Name = "removeFighterFeatButton";
            this.removeFighterFeatButton.Size = new System.Drawing.Size(83, 33);
            this.removeFighterFeatButton.TabIndex = 12;
            this.removeFighterFeatButton.Text = "Remove";
            this.removeFighterFeatButton.UseVisualStyleBackColor = true;
            this.removeFighterFeatButton.Click += new System.EventHandler(this.removeFighterFeatButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Standard Feat";
            // 
            // learnFeatButton
            // 
            this.learnFeatButton.Enabled = false;
            this.learnFeatButton.Location = new System.Drawing.Point(178, 76);
            this.learnFeatButton.Name = "learnFeatButton";
            this.learnFeatButton.Size = new System.Drawing.Size(83, 33);
            this.learnFeatButton.TabIndex = 14;
            this.learnFeatButton.Text = "Learn";
            this.learnFeatButton.UseVisualStyleBackColor = true;
            this.learnFeatButton.Click += new System.EventHandler(this.learnFeatButton_Click);
            // 
            // removeFeatButton
            // 
            this.removeFeatButton.Enabled = false;
            this.removeFeatButton.Location = new System.Drawing.Point(177, 115);
            this.removeFeatButton.Name = "removeFeatButton";
            this.removeFeatButton.Size = new System.Drawing.Size(83, 33);
            this.removeFeatButton.TabIndex = 15;
            this.removeFeatButton.Text = "Remove";
            this.removeFeatButton.UseVisualStyleBackColor = true;
            this.removeFeatButton.Click += new System.EventHandler(this.removeFeatButton_Click);
            // 
            // Feat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.removeFeatButton);
            this.Controls.Add(this.learnFeatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeFighterFeatButton);
            this.Controls.Add(this.learnFighterFeatButton);
            this.Controls.Add(this.learnMonkFeatButton);
            this.Controls.Add(this.removeMonkFeatButton);
            this.Controls.Add(this.knownFeatsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fighterBonusLabel);
            this.Controls.Add(this.featsRemainingGroupBox);
            this.Controls.Add(this.bonusMonkFeatsMenuBox);
            this.Controls.Add(this.bonusFighterFeatsMenuBox);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.featsMenuBox);
            this.Controls.Add(this.saveChangesButton);
            this.MaximizeBox = false;
            this.Name = "Feat";
            this.Text = "Feat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Feat_FormClosing);
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.featsRemainingGroupBox.ResumeLayout(false);
            this.featsRemainingGroupBox.PerformLayout();
            this.knownFeatsGroupBox.ResumeLayout(false);
            this.knownFeatsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.ComboBox featsMenuBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox bonusFighterFeatsMenuBox;
        private System.Windows.Forms.ComboBox bonusMonkFeatsMenuBox;
        private System.Windows.Forms.GroupBox featsRemainingGroupBox;
        private System.Windows.Forms.TextBox featCountTextBox;
        private System.Windows.Forms.Button learnMonkFeatButton;
        private System.Windows.Forms.Button removeMonkFeatButton;
        private System.Windows.Forms.Label fighterBonusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox knownFeatsGroupBox;
        private System.Windows.Forms.TextBox knownFeatsTextBox;
        private System.Windows.Forms.Button learnFighterFeatButton;
        private System.Windows.Forms.Button removeFighterFeatButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button learnFeatButton;
        private System.Windows.Forms.Button removeFeatButton;
    }
}