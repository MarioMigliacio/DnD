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
            this.rerollAllStatsButton = new System.Windows.Forms.Button();
            this.rerollsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statRollsTextBox = new System.Windows.Forms.TextBox();
            this.currentDiceRollTextBox = new System.Windows.Forms.TextBox();
            this.charismaGroupBox = new System.Windows.Forms.GroupBox();
            this.charismaLockInButton = new System.Windows.Forms.Button();
            this.charismaValueTextBox = new System.Windows.Forms.TextBox();
            this.constitutionGroupBox = new System.Windows.Forms.GroupBox();
            this.constitutionLockInButton = new System.Windows.Forms.Button();
            this.constitutionValueTextBox = new System.Windows.Forms.TextBox();
            this.dexterityGroupBox = new System.Windows.Forms.GroupBox();
            this.dexterityLockInButton = new System.Windows.Forms.Button();
            this.dexterityValueTextBox = new System.Windows.Forms.TextBox();
            this.intellectGroupBox = new System.Windows.Forms.GroupBox();
            this.intellectLockInButton = new System.Windows.Forms.Button();
            this.intellectValueTextBox = new System.Windows.Forms.TextBox();
            this.strengthGroupBox = new System.Windows.Forms.GroupBox();
            this.strengthLockInButton = new System.Windows.Forms.Button();
            this.strengthValueTextBox = new System.Windows.Forms.TextBox();
            this.wisdomGroupBox = new System.Windows.Forms.GroupBox();
            this.wisdomLockInButton = new System.Windows.Forms.Button();
            this.wisdomValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rerollCountTextBox = new System.Windows.Forms.TextBox();
            this.rerollsGroupBox.SuspendLayout();
            this.charismaGroupBox.SuspendLayout();
            this.constitutionGroupBox.SuspendLayout();
            this.dexterityGroupBox.SuspendLayout();
            this.intellectGroupBox.SuspendLayout();
            this.strengthGroupBox.SuspendLayout();
            this.wisdomGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(735, 12);
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
            this.rollStatButton.Click += new System.EventHandler(this.rollStatButton_Click);
            // 
            // rerollAllStatsButton
            // 
            this.rerollAllStatsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rerollAllStatsButton.Enabled = false;
            this.rerollAllStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rerollAllStatsButton.Location = new System.Drawing.Point(12, 61);
            this.rerollAllStatsButton.Name = "rerollAllStatsButton";
            this.rerollAllStatsButton.Size = new System.Drawing.Size(316, 48);
            this.rerollAllStatsButton.TabIndex = 3;
            this.rerollAllStatsButton.Text = "Reroll All Stats";
            this.rerollAllStatsButton.UseVisualStyleBackColor = false;
            this.rerollAllStatsButton.Click += new System.EventHandler(this.rerollAllStatsButton_Click);
            // 
            // rerollsGroupBox
            // 
            this.rerollsGroupBox.Controls.Add(this.label1);
            this.rerollsGroupBox.Controls.Add(this.statRollsTextBox);
            this.rerollsGroupBox.Controls.Add(this.currentDiceRollTextBox);
            this.rerollsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rerollsGroupBox.Location = new System.Drawing.Point(334, 112);
            this.rerollsGroupBox.Name = "rerollsGroupBox";
            this.rerollsGroupBox.Size = new System.Drawing.Size(316, 487);
            this.rerollsGroupBox.TabIndex = 4;
            this.rerollsGroupBox.TabStop = false;
            this.rerollsGroupBox.Text = "Current Die To Be Placed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Remaining Dice";
            // 
            // statRollsTextBox
            // 
            this.statRollsTextBox.Enabled = false;
            this.statRollsTextBox.Location = new System.Drawing.Point(7, 108);
            this.statRollsTextBox.Multiline = true;
            this.statRollsTextBox.Name = "statRollsTextBox";
            this.statRollsTextBox.ReadOnly = true;
            this.statRollsTextBox.Size = new System.Drawing.Size(303, 373);
            this.statRollsTextBox.TabIndex = 1;
            // 
            // currentDiceRollTextBox
            // 
            this.currentDiceRollTextBox.Enabled = false;
            this.currentDiceRollTextBox.Location = new System.Drawing.Point(7, 26);
            this.currentDiceRollTextBox.Name = "currentDiceRollTextBox";
            this.currentDiceRollTextBox.ReadOnly = true;
            this.currentDiceRollTextBox.Size = new System.Drawing.Size(303, 26);
            this.currentDiceRollTextBox.TabIndex = 0;
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
            // charismaLockInButton
            // 
            this.charismaLockInButton.Enabled = false;
            this.charismaLockInButton.Location = new System.Drawing.Point(76, 78);
            this.charismaLockInButton.Name = "charismaLockInButton";
            this.charismaLockInButton.Size = new System.Drawing.Size(158, 48);
            this.charismaLockInButton.TabIndex = 5;
            this.charismaLockInButton.Text = "Lock In";
            this.charismaLockInButton.UseVisualStyleBackColor = true;
            this.charismaLockInButton.Click += new System.EventHandler(this.charismaLockInButton_Click);
            // 
            // charismaValueTextBox
            // 
            this.charismaValueTextBox.Enabled = false;
            this.charismaValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.charismaValueTextBox.Name = "charismaValueTextBox";
            this.charismaValueTextBox.ReadOnly = true;
            this.charismaValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.charismaValueTextBox.TabIndex = 0;
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
            // constitutionLockInButton
            // 
            this.constitutionLockInButton.Enabled = false;
            this.constitutionLockInButton.Location = new System.Drawing.Point(76, 80);
            this.constitutionLockInButton.Name = "constitutionLockInButton";
            this.constitutionLockInButton.Size = new System.Drawing.Size(158, 48);
            this.constitutionLockInButton.TabIndex = 5;
            this.constitutionLockInButton.Text = "Lock In";
            this.constitutionLockInButton.UseVisualStyleBackColor = true;
            this.constitutionLockInButton.Click += new System.EventHandler(this.constitutionLockInButton_Click);
            // 
            // constitutionValueTextBox
            // 
            this.constitutionValueTextBox.Enabled = false;
            this.constitutionValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.constitutionValueTextBox.Name = "constitutionValueTextBox";
            this.constitutionValueTextBox.ReadOnly = true;
            this.constitutionValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.constitutionValueTextBox.TabIndex = 0;
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
            // dexterityLockInButton
            // 
            this.dexterityLockInButton.Enabled = false;
            this.dexterityLockInButton.Location = new System.Drawing.Point(76, 84);
            this.dexterityLockInButton.Name = "dexterityLockInButton";
            this.dexterityLockInButton.Size = new System.Drawing.Size(158, 48);
            this.dexterityLockInButton.TabIndex = 6;
            this.dexterityLockInButton.Text = "Lock In";
            this.dexterityLockInButton.UseVisualStyleBackColor = true;
            this.dexterityLockInButton.Click += new System.EventHandler(this.dexterityLockInButton_Click);
            // 
            // dexterityValueTextBox
            // 
            this.dexterityValueTextBox.Enabled = false;
            this.dexterityValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.dexterityValueTextBox.Name = "dexterityValueTextBox";
            this.dexterityValueTextBox.ReadOnly = true;
            this.dexterityValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.dexterityValueTextBox.TabIndex = 0;
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
            // intellectLockInButton
            // 
            this.intellectLockInButton.Enabled = false;
            this.intellectLockInButton.Location = new System.Drawing.Point(79, 78);
            this.intellectLockInButton.Name = "intellectLockInButton";
            this.intellectLockInButton.Size = new System.Drawing.Size(158, 48);
            this.intellectLockInButton.TabIndex = 4;
            this.intellectLockInButton.Text = "Lock In";
            this.intellectLockInButton.UseVisualStyleBackColor = true;
            this.intellectLockInButton.Click += new System.EventHandler(this.intellectLockInButton_Click);
            // 
            // intellectValueTextBox
            // 
            this.intellectValueTextBox.Enabled = false;
            this.intellectValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.intellectValueTextBox.Name = "intellectValueTextBox";
            this.intellectValueTextBox.ReadOnly = true;
            this.intellectValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.intellectValueTextBox.TabIndex = 0;
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
            // strengthLockInButton
            // 
            this.strengthLockInButton.Enabled = false;
            this.strengthLockInButton.Location = new System.Drawing.Point(79, 80);
            this.strengthLockInButton.Name = "strengthLockInButton";
            this.strengthLockInButton.Size = new System.Drawing.Size(158, 48);
            this.strengthLockInButton.TabIndex = 6;
            this.strengthLockInButton.Text = "Lock In";
            this.strengthLockInButton.UseVisualStyleBackColor = true;
            this.strengthLockInButton.Click += new System.EventHandler(this.strengthLockInButton_Click);
            // 
            // strengthValueTextBox
            // 
            this.strengthValueTextBox.Enabled = false;
            this.strengthValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.strengthValueTextBox.Name = "strengthValueTextBox";
            this.strengthValueTextBox.ReadOnly = true;
            this.strengthValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.strengthValueTextBox.TabIndex = 0;
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
            // wisdomLockInButton
            // 
            this.wisdomLockInButton.Enabled = false;
            this.wisdomLockInButton.Location = new System.Drawing.Point(79, 84);
            this.wisdomLockInButton.Name = "wisdomLockInButton";
            this.wisdomLockInButton.Size = new System.Drawing.Size(158, 48);
            this.wisdomLockInButton.TabIndex = 7;
            this.wisdomLockInButton.Text = "Lock In";
            this.wisdomLockInButton.UseVisualStyleBackColor = true;
            this.wisdomLockInButton.Click += new System.EventHandler(this.wisdomLockInButton_Click);
            // 
            // wisdomValueTextBox
            // 
            this.wisdomValueTextBox.Enabled = false;
            this.wisdomValueTextBox.Location = new System.Drawing.Point(7, 26);
            this.wisdomValueTextBox.Name = "wisdomValueTextBox";
            this.wisdomValueTextBox.ReadOnly = true;
            this.wisdomValueTextBox.Size = new System.Drawing.Size(303, 26);
            this.wisdomValueTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rerollCountTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rerolls Remaining";
            // 
            // rerollCountTextBox
            // 
            this.rerollCountTextBox.Enabled = false;
            this.rerollCountTextBox.Location = new System.Drawing.Point(6, 20);
            this.rerollCountTextBox.Name = "rerollCountTextBox";
            this.rerollCountTextBox.ReadOnly = true;
            this.rerollCountTextBox.Size = new System.Drawing.Size(140, 22);
            this.rerollCountTextBox.TabIndex = 0;
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wisdomGroupBox);
            this.Controls.Add(this.strengthGroupBox);
            this.Controls.Add(this.intellectGroupBox);
            this.Controls.Add(this.dexterityGroupBox);
            this.Controls.Add(this.constitutionGroupBox);
            this.Controls.Add(this.charismaGroupBox);
            this.Controls.Add(this.rerollsGroupBox);
            this.Controls.Add(this.rerollAllStatsButton);
            this.Controls.Add(this.rollStatButton);
            this.Controls.Add(this.saveChangesButton);
            this.MaximizeBox = false;
            this.Name = "Stat";
            this.Text = "Stat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stat_FormClosing);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button rollStatButton;
        private System.Windows.Forms.Button rerollAllStatsButton;
        private System.Windows.Forms.GroupBox rerollsGroupBox;
        private System.Windows.Forms.TextBox statRollsTextBox;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rerollCountTextBox;
        private System.Windows.Forms.Label label1;
    }
}