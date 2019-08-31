namespace DnDPlayerTrackerUI
{
    partial class PlayerTrackerUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerTrackerUIForm));
            this.MainProgramLabel = new System.Windows.Forms.Label();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.NewCharacterButton = new System.Windows.Forms.Button();
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainProgramLabel
            // 
            this.MainProgramLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainProgramLabel.AutoSize = true;
            this.MainProgramLabel.Font = new System.Drawing.Font("Immortal", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainProgramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainProgramLabel.Location = new System.Drawing.Point(108, 91);
            this.MainProgramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainProgramLabel.Name = "MainProgramLabel";
            this.MainProgramLabel.Size = new System.Drawing.Size(682, 80);
            this.MainProgramLabel.TabIndex = 0;
            this.MainProgramLabel.Text = "DnD Player Tracker";
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Font = new System.Drawing.Font("Immortal", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainMenuLabel.Location = new System.Drawing.Point(332, 194);
            this.MainMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(234, 46);
            this.MainMenuLabel.TabIndex = 1;
            this.MainMenuLabel.Text = "Main Menu";
            // 
            // NewCharacterButton
            // 
            this.NewCharacterButton.BackColor = System.Drawing.Color.Silver;
            this.NewCharacterButton.Font = new System.Drawing.Font("Immortal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCharacterButton.Location = new System.Drawing.Point(336, 281);
            this.NewCharacterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewCharacterButton.Name = "NewCharacterButton";
            this.NewCharacterButton.Size = new System.Drawing.Size(226, 45);
            this.NewCharacterButton.TabIndex = 2;
            this.NewCharacterButton.Text = "New Character";
            this.NewCharacterButton.UseVisualStyleBackColor = false;
            this.NewCharacterButton.Click += new System.EventHandler(this.NewCharacterButton_Click);
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.BackColor = System.Drawing.Color.Silver;
            this.LoadProfileButton.Font = new System.Drawing.Font("Immortal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfileButton.Location = new System.Drawing.Point(336, 352);
            this.LoadProfileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(226, 45);
            this.LoadProfileButton.TabIndex = 3;
            this.LoadProfileButton.Text = "Load Profile";
            this.LoadProfileButton.UseVisualStyleBackColor = false;
            this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteProfileButton.Font = new System.Drawing.Font("Immortal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProfileButton.Location = new System.Drawing.Point(336, 423);
            this.DeleteProfileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(226, 45);
            this.DeleteProfileButton.TabIndex = 4;
            this.DeleteProfileButton.Text = "Delete Profile";
            this.DeleteProfileButton.UseVisualStyleBackColor = false;
            // 
            // PlayerTrackerUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(898, 559);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.LoadProfileButton);
            this.Controls.Add(this.NewCharacterButton);
            this.Controls.Add(this.MainMenuLabel);
            this.Controls.Add(this.MainProgramLabel);
            this.Font = new System.Drawing.Font("Immortal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PlayerTrackerUIForm";
            this.Text = "Dnd Player Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainProgramLabel;
        private System.Windows.Forms.Label MainMenuLabel;

        
        private System.Windows.Forms.Button NewCharacterButton;
        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.Button DeleteProfileButton;
    }
}

