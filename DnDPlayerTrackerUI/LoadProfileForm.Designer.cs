namespace DnDPlayerTrackerUI
{
    partial class LoadProfileForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadProfileForm));
            this.LoadProfileLabel = new System.Windows.Forms.Label();
            this.SelectProfileComboBox = new System.Windows.Forms.ComboBox();
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.ReturnMainButton = new System.Windows.Forms.Button();
            this.dnDPlayerTrackerDataSet = new DnDPlayerTrackerUI.DnDPlayerTrackerDataSet();
            this.dnDPlayerTrackerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dnDPlayerTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDPlayerTrackerDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadProfileLabel
            // 
            this.LoadProfileLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoadProfileLabel.AutoSize = true;
            this.LoadProfileLabel.Font = new System.Drawing.Font("Immortal", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadProfileLabel.Location = new System.Drawing.Point(284, 55);
            this.LoadProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadProfileLabel.Name = "LoadProfileLabel";
            this.LoadProfileLabel.Size = new System.Drawing.Size(242, 46);
            this.LoadProfileLabel.TabIndex = 2;
            this.LoadProfileLabel.Text = "Load Profile";
            // 
            // SelectProfileComboBox
            // 
            this.SelectProfileComboBox.FormattingEnabled = true;
            this.SelectProfileComboBox.Location = new System.Drawing.Point(206, 140);
            this.SelectProfileComboBox.Name = "SelectProfileComboBox";
            this.SelectProfileComboBox.Size = new System.Drawing.Size(392, 35);
            this.SelectProfileComboBox.TabIndex = 3;
            this.SelectProfileComboBox.Click += new System.EventHandler(this.SelectProfileComboBox_Click);
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.BackColor = System.Drawing.Color.Silver;
            this.LoadProfileButton.Font = new System.Drawing.Font("Immortal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfileButton.Location = new System.Drawing.Point(258, 235);
            this.LoadProfileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(298, 45);
            this.LoadProfileButton.TabIndex = 4;
            this.LoadProfileButton.Text = "Load Profile";
            this.LoadProfileButton.UseVisualStyleBackColor = false;
            this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // ReturnMainButton
            // 
            this.ReturnMainButton.BackColor = System.Drawing.Color.Silver;
            this.ReturnMainButton.Font = new System.Drawing.Font("Immortal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMainButton.Location = new System.Drawing.Point(258, 286);
            this.ReturnMainButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReturnMainButton.Name = "ReturnMainButton";
            this.ReturnMainButton.Size = new System.Drawing.Size(298, 45);
            this.ReturnMainButton.TabIndex = 5;
            this.ReturnMainButton.Text = "Return To Main Menu";
            this.ReturnMainButton.UseVisualStyleBackColor = false;
            this.ReturnMainButton.Click += new System.EventHandler(this.ReturnMainButton_Click);
            // 
            // dnDPlayerTrackerDataSet
            // 
            this.dnDPlayerTrackerDataSet.DataSetName = "DnDPlayerTrackerDataSet";
            this.dnDPlayerTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dnDPlayerTrackerDataSetBindingSource
            // 
            this.dnDPlayerTrackerDataSetBindingSource.DataSource = this.dnDPlayerTrackerDataSet;
            this.dnDPlayerTrackerDataSetBindingSource.Position = 0;
            // 
            // LoadProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 390);
            this.Controls.Add(this.ReturnMainButton);
            this.Controls.Add(this.LoadProfileButton);
            this.Controls.Add(this.SelectProfileComboBox);
            this.Controls.Add(this.LoadProfileLabel);
            this.Font = new System.Drawing.Font("Immortal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "LoadProfileForm";
            this.Text = "Load Profile";
            ((System.ComponentModel.ISupportInitialize)(this.dnDPlayerTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDPlayerTrackerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoadProfileLabel;
        private System.Windows.Forms.ComboBox SelectProfileComboBox;
        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.Button ReturnMainButton;
        private DnDPlayerTrackerDataSet dnDPlayerTrackerDataSet;
        private System.Windows.Forms.BindingSource dnDPlayerTrackerDataSetBindingSource;
    }
}