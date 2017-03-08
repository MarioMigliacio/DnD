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
            this.isAcquiredGroupBox = new System.Windows.Forms.GroupBox();
            this.isAcquiredTextBox = new System.Windows.Forms.TextBox();
            this.addRankGroupBox = new System.Windows.Forms.GroupBox();
            this.learnFeatButton = new System.Windows.Forms.Button();
            this.removeRankGroupBox = new System.Windows.Forms.GroupBox();
            this.removeFeatButton = new System.Windows.Forms.Button();
            this.fighterBonusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionGroupBox.SuspendLayout();
            this.featsRemainingGroupBox.SuspendLayout();
            this.isAcquiredGroupBox.SuspendLayout();
            this.addRankGroupBox.SuspendLayout();
            this.removeRankGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Location = new System.Drawing.Point(838, 10);
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
            this.featsMenuBox.Location = new System.Drawing.Point(13, 10);
            this.featsMenuBox.Name = "featsMenuBox";
            this.featsMenuBox.Size = new System.Drawing.Size(196, 21);
            this.featsMenuBox.TabIndex = 2;
            this.featsMenuBox.SelectedIndexChanged += new System.EventHandler(this.featsMenuBox_SelectedIndexChanged);
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.descriptionTextBox);
            this.descriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionGroupBox.Location = new System.Drawing.Point(215, 62);
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
            "QuickDraw",
            "RapidReload",
            "TwoWeaponFighting",
            "ImprovedTwoWeaponFighting",
            "GreaterTwoWeaponFighting",
            "WeaponFinesse",
            "WeaponFocus",
            "GreaterWeaponFocus",
            "WeaponSpecialization",
            "GreaterWeaponSpecialization"});
            this.bonusFighterFeatsMenuBox.Location = new System.Drawing.Point(13, 110);
            this.bonusFighterFeatsMenuBox.Name = "bonusFighterFeatsMenuBox";
            this.bonusFighterFeatsMenuBox.Size = new System.Drawing.Size(196, 21);
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
            this.bonusMonkFeatsMenuBox.Location = new System.Drawing.Point(13, 210);
            this.bonusMonkFeatsMenuBox.Name = "bonusMonkFeatsMenuBox";
            this.bonusMonkFeatsMenuBox.Size = new System.Drawing.Size(196, 21);
            this.bonusMonkFeatsMenuBox.TabIndex = 5;
            this.bonusMonkFeatsMenuBox.SelectedIndexChanged += new System.EventHandler(this.bonusMonkFeatsMenuBox_SelectedIndexChanged);
            // 
            // featsRemainingGroupBox
            // 
            this.featsRemainingGroupBox.Controls.Add(this.featCountTextBox);
            this.featsRemainingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featsRemainingGroupBox.Location = new System.Drawing.Point(441, 10);
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
            // isAcquiredGroupBox
            // 
            this.isAcquiredGroupBox.Controls.Add(this.isAcquiredTextBox);
            this.isAcquiredGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAcquiredGroupBox.Location = new System.Drawing.Point(838, 62);
            this.isAcquiredGroupBox.Name = "isAcquiredGroupBox";
            this.isAcquiredGroupBox.Size = new System.Drawing.Size(142, 54);
            this.isAcquiredGroupBox.TabIndex = 5;
            this.isAcquiredGroupBox.TabStop = false;
            this.isAcquiredGroupBox.Text = "Known?";
            // 
            // isAcquiredTextBox
            // 
            this.isAcquiredTextBox.Enabled = false;
            this.isAcquiredTextBox.Location = new System.Drawing.Point(7, 20);
            this.isAcquiredTextBox.Name = "isAcquiredTextBox";
            this.isAcquiredTextBox.ReadOnly = true;
            this.isAcquiredTextBox.Size = new System.Drawing.Size(129, 26);
            this.isAcquiredTextBox.TabIndex = 0;
            // 
            // addRankGroupBox
            // 
            this.addRankGroupBox.Controls.Add(this.learnFeatButton);
            this.addRankGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRankGroupBox.Location = new System.Drawing.Point(838, 122);
            this.addRankGroupBox.Name = "addRankGroupBox";
            this.addRankGroupBox.Size = new System.Drawing.Size(142, 54);
            this.addRankGroupBox.TabIndex = 6;
            this.addRankGroupBox.TabStop = false;
            // 
            // learnFeatButton
            // 
            this.learnFeatButton.Enabled = false;
            this.learnFeatButton.Location = new System.Drawing.Point(6, 15);
            this.learnFeatButton.Name = "learnFeatButton";
            this.learnFeatButton.Size = new System.Drawing.Size(130, 33);
            this.learnFeatButton.TabIndex = 0;
            this.learnFeatButton.Text = "Learn Feat";
            this.learnFeatButton.UseVisualStyleBackColor = true;
            // 
            // removeRankGroupBox
            // 
            this.removeRankGroupBox.Controls.Add(this.removeFeatButton);
            this.removeRankGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRankGroupBox.Location = new System.Drawing.Point(838, 182);
            this.removeRankGroupBox.Name = "removeRankGroupBox";
            this.removeRankGroupBox.Size = new System.Drawing.Size(142, 54);
            this.removeRankGroupBox.TabIndex = 7;
            this.removeRankGroupBox.TabStop = false;
            // 
            // removeFeatButton
            // 
            this.removeFeatButton.Enabled = false;
            this.removeFeatButton.Location = new System.Drawing.Point(6, 15);
            this.removeFeatButton.Name = "removeFeatButton";
            this.removeFeatButton.Size = new System.Drawing.Size(130, 33);
            this.removeFeatButton.TabIndex = 1;
            this.removeFeatButton.Text = "Remove Feat";
            this.removeFeatButton.UseVisualStyleBackColor = true;
            // 
            // fighterBonusLabel
            // 
            this.fighterBonusLabel.AutoSize = true;
            this.fighterBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighterBonusLabel.Location = new System.Drawing.Point(9, 88);
            this.fighterBonusLabel.Name = "fighterBonusLabel";
            this.fighterBonusLabel.Size = new System.Drawing.Size(177, 20);
            this.fighterBonusLabel.TabIndex = 8;
            this.fighterBonusLabel.Text = "Fighter\'s Bonus Feat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monk\'s Bonus Feat";
            // 
            // Feat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fighterBonusLabel);
            this.Controls.Add(this.removeRankGroupBox);
            this.Controls.Add(this.addRankGroupBox);
            this.Controls.Add(this.isAcquiredGroupBox);
            this.Controls.Add(this.featsRemainingGroupBox);
            this.Controls.Add(this.bonusMonkFeatsMenuBox);
            this.Controls.Add(this.bonusFighterFeatsMenuBox);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.featsMenuBox);
            this.Controls.Add(this.saveChangesButton);
            this.Name = "Feat";
            this.Text = "Feat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Feat_FormClosing);
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.featsRemainingGroupBox.ResumeLayout(false);
            this.featsRemainingGroupBox.PerformLayout();
            this.isAcquiredGroupBox.ResumeLayout(false);
            this.isAcquiredGroupBox.PerformLayout();
            this.addRankGroupBox.ResumeLayout(false);
            this.removeRankGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox isAcquiredGroupBox;
        private System.Windows.Forms.TextBox isAcquiredTextBox;
        private System.Windows.Forms.GroupBox addRankGroupBox;
        private System.Windows.Forms.Button learnFeatButton;
        private System.Windows.Forms.GroupBox removeRankGroupBox;
        private System.Windows.Forms.Button removeFeatButton;
        private System.Windows.Forms.Label fighterBonusLabel;
        private System.Windows.Forms.Label label1;
    }
}