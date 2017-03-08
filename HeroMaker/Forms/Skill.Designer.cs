namespace HeroMaker.Forms
{
    partial class Skill
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
            this.skillsMenuBox = new System.Windows.Forms.ComboBox();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.skillsRemainingGroupBox = new System.Windows.Forms.GroupBox();
            this.skillCountTextBox = new System.Windows.Forms.TextBox();
            this.rankCountGroupBox = new System.Windows.Forms.GroupBox();
            this.rankCountTextBox = new System.Windows.Forms.TextBox();
            this.addRankGroupBox = new System.Windows.Forms.GroupBox();
            this.addRankButton = new System.Windows.Forms.Button();
            this.removeRankGroupBox = new System.Windows.Forms.GroupBox();
            this.removeRankButton = new System.Windows.Forms.Button();
            this.descriptionGroupBox.SuspendLayout();
            this.skillsRemainingGroupBox.SuspendLayout();
            this.rankCountGroupBox.SuspendLayout();
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
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // skillsMenuBox
            // 
            this.skillsMenuBox.FormattingEnabled = true;
            this.skillsMenuBox.Items.AddRange(new object[] {
            "Appraise",
            "Balance",
            "Bluff",
            "Climb",
            "Concentration",
            "Craft",
            "DecipherScript",
            "Diplomacy",
            "DisableDevice",
            "Disguise",
            "EscapeArtist",
            "Forgery",
            "GatherInformation",
            "HandleAnimal",
            "Heal",
            "Hide",
            "Intimidate",
            "Jump",
            "Knowledge",
            "Listen",
            "MoveSilently",
            "OpenLock",
            "Perform",
            "Profession",
            "Ride",
            "Search",
            "SenseMotive",
            "SleightOfHand",
            "SpeakLanguage",
            "Spellcraft",
            "Spot",
            "Survival",
            "Swim",
            "Tumble",
            "UseMagicDevice",
            "UseRope"});
            this.skillsMenuBox.Location = new System.Drawing.Point(13, 10);
            this.skillsMenuBox.Name = "skillsMenuBox";
            this.skillsMenuBox.Size = new System.Drawing.Size(196, 21);
            this.skillsMenuBox.TabIndex = 1;
            this.skillsMenuBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.descriptionTextBox);
            this.descriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionGroupBox.Location = new System.Drawing.Point(215, 62);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(617, 537);
            this.descriptionGroupBox.TabIndex = 2;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Skill Description";
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
            // skillsRemainingGroupBox
            // 
            this.skillsRemainingGroupBox.Controls.Add(this.skillCountTextBox);
            this.skillsRemainingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillsRemainingGroupBox.Location = new System.Drawing.Point(441, 10);
            this.skillsRemainingGroupBox.Name = "skillsRemainingGroupBox";
            this.skillsRemainingGroupBox.Size = new System.Drawing.Size(149, 54);
            this.skillsRemainingGroupBox.TabIndex = 3;
            this.skillsRemainingGroupBox.TabStop = false;
            this.skillsRemainingGroupBox.Text = "Skills Remaining";
            // 
            // skillCountTextBox
            // 
            this.skillCountTextBox.Enabled = false;
            this.skillCountTextBox.Location = new System.Drawing.Point(7, 20);
            this.skillCountTextBox.Name = "skillCountTextBox";
            this.skillCountTextBox.ReadOnly = true;
            this.skillCountTextBox.Size = new System.Drawing.Size(129, 26);
            this.skillCountTextBox.TabIndex = 0;
            // 
            // rankCountGroupBox
            // 
            this.rankCountGroupBox.Controls.Add(this.rankCountTextBox);
            this.rankCountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankCountGroupBox.Location = new System.Drawing.Point(838, 62);
            this.rankCountGroupBox.Name = "rankCountGroupBox";
            this.rankCountGroupBox.Size = new System.Drawing.Size(142, 54);
            this.rankCountGroupBox.TabIndex = 4;
            this.rankCountGroupBox.TabStop = false;
            this.rankCountGroupBox.Text = "Ranks";
            // 
            // rankCountTextBox
            // 
            this.rankCountTextBox.Enabled = false;
            this.rankCountTextBox.Location = new System.Drawing.Point(7, 20);
            this.rankCountTextBox.Name = "rankCountTextBox";
            this.rankCountTextBox.ReadOnly = true;
            this.rankCountTextBox.Size = new System.Drawing.Size(129, 26);
            this.rankCountTextBox.TabIndex = 0;
            // 
            // addRankGroupBox
            // 
            this.addRankGroupBox.Controls.Add(this.addRankButton);
            this.addRankGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRankGroupBox.Location = new System.Drawing.Point(838, 122);
            this.addRankGroupBox.Name = "addRankGroupBox";
            this.addRankGroupBox.Size = new System.Drawing.Size(142, 54);
            this.addRankGroupBox.TabIndex = 5;
            this.addRankGroupBox.TabStop = false;
            // 
            // addRankButton
            // 
            this.addRankButton.Enabled = false;
            this.addRankButton.Location = new System.Drawing.Point(6, 15);
            this.addRankButton.Name = "addRankButton";
            this.addRankButton.Size = new System.Drawing.Size(130, 33);
            this.addRankButton.TabIndex = 0;
            this.addRankButton.Text = "add rank";
            this.addRankButton.UseVisualStyleBackColor = true;
            this.addRankButton.Click += new System.EventHandler(this.addRankButton_Click);
            // 
            // removeRankGroupBox
            // 
            this.removeRankGroupBox.Controls.Add(this.removeRankButton);
            this.removeRankGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRankGroupBox.Location = new System.Drawing.Point(838, 182);
            this.removeRankGroupBox.Name = "removeRankGroupBox";
            this.removeRankGroupBox.Size = new System.Drawing.Size(142, 54);
            this.removeRankGroupBox.TabIndex = 4;
            this.removeRankGroupBox.TabStop = false;
            // 
            // removeRankButton
            // 
            this.removeRankButton.Enabled = false;
            this.removeRankButton.Location = new System.Drawing.Point(6, 15);
            this.removeRankButton.Name = "removeRankButton";
            this.removeRankButton.Size = new System.Drawing.Size(130, 33);
            this.removeRankButton.TabIndex = 1;
            this.removeRankButton.Text = "remove rank";
            this.removeRankButton.UseVisualStyleBackColor = true;
            this.removeRankButton.Click += new System.EventHandler(this.removeRankButton_Click);
            // 
            // Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.removeRankGroupBox);
            this.Controls.Add(this.addRankGroupBox);
            this.Controls.Add(this.rankCountGroupBox);
            this.Controls.Add(this.skillsRemainingGroupBox);
            this.Controls.Add(this.descriptionGroupBox);
            this.Controls.Add(this.skillsMenuBox);
            this.Controls.Add(this.saveChangesButton);
            this.Name = "Skill";
            this.Text = "Skill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Skill_FormClosing);
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.skillsRemainingGroupBox.ResumeLayout(false);
            this.skillsRemainingGroupBox.PerformLayout();
            this.rankCountGroupBox.ResumeLayout(false);
            this.rankCountGroupBox.PerformLayout();
            this.addRankGroupBox.ResumeLayout(false);
            this.removeRankGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.ComboBox skillsMenuBox;
        private System.Windows.Forms.GroupBox descriptionGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.GroupBox skillsRemainingGroupBox;
        private System.Windows.Forms.TextBox skillCountTextBox;
        private System.Windows.Forms.GroupBox rankCountGroupBox;
        private System.Windows.Forms.TextBox rankCountTextBox;
        private System.Windows.Forms.GroupBox addRankGroupBox;
        private System.Windows.Forms.GroupBox removeRankGroupBox;
        private System.Windows.Forms.Button addRankButton;
        private System.Windows.Forms.Button removeRankButton;
    }
}