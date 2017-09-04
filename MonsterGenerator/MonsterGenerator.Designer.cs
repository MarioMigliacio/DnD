namespace MonsterGenerator
{
    partial class MonsterGenerator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortByChallengeRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.challengeRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterBiomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preview = new System.Windows.Forms.GroupBox();
            this.PreviewValue = new System.Windows.Forms.TextBox();
            this.saveThisPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByChallengeRatingToolStripMenuItem,
            this.saveThisPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortByChallengeRatingToolStripMenuItem
            // 
            this.sortByChallengeRatingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.challengeRatingToolStripMenuItem,
            this.monsterTypeToolStripMenuItem,
            this.monsterBiomeToolStripMenuItem,
            this.alphabeticalToolStripMenuItem});
            this.sortByChallengeRatingToolStripMenuItem.Name = "sortByChallengeRatingToolStripMenuItem";
            this.sortByChallengeRatingToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.sortByChallengeRatingToolStripMenuItem.Text = "Sorting Options";
            // 
            // challengeRatingToolStripMenuItem
            // 
            this.challengeRatingToolStripMenuItem.Name = "challengeRatingToolStripMenuItem";
            this.challengeRatingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.challengeRatingToolStripMenuItem.Text = "Challenge Rating";
            // 
            // monsterTypeToolStripMenuItem
            // 
            this.monsterTypeToolStripMenuItem.Name = "monsterTypeToolStripMenuItem";
            this.monsterTypeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.monsterTypeToolStripMenuItem.Text = "Monster Type";
            // 
            // monsterBiomeToolStripMenuItem
            // 
            this.monsterBiomeToolStripMenuItem.Name = "monsterBiomeToolStripMenuItem";
            this.monsterBiomeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.monsterBiomeToolStripMenuItem.Text = "Monster Biome";
            // 
            // alphabeticalToolStripMenuItem
            // 
            this.alphabeticalToolStripMenuItem.Name = "alphabeticalToolStripMenuItem";
            this.alphabeticalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.alphabeticalToolStripMenuItem.Text = "Alphabetical";
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.PreviewValue);
            this.Preview.Location = new System.Drawing.Point(466, 38);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(390, 462);
            this.Preview.TabIndex = 2;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            // 
            // PreviewValue
            // 
            this.PreviewValue.Location = new System.Drawing.Point(6, 19);
            this.PreviewValue.Multiline = true;
            this.PreviewValue.Name = "PreviewValue";
            this.PreviewValue.ReadOnly = true;
            this.PreviewValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreviewValue.Size = new System.Drawing.Size(377, 437);
            this.PreviewValue.TabIndex = 0;
            // 
            // saveThisPreviewToolStripMenuItem
            // 
            this.saveThisPreviewToolStripMenuItem.Name = "saveThisPreviewToolStripMenuItem";
            this.saveThisPreviewToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.saveThisPreviewToolStripMenuItem.Text = "Save This Preview";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(347, 55);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add To Preview";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(347, 85);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(113, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove From Preview";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // MonsterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MonsterGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.Preview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortByChallengeRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengeRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monsterTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monsterBiomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveThisPreviewToolStripMenuItem;
        private System.Windows.Forms.GroupBox Preview;
        private System.Windows.Forms.TextBox PreviewValue;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}

