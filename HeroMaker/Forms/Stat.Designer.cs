namespace HeroMaker.Forms
{
    partial class Stat
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
            this.rollStatButton = new System.Windows.Forms.Button();
            this.rerollLastStatButton = new System.Windows.Forms.Button();
            this.rerollAllStatsButton = new System.Windows.Forms.Button();
            this.rerollsGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDiceRollTextBox = new System.Windows.Forms.TextBox();
            this.statRerollTextBox = new System.Windows.Forms.TextBox();
            this.charismaGroupBox = new System.Windows.Forms.GroupBox();
            this.constitutionGroupBox = new System.Windows.Forms.GroupBox();
            this.dexterityGroupBox = new System.Windows.Forms.GroupBox();
            this.intellectGroupBox = new System.Windows.Forms.GroupBox();
            this.strengthGroupBox = new System.Windows.Forms.GroupBox();
            this.wisdomGroupBox = new System.Windows.Forms.GroupBox();
            this.charismaValueTextBox = new System.Windows.Forms.TextBox();
            this.constitutionValueTextBox = new System.Windows.Forms.TextBox();
            this.dexterityValueTextBox = new System.Windows.Forms.TextBox();
            this.intellectValueTextBox = new System.Windows.Forms.TextBox();
            this.strengthValueTextBox = new System.Windows.Forms.TextBox();
            this.wisdomValueTextBox = new System.Windows.Forms.TextBox();
            this.intellectLockInButton = new System.Windows.Forms.Button();
            this.charismaLockInButton = new System.Windows.Forms.Button();
            this.constitutionLockInButton = new System.Windows.Forms.Button();
            this.strengthLockInButton = new System.Windows.Forms.Button();
            this.dexterityLockInButton = new System.Windows.Forms.Button();
            this.wisdomLockInButton = new System.Windows.Forms.Button();
            this.rerollsGroupBox.SuspendLayout();
            this.charismaGroupBox.SuspendLayout();
            this.constitutionGroupBox.SuspendLayout();
            this.dexterityGroupBox.SuspendLayout();
            this.intellectGroupBox.SuspendLayout();
            this.strengthGroupBox.SuspendLayout();
            this.wisdomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(735, 66);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(158, 48);
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Stats";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.NextState_Click);
            // 
            // rollStatButton
            // 
            this.rollStatButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rollStatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollStatButton.Location = new System.Drawing.Point(12, 12);
            this.rollStatButton.Name = "rollStatButton";
            this.rollStatButton.Size = new System.Drawing.Size(316, 48);
            this.rollStatButton.TabIndex = 1;
            this.rollStatButton.Text = "Roll Stat";
            this.rollStatButton.UseVisualStyleBackColor = false;
            // 
            // rerollLastStatButton
            // 
            this.rerollLastStatButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rerollLastStatButton.Enabled = false;
            this.rerollLastStatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rerollLastStatButton.Location = new System.Drawing.Point(334, 12);
            this.rerollLastStatButton.Name = "rerollLastStatButton";
            this.rerollLastStatButton.Size = new System.Drawing.Size(316, 48);
            this.rerollLastStatButton.TabIndex = 2;
            this.rerollLastStatButton.Text = "Reroll Last Stat";
            this.rerollLastStatButton.UseVisualStyleBackColor = false;
            // 
            // rerollAllStatsButton
            // 
            this.rerollAllStatsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rerollAllStatsButton.Enabled = false;
            this.rerollAllStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rerollAllStatsButton.Location = new System.Drawing.Point(656, 12);
            this.rerollAllStatsButton.Name = "rerollAllStatsButton";
            this.rerollAllStatsButton.Size = new System.Drawing.Size(316, 48);
            this.rerollAllStatsButton.TabIndex = 3;
            this.rerollAllStatsButton.Text = "Reroll All Stats";
            this.rerollAllStatsButton.UseVisualStyleBackColor = false;
            // 
            // rerollsGroupBox
            // 
            this.rerollsGroupBox.Controls.Add(this.statRerollTextBox);
            this.rerollsGroupBox.Controls.Add(this.currentDiceRollTextBox);
            this.rerollsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rerollsGroupBox.Location = new System.Drawing.Point(334, 112);
            this.rerollsGroupBox.Name = "rerollsGroupBox";
            this.rerollsGroupBox.Size = new System.Drawing.Size(316, 487);
            this.rerollsGroupBox.TabIndex = 4;
            this.rerollsGroupBox.TabStop = false;
            this.rerollsGroupBox.Text = "Current Dice Rolls";
            // 
            // currentDiceRollTextBox
            // 
            this.currentDiceRollTextBox.Location = new System.Drawing.Point(7, 26);
            this.currentDiceRollTextBox.Name = "currentDiceRollTextBox";
            this.currentDiceRollTextBox.Size = new System.Drawing.Size(303, 26);
            this.currentDiceRollTextBox.TabIndex = 0;
            // 
            // statRerollTextBox
            // 
            this.statRerollTextBox.Location = new System.Drawing.Point(7, 58);
            this.statRerollTextBox.Multiline = true;
            this.statRerollTextBox.Name = "statRerollTextBox";
            this.statRerollTextBox.Size = new System.Drawing.Size(303, 423);
            this.statRerollTextBox.TabIndex = 1;
            // 
            // charismaGroupBox
            // 
            this.charismaGroupBox.Controls.Add(this.charismaLockInButton);
            this.charismaGroupBox.Controls.Add(this.charismaValueTextBox);
            this.charismaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charismaGroupBox.Location = new System.Drawing.Point(12, 115);
            this.charismaGroupBox.Name = "charismaGroupBox";
            this.charismaGroupBox.Size = new System.Drawing.Size(316, 155);
            this.charismaGroupBox.TabIndex = 5;
            this.charismaGroupBox.TabStop = false;
            this.charismaGroupBox.Text = "CHARISMA";
            // 
            // constitutionGroupBox
            // 
            this.constitutionGroupBox.Controls.Add(this.constitutionLockInButton);
            this.constitutionGroupBox.Controls.Add(this.constitutionValueTextBox);
            this.constitutionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constitutionGroupBox.Location = new System.Drawing.Point(12, 276);
            this.constitutionGroupBox.Name = "constitutionGroupBox";
            this.constitutionGroupBox.Size = new System.Drawing.Size(316, 155);
            this.constitutionGroupBox.TabIndex = 6;
            this.constitutionGroupBox.TabStop = false;
            this.constitutionGroupBox.Text = "CONSTITUTION";
            // 
            // dexterityGroupBox
            // 
            this.dexterityGroupBox.Controls.Add(this.dexterityLockInButton);
            this.dexterityGroupBox.Controls.Add(this.dexterityValueTextBox);
            this.dexterityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityGroupBox.Location = new System.Drawing.Point(12, 437);
            this.dexterityGroupBox.Name = "dexterityGroupBox";
            this.dexterityGroupBox.Size = new System.Drawing.Size(316, 162);
            this.dexterityGroupBox.TabIndex = 6;
            this.dexterityGroupBox.TabStop = false;
            this.dexterityGroupBox.Text = "DEXTERITY";
            // 
            // intellectGroupBox
            // 
            this.intellectGroupBox.Controls.Add(this.intellectLockInButton);
            this.intellectGroupBox.Controls.Add(this.intellectValueTextBox);
            this.intellectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intellectGroupBox.Location = new System.Drawing.Point(656, 115);
            this.intellectGroupBox.Name = "intellectGroupBox";
            this.intellectGroupBox.Size = new System.Drawing.Size(316, 155);
            this.intellectGroupBox.TabIndex = 6;
            this.intellectGroupBox.TabStop = false;
            this.intellectGroupBox.Text = "INTELLECT";
            // 
            // strengthGroupBox
            // 
            this.strengthGroupBox.Controls.Add(this.strengthLockInButton);
            this.strengthGroupBox.Controls.Add(this.strengthValueTextBox);
            this.strengthGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthGroupBox.Location = new System.Drawing.Point(656, 276);
            this.strengthGroupBox.Name = "strengthGroupBox";
            this.strengthGroupBox.Size = new System.Drawing.Size(316, 155);
            this.strengthGroupBox.TabIndex = 6;
            this.strengthGroupBox.TabStop = false;
            this.strengthGroupBox.Text = "STRENGTH";
            // 
            // wisdomGroupBox
            // 
            this.wisdomGroupBox.Controls.Add(this.wisdomLockInButton);
            this.wisdomGroupBox.Controls.Add(this.wisdomValueTextBox);
            this.wisdomGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomGroupBox.Location = new System.Drawing.Point(656, 437);
            this.wisdomGroupBox.Name = "wisdomGroupBox";
            this.wisdomGroupBox.Size = new System.Drawing.Size(316, 162);
            this.wisdomGroupBox.TabIndex = 6;
            this.wisdomGroupBox.TabStop = false;
            this.wisdomGroupBox.Text = "WISDOM";
            // 
            // charismaValueTextBox
            // 
            this.charismaValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.charismaValueTextBox.Name = "charismaValueTextBox";
            this.charismaValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.charismaValueTextBox.TabIndex = 0;
            // 
            // constitutionValueTextBox
            // 
            this.constitutionValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.constitutionValueTextBox.Name = "constitutionValueTextBox";
            this.constitutionValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.constitutionValueTextBox.TabIndex = 0;
            // 
            // dexterityValueTextBox
            // 
            this.dexterityValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.dexterityValueTextBox.Name = "dexterityValueTextBox";
            this.dexterityValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.dexterityValueTextBox.TabIndex = 0;
            // 
            // intellectValueTextBox
            // 
            this.intellectValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.intellectValueTextBox.Name = "intellectValueTextBox";
            this.intellectValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.intellectValueTextBox.TabIndex = 0;
            // 
            // strengthValueTextBox
            // 
            this.strengthValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.strengthValueTextBox.Name = "strengthValueTextBox";
            this.strengthValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.strengthValueTextBox.TabIndex = 0;
            // 
            // wisdomValueTextBox
            // 
            this.wisdomValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.wisdomValueTextBox.Name = "wisdomValueTextBox";
            this.wisdomValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.wisdomValueTextBox.TabIndex = 0;
            // 
            // intellectLockInButton
            // 
            this.intellectLockInButton.Location = new System.Drawing.Point(79, 78);
            this.intellectLockInButton.Name = "intellectLockInButton";
            this.intellectLockInButton.Size = new System.Drawing.Size(158, 48);
            this.intellectLockInButton.TabIndex = 4;
            this.intellectLockInButton.Text = "Lock In";
            this.intellectLockInButton.UseVisualStyleBackColor = true;
            // 
            // charismaLockInButton
            // 
            this.charismaLockInButton.Location = new System.Drawing.Point(76, 78);
            this.charismaLockInButton.Name = "charismaLockInButton";
            this.charismaLockInButton.Size = new System.Drawing.Size(158, 48);
            this.charismaLockInButton.TabIndex = 5;
            this.charismaLockInButton.Text = "Lock In";
            this.charismaLockInButton.UseVisualStyleBackColor = true;
            // 
            // constitutionLockInButton
            // 
            this.constitutionLockInButton.Location = new System.Drawing.Point(76, 80);
            this.constitutionLockInButton.Name = "constitutionLockInButton";
            this.constitutionLockInButton.Size = new System.Drawing.Size(158, 48);
            this.constitutionLockInButton.TabIndex = 5;
            this.constitutionLockInButton.Text = "Lock In";
            this.constitutionLockInButton.UseVisualStyleBackColor = true;
            // 
            // strengthLockInButton
            // 
            this.strengthLockInButton.Location = new System.Drawing.Point(79, 80);
            this.strengthLockInButton.Name = "strengthLockInButton";
            this.strengthLockInButton.Size = new System.Drawing.Size(158, 48);
            this.strengthLockInButton.TabIndex = 6;
            this.strengthLockInButton.Text = "Lock In";
            this.strengthLockInButton.UseVisualStyleBackColor = true;
            // 
            // dexterityLockInButton
            // 
            this.dexterityLockInButton.Location = new System.Drawing.Point(76, 84);
            this.dexterityLockInButton.Name = "dexterityLockInButton";
            this.dexterityLockInButton.Size = new System.Drawing.Size(158, 48);
            this.dexterityLockInButton.TabIndex = 6;
            this.dexterityLockInButton.Text = "Lock In";
            this.dexterityLockInButton.UseVisualStyleBackColor = true;
            // 
            // wisdomLockInButton
            // 
            this.wisdomLockInButton.Location = new System.Drawing.Point(79, 84);
            this.wisdomLockInButton.Name = "wisdomLockInButton";
            this.wisdomLockInButton.Size = new System.Drawing.Size(158, 48);
            this.wisdomLockInButton.TabIndex = 7;
            this.wisdomLockInButton.Text = "Lock In";
            this.wisdomLockInButton.UseVisualStyleBackColor = true;
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.wisdomGroupBox);
            this.Controls.Add(this.strengthGroupBox);
            this.Controls.Add(this.intellectGroupBox);
            this.Controls.Add(this.dexterityGroupBox);
            this.Controls.Add(this.constitutionGroupBox);
            this.Controls.Add(this.charismaGroupBox);
            this.Controls.Add(this.rerollsGroupBox);
            this.Controls.Add(this.rerollAllStatsButton);
            this.Controls.Add(this.rerollLastStatButton);
            this.Controls.Add(this.rollStatButton);
            this.Controls.Add(this.saveChangesButton);
            this.Name = "Stat";
            this.Text = "Stat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stat_FormClosing);
            this.Load += new System.EventHandler(this.Stat_Load);
            this.rerollsGroupBox.ResumeLayout(false);
            this.rerollsGroupBox.PerformLayout();
            this.charismaGroupBox.ResumeLayout(false);
            this.charismaGroupBox.PerformLayout();
            this.constitutionGroupBox.ResumeLayout(false);
            this.constitutionGroupBox.PerformLayout();
            this.dexterityGroupBox.ResumeLayout(false);
            this.dexterityGroupBox.PerformLayout();
            this.intellectGroupBox.ResumeLayout(false);
            this.intellectGroupBox.PerformLayout();
            this.strengthGroupBox.ResumeLayout(false);
            this.strengthGroupBox.PerformLayout();
            this.wisdomGroupBox.ResumeLayout(false);
            this.wisdomGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button rollStatButton;
        private System.Windows.Forms.Button rerollLastStatButton;
        private System.Windows.Forms.Button rerollAllStatsButton;
        private System.Windows.Forms.GroupBox rerollsGroupBox;
        private System.Windows.Forms.TextBox statRerollTextBox;
        private System.Windows.Forms.TextBox currentDiceRollTextBox;
        private System.Windows.Forms.GroupBox charismaGroupBox;
        private System.Windows.Forms.GroupBox constitutionGroupBox;
        private System.Windows.Forms.GroupBox dexterityGroupBox;
        private System.Windows.Forms.GroupBox intellectGroupBox;
        private System.Windows.Forms.GroupBox strengthGroupBox;
        private System.Windows.Forms.GroupBox wisdomGroupBox;
        private System.Windows.Forms.Button charismaLockInButton;
        private System.Windows.Forms.TextBox charismaValueTextBox;
        private System.Windows.Forms.Button constitutionLockInButton;
        private System.Windows.Forms.TextBox constitutionValueTextBox;
        private System.Windows.Forms.Button dexterityLockInButton;
        private System.Windows.Forms.TextBox dexterityValueTextBox;
        private System.Windows.Forms.Button intellectLockInButton;
        private System.Windows.Forms.TextBox intellectValueTextBox;
        private System.Windows.Forms.Button strengthLockInButton;
        private System.Windows.Forms.TextBox strengthValueTextBox;
        private System.Windows.Forms.Button wisdomLockInButton;
        private System.Windows.Forms.TextBox wisdomValueTextBox;
    }
}