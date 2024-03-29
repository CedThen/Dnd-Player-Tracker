﻿namespace DnDPlayerTrackerUI
{
    partial class CharacterCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreationForm));
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.CharacterLevelTextBox = new System.Windows.Forms.TextBox();
            this.CharacterExpTextBox = new System.Windows.Forms.TextBox();
            this.StrGroupBox = new System.Windows.Forms.GroupBox();
            this.StrModLabel = new System.Windows.Forms.Label();
            this.StrTextBox = new System.Windows.Forms.TextBox();
            this.DexGroupBox = new System.Windows.Forms.GroupBox();
            this.DexModLabel = new System.Windows.Forms.Label();
            this.DexTextBox = new System.Windows.Forms.TextBox();
            this.ConGroupBox = new System.Windows.Forms.GroupBox();
            this.ConModLabel = new System.Windows.Forms.Label();
            this.ConTextBox = new System.Windows.Forms.TextBox();
            this.IntGroupBox = new System.Windows.Forms.GroupBox();
            this.IntModLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.WisGroupBox = new System.Windows.Forms.GroupBox();
            this.WisModLabel = new System.Windows.Forms.Label();
            this.WisTextBox = new System.Windows.Forms.TextBox();
            this.ChaGroupBox = new System.Windows.Forms.GroupBox();
            this.ChaModLabel = new System.Windows.Forms.Label();
            this.ChaTextBox = new System.Windows.Forms.TextBox();
            this.CurrentHPTextBox = new System.Windows.Forms.TextBox();
            this.TotalHpTextBox = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ExpLevel = new System.Windows.Forms.Label();
            this.TotalHPLabel = new System.Windows.Forms.Label();
            this.CurrentHPLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.InitiativeLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.InitiativeTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.ArmorClassLabel = new System.Windows.Forms.Label();
            this.ArmorClassTextBox = new System.Windows.Forms.TextBox();
            this.HitDiceTextBox = new System.Windows.Forms.TextBox();
            this.HitDiceLabel = new System.Windows.Forms.Label();
            this.ProficiencyGroupBox = new System.Windows.Forms.GroupBox();
            this.ProficiencyPlusLabel = new System.Windows.Forms.Label();
            this.ProficiencyTextBox = new System.Windows.Forms.TextBox();
            this.CreateProfileButton = new System.Windows.Forms.Button();
            this.StrGroupBox.SuspendLayout();
            this.DexGroupBox.SuspendLayout();
            this.ConGroupBox.SuspendLayout();
            this.IntGroupBox.SuspendLayout();
            this.WisGroupBox.SuspendLayout();
            this.ChaGroupBox.SuspendLayout();
            this.ProficiencyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CharacterNameTextBox.Font = new System.Drawing.Font("Immortal", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(616, 67);
            this.CharacterNameTextBox.TabIndex = 1;
            this.CharacterNameTextBox.Text = "Character Name";
            this.CharacterNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterNameTextBox.Click += new System.EventHandler(this.CharacterNameTextBox_MouseClick);
            this.CharacterNameTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // CharacterLevelTextBox
            // 
            this.CharacterLevelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CharacterLevelTextBox.Location = new System.Drawing.Point(709, 6);
            this.CharacterLevelTextBox.Name = "CharacterLevelTextBox";
            this.CharacterLevelTextBox.Size = new System.Drawing.Size(127, 33);
            this.CharacterLevelTextBox.TabIndex = 2;
            this.CharacterLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterLevelTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.CharacterLevelTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // CharacterExpTextBox
            // 
            this.CharacterExpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CharacterExpTextBox.Location = new System.Drawing.Point(709, 45);
            this.CharacterExpTextBox.Name = "CharacterExpTextBox";
            this.CharacterExpTextBox.Size = new System.Drawing.Size(127, 33);
            this.CharacterExpTextBox.TabIndex = 3;
            this.CharacterExpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterExpTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.CharacterExpTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // StrGroupBox
            // 
            this.StrGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StrGroupBox.Controls.Add(this.StrModLabel);
            this.StrGroupBox.Controls.Add(this.StrTextBox);
            this.StrGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.StrGroupBox.Location = new System.Drawing.Point(12, 153);
            this.StrGroupBox.Name = "StrGroupBox";
            this.StrGroupBox.Size = new System.Drawing.Size(113, 100);
            this.StrGroupBox.TabIndex = 9;
            this.StrGroupBox.TabStop = false;
            this.StrGroupBox.Text = "Strength";
            this.StrGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // StrModLabel
            // 
            this.StrModLabel.AutoSize = true;
            this.StrModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrModLabel.Location = new System.Drawing.Point(29, 30);
            this.StrModLabel.Name = "StrModLabel";
            this.StrModLabel.Size = new System.Drawing.Size(59, 43);
            this.StrModLabel.TabIndex = 1;
            this.StrModLabel.Text = "+2";
            this.StrModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrTextBox
            // 
            this.StrTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StrTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrTextBox.Location = new System.Drawing.Point(23, 76);
            this.StrTextBox.Name = "StrTextBox";
            this.StrTextBox.Size = new System.Drawing.Size(65, 24);
            this.StrTextBox.TabIndex = 0;
            this.StrTextBox.Text = "Str";
            this.StrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrTextBox.Click += new System.EventHandler(this.StrTextBox_MouseClick);
            this.StrTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // DexGroupBox
            // 
            this.DexGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DexGroupBox.Controls.Add(this.DexModLabel);
            this.DexGroupBox.Controls.Add(this.DexTextBox);
            this.DexGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.DexGroupBox.Location = new System.Drawing.Point(12, 259);
            this.DexGroupBox.Name = "DexGroupBox";
            this.DexGroupBox.Size = new System.Drawing.Size(113, 100);
            this.DexGroupBox.TabIndex = 10;
            this.DexGroupBox.TabStop = false;
            this.DexGroupBox.Text = "Dexterity";
            this.DexGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // DexModLabel
            // 
            this.DexModLabel.AutoSize = true;
            this.DexModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexModLabel.Location = new System.Drawing.Point(29, 29);
            this.DexModLabel.Name = "DexModLabel";
            this.DexModLabel.Size = new System.Drawing.Size(59, 43);
            this.DexModLabel.TabIndex = 1;
            this.DexModLabel.Text = "+2";
            // 
            // DexTextBox
            // 
            this.DexTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DexTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexTextBox.Location = new System.Drawing.Point(23, 76);
            this.DexTextBox.Name = "DexTextBox";
            this.DexTextBox.Size = new System.Drawing.Size(65, 24);
            this.DexTextBox.TabIndex = 0;
            this.DexTextBox.Text = "Dex";
            this.DexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DexTextBox.Click += new System.EventHandler(this.DexTextBox_MouseClick);
            this.DexTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // ConGroupBox
            // 
            this.ConGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ConGroupBox.Controls.Add(this.ConModLabel);
            this.ConGroupBox.Controls.Add(this.ConTextBox);
            this.ConGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.ConGroupBox.Location = new System.Drawing.Point(12, 365);
            this.ConGroupBox.Name = "ConGroupBox";
            this.ConGroupBox.Size = new System.Drawing.Size(113, 100);
            this.ConGroupBox.TabIndex = 10;
            this.ConGroupBox.TabStop = false;
            this.ConGroupBox.Text = "Constitution";
            this.ConGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // ConModLabel
            // 
            this.ConModLabel.AutoSize = true;
            this.ConModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConModLabel.Location = new System.Drawing.Point(29, 29);
            this.ConModLabel.Name = "ConModLabel";
            this.ConModLabel.Size = new System.Drawing.Size(59, 43);
            this.ConModLabel.TabIndex = 1;
            this.ConModLabel.Text = "+2";
            // 
            // ConTextBox
            // 
            this.ConTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConTextBox.Location = new System.Drawing.Point(23, 76);
            this.ConTextBox.Name = "ConTextBox";
            this.ConTextBox.Size = new System.Drawing.Size(65, 24);
            this.ConTextBox.TabIndex = 0;
            this.ConTextBox.Text = "Con";
            this.ConTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConTextBox.Click += new System.EventHandler(this.ConTextBox_MouseClick);
            this.ConTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // IntGroupBox
            // 
            this.IntGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IntGroupBox.Controls.Add(this.IntModLabel);
            this.IntGroupBox.Controls.Add(this.IntTextBox);
            this.IntGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.IntGroupBox.Location = new System.Drawing.Point(12, 471);
            this.IntGroupBox.Name = "IntGroupBox";
            this.IntGroupBox.Size = new System.Drawing.Size(113, 100);
            this.IntGroupBox.TabIndex = 10;
            this.IntGroupBox.TabStop = false;
            this.IntGroupBox.Text = "Intelligence";
            this.IntGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // IntModLabel
            // 
            this.IntModLabel.AutoSize = true;
            this.IntModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntModLabel.Location = new System.Drawing.Point(29, 29);
            this.IntModLabel.Name = "IntModLabel";
            this.IntModLabel.Size = new System.Drawing.Size(59, 43);
            this.IntModLabel.TabIndex = 1;
            this.IntModLabel.Text = "+2";
            // 
            // IntTextBox
            // 
            this.IntTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IntTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntTextBox.Location = new System.Drawing.Point(23, 76);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(65, 24);
            this.IntTextBox.TabIndex = 0;
            this.IntTextBox.Text = "Int";
            this.IntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntTextBox.Click += new System.EventHandler(this.IntTextBox_MouseClick);
            this.IntTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // WisGroupBox
            // 
            this.WisGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WisGroupBox.Controls.Add(this.WisModLabel);
            this.WisGroupBox.Controls.Add(this.WisTextBox);
            this.WisGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.WisGroupBox.Location = new System.Drawing.Point(12, 577);
            this.WisGroupBox.Name = "WisGroupBox";
            this.WisGroupBox.Size = new System.Drawing.Size(113, 100);
            this.WisGroupBox.TabIndex = 11;
            this.WisGroupBox.TabStop = false;
            this.WisGroupBox.Text = "Wisdom";
            this.WisGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // WisModLabel
            // 
            this.WisModLabel.AutoSize = true;
            this.WisModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisModLabel.Location = new System.Drawing.Point(29, 29);
            this.WisModLabel.Name = "WisModLabel";
            this.WisModLabel.Size = new System.Drawing.Size(59, 43);
            this.WisModLabel.TabIndex = 1;
            this.WisModLabel.Text = "+2";
            // 
            // WisTextBox
            // 
            this.WisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WisTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisTextBox.Location = new System.Drawing.Point(23, 76);
            this.WisTextBox.Name = "WisTextBox";
            this.WisTextBox.Size = new System.Drawing.Size(65, 24);
            this.WisTextBox.TabIndex = 0;
            this.WisTextBox.Text = "Wis";
            this.WisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WisTextBox.Click += new System.EventHandler(this.WisTextBox_MouseClick);
            this.WisTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // ChaGroupBox
            // 
            this.ChaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChaGroupBox.Controls.Add(this.ChaModLabel);
            this.ChaGroupBox.Controls.Add(this.ChaTextBox);
            this.ChaGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.ChaGroupBox.Location = new System.Drawing.Point(12, 683);
            this.ChaGroupBox.Name = "ChaGroupBox";
            this.ChaGroupBox.Size = new System.Drawing.Size(113, 100);
            this.ChaGroupBox.TabIndex = 10;
            this.ChaGroupBox.TabStop = false;
            this.ChaGroupBox.Text = "Charisma";
            this.ChaGroupBox.Leave += new System.EventHandler(this.GroupBox_Leave);
            // 
            // ChaModLabel
            // 
            this.ChaModLabel.AutoSize = true;
            this.ChaModLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaModLabel.Location = new System.Drawing.Point(29, 29);
            this.ChaModLabel.Name = "ChaModLabel";
            this.ChaModLabel.Size = new System.Drawing.Size(59, 43);
            this.ChaModLabel.TabIndex = 1;
            this.ChaModLabel.Text = "+2";
            // 
            // ChaTextBox
            // 
            this.ChaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChaTextBox.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaTextBox.Location = new System.Drawing.Point(23, 76);
            this.ChaTextBox.Name = "ChaTextBox";
            this.ChaTextBox.Size = new System.Drawing.Size(65, 24);
            this.ChaTextBox.TabIndex = 0;
            this.ChaTextBox.Text = "Cha";
            this.ChaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChaTextBox.Click += new System.EventHandler(this.ChaTextBox_MouseClick);
            this.ChaTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // CurrentHPTextBox
            // 
            this.CurrentHPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CurrentHPTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.CurrentHPTextBox.Location = new System.Drawing.Point(285, 133);
            this.CurrentHPTextBox.Name = "CurrentHPTextBox";
            this.CurrentHPTextBox.Size = new System.Drawing.Size(91, 34);
            this.CurrentHPTextBox.TabIndex = 13;
            this.CurrentHPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentHPTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.CurrentHPTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // TotalHpTextBox
            // 
            this.TotalHpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TotalHpTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.TotalHpTextBox.Location = new System.Drawing.Point(285, 93);
            this.TotalHpTextBox.Name = "TotalHpTextBox";
            this.TotalHpTextBox.Size = new System.Drawing.Size(91, 34);
            this.TotalHpTextBox.TabIndex = 12;
            this.TotalHpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalHpTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.TotalHpTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LevelLabel.Location = new System.Drawing.Point(634, 12);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(69, 27);
            this.LevelLabel.TabIndex = 18;
            this.LevelLabel.Text = "Level:";
            // 
            // ExpLevel
            // 
            this.ExpLevel.AutoSize = true;
            this.ExpLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExpLevel.Location = new System.Drawing.Point(646, 51);
            this.ExpLevel.Name = "ExpLevel";
            this.ExpLevel.Size = new System.Drawing.Size(57, 27);
            this.ExpLevel.TabIndex = 20;
            this.ExpLevel.Text = "Exp:";
            // 
            // TotalHPLabel
            // 
            this.TotalHPLabel.AutoSize = true;
            this.TotalHPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TotalHPLabel.Location = new System.Drawing.Point(167, 96);
            this.TotalHPLabel.Name = "TotalHPLabel";
            this.TotalHPLabel.Size = new System.Drawing.Size(112, 27);
            this.TotalHPLabel.TabIndex = 21;
            this.TotalHPLabel.Text = "Total HP";
            // 
            // CurrentHPLabel
            // 
            this.CurrentHPLabel.AutoSize = true;
            this.CurrentHPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CurrentHPLabel.Location = new System.Drawing.Point(147, 136);
            this.CurrentHPLabel.Name = "CurrentHPLabel";
            this.CurrentHPLabel.Size = new System.Drawing.Size(132, 27);
            this.CurrentHPLabel.TabIndex = 22;
            this.CurrentHPLabel.Text = "Current HP";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClassLabel.Location = new System.Drawing.Point(638, 136);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(65, 27);
            this.ClassLabel.TabIndex = 24;
            this.ClassLabel.Text = "Class";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RaceLabel.Location = new System.Drawing.Point(643, 96);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(60, 27);
            this.RaceLabel.TabIndex = 23;
            this.RaceLabel.Text = "Race";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClassTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.ClassTextBox.Location = new System.Drawing.Point(709, 133);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(127, 34);
            this.ClassTextBox.TabIndex = 26;
            this.ClassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.ClassTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RaceTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.RaceTextBox.Location = new System.Drawing.Point(709, 93);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.Size = new System.Drawing.Size(127, 34);
            this.RaceTextBox.TabIndex = 25;
            this.RaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RaceTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.RaceTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // InitiativeLabel
            // 
            this.InitiativeLabel.AutoSize = true;
            this.InitiativeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.InitiativeLabel.Location = new System.Drawing.Point(381, 136);
            this.InitiativeLabel.Name = "InitiativeLabel";
            this.InitiativeLabel.Size = new System.Drawing.Size(99, 27);
            this.InitiativeLabel.TabIndex = 28;
            this.InitiativeLabel.Text = "Initiative";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SpeedLabel.Location = new System.Drawing.Point(410, 96);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(70, 27);
            this.SpeedLabel.TabIndex = 27;
            this.SpeedLabel.Text = "Speed";
            // 
            // InitiativeTextBox
            // 
            this.InitiativeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InitiativeTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.InitiativeTextBox.Location = new System.Drawing.Point(486, 133);
            this.InitiativeTextBox.Name = "InitiativeTextBox";
            this.InitiativeTextBox.Size = new System.Drawing.Size(142, 34);
            this.InitiativeTextBox.TabIndex = 30;
            this.InitiativeTextBox.Text = "+2";
            this.InitiativeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InitiativeTextBox.Click += new System.EventHandler(this.InitiativeTextBox_MouseClick);
            this.InitiativeTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpeedTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.SpeedTextBox.Location = new System.Drawing.Point(486, 93);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(142, 34);
            this.SpeedTextBox.TabIndex = 29;
            this.SpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeedTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.SpeedTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // ArmorClassLabel
            // 
            this.ArmorClassLabel.AutoSize = true;
            this.ArmorClassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ArmorClassLabel.Location = new System.Drawing.Point(140, 176);
            this.ArmorClassLabel.Name = "ArmorClassLabel";
            this.ArmorClassLabel.Size = new System.Drawing.Size(139, 27);
            this.ArmorClassLabel.TabIndex = 31;
            this.ArmorClassLabel.Text = "Armor Class";
            // 
            // ArmorClassTextBox
            // 
            this.ArmorClassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ArmorClassTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.ArmorClassTextBox.Location = new System.Drawing.Point(285, 173);
            this.ArmorClassTextBox.Name = "ArmorClassTextBox";
            this.ArmorClassTextBox.Size = new System.Drawing.Size(91, 34);
            this.ArmorClassTextBox.TabIndex = 32;
            this.ArmorClassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArmorClassTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.ArmorClassTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // HitDiceTextBox
            // 
            this.HitDiceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HitDiceTextBox.Font = new System.Drawing.Font("Immortal", 16F);
            this.HitDiceTextBox.Location = new System.Drawing.Point(486, 173);
            this.HitDiceTextBox.Name = "HitDiceTextBox";
            this.HitDiceTextBox.Size = new System.Drawing.Size(142, 34);
            this.HitDiceTextBox.TabIndex = 35;
            this.HitDiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HitDiceTextBox.Click += new System.EventHandler(this.TextBox_MouseClick);
            this.HitDiceTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // HitDiceLabel
            // 
            this.HitDiceLabel.AutoSize = true;
            this.HitDiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HitDiceLabel.Location = new System.Drawing.Point(381, 176);
            this.HitDiceLabel.Name = "HitDiceLabel";
            this.HitDiceLabel.Size = new System.Drawing.Size(101, 27);
            this.HitDiceLabel.TabIndex = 34;
            this.HitDiceLabel.Text = "Hit Dice";
            // 
            // ProficiencyGroupBox
            // 
            this.ProficiencyGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProficiencyGroupBox.Controls.Add(this.ProficiencyPlusLabel);
            this.ProficiencyGroupBox.Controls.Add(this.ProficiencyTextBox);
            this.ProficiencyGroupBox.Font = new System.Drawing.Font("Immortal", 11.5F);
            this.ProficiencyGroupBox.Location = new System.Drawing.Point(12, 93);
            this.ProficiencyGroupBox.Name = "ProficiencyGroupBox";
            this.ProficiencyGroupBox.Size = new System.Drawing.Size(113, 53);
            this.ProficiencyGroupBox.TabIndex = 10;
            this.ProficiencyGroupBox.TabStop = false;
            this.ProficiencyGroupBox.Text = "Proficiency";
            // 
            // ProficiencyPlusLabel
            // 
            this.ProficiencyPlusLabel.AutoSize = true;
            this.ProficiencyPlusLabel.Font = new System.Drawing.Font("Immortal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProficiencyPlusLabel.Location = new System.Drawing.Point(33, 26);
            this.ProficiencyPlusLabel.Name = "ProficiencyPlusLabel";
            this.ProficiencyPlusLabel.Size = new System.Drawing.Size(25, 27);
            this.ProficiencyPlusLabel.TabIndex = 3;
            this.ProficiencyPlusLabel.Text = "+";
            // 
            // ProficiencyTextBox
            // 
            this.ProficiencyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProficiencyTextBox.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProficiencyTextBox.Location = new System.Drawing.Point(57, 23);
            this.ProficiencyTextBox.Name = "ProficiencyTextBox";
            this.ProficiencyTextBox.Size = new System.Drawing.Size(31, 30);
            this.ProficiencyTextBox.TabIndex = 2;
            this.ProficiencyTextBox.Text = "2";
            this.ProficiencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProficiencyTextBox.Click += new System.EventHandler(this.ProficiencyTextBox_MouseClick);
            this.ProficiencyTextBox.Leave += new System.EventHandler(this.TextBox_LeaveFocus);
            // 
            // CreateProfileButton
            // 
            this.CreateProfileButton.Location = new System.Drawing.Point(344, 712);
            this.CreateProfileButton.Name = "CreateProfileButton";
            this.CreateProfileButton.Size = new System.Drawing.Size(260, 41);
            this.CreateProfileButton.TabIndex = 36;
            this.CreateProfileButton.Text = "Create Profile";
            this.CreateProfileButton.UseVisualStyleBackColor = true;
            this.CreateProfileButton.Click += new System.EventHandler(this.CreateProfileButton_Click);
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(852, 804);
            this.Controls.Add(this.CreateProfileButton);
            this.Controls.Add(this.ProficiencyGroupBox);
            this.Controls.Add(this.HitDiceTextBox);
            this.Controls.Add(this.HitDiceLabel);
            this.Controls.Add(this.ArmorClassTextBox);
            this.Controls.Add(this.ArmorClassLabel);
            this.Controls.Add(this.InitiativeTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.InitiativeLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(this.RaceTextBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.CurrentHPLabel);
            this.Controls.Add(this.TotalHPLabel);
            this.Controls.Add(this.ExpLevel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.CurrentHPTextBox);
            this.Controls.Add(this.TotalHpTextBox);
            this.Controls.Add(this.ChaGroupBox);
            this.Controls.Add(this.WisGroupBox);
            this.Controls.Add(this.IntGroupBox);
            this.Controls.Add(this.ConGroupBox);
            this.Controls.Add(this.DexGroupBox);
            this.Controls.Add(this.StrGroupBox);
            this.Controls.Add(this.CharacterExpTextBox);
            this.Controls.Add(this.CharacterLevelTextBox);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Font = new System.Drawing.Font("Immortal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "CharacterCreationForm";
            this.Text = "New Profile";            
            this.StrGroupBox.ResumeLayout(false);
            this.StrGroupBox.PerformLayout();
            this.DexGroupBox.ResumeLayout(false);
            this.DexGroupBox.PerformLayout();
            this.ConGroupBox.ResumeLayout(false);
            this.ConGroupBox.PerformLayout();
            this.IntGroupBox.ResumeLayout(false);
            this.IntGroupBox.PerformLayout();
            this.WisGroupBox.ResumeLayout(false);
            this.WisGroupBox.PerformLayout();
            this.ChaGroupBox.ResumeLayout(false);
            this.ChaGroupBox.PerformLayout();
            this.ProficiencyGroupBox.ResumeLayout(false);
            this.ProficiencyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.TextBox CharacterLevelTextBox;
        private System.Windows.Forms.TextBox CharacterExpTextBox;
        private System.Windows.Forms.GroupBox StrGroupBox;
        private System.Windows.Forms.Label StrModLabel;
        private System.Windows.Forms.TextBox StrTextBox;
        private System.Windows.Forms.GroupBox DexGroupBox;
        private System.Windows.Forms.Label DexModLabel;
        private System.Windows.Forms.TextBox DexTextBox;
        private System.Windows.Forms.GroupBox ConGroupBox;
        private System.Windows.Forms.Label ConModLabel;
        private System.Windows.Forms.TextBox ConTextBox;
        private System.Windows.Forms.GroupBox IntGroupBox;
        private System.Windows.Forms.Label IntModLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.GroupBox WisGroupBox;
        private System.Windows.Forms.Label WisModLabel;
        private System.Windows.Forms.TextBox WisTextBox;
        private System.Windows.Forms.GroupBox ChaGroupBox;
        private System.Windows.Forms.Label ChaModLabel;
        private System.Windows.Forms.TextBox ChaTextBox;
        private System.Windows.Forms.TextBox CurrentHPTextBox;
        private System.Windows.Forms.TextBox TotalHpTextBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ExpLevel;
        private System.Windows.Forms.Label TotalHPLabel;
        private System.Windows.Forms.Label CurrentHPLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.Label InitiativeLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox InitiativeTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label ArmorClassLabel;
        private System.Windows.Forms.TextBox ArmorClassTextBox;
        private System.Windows.Forms.TextBox HitDiceTextBox;
        private System.Windows.Forms.Label HitDiceLabel;
        private System.Windows.Forms.GroupBox ProficiencyGroupBox;
        private System.Windows.Forms.TextBox ProficiencyTextBox;
        private System.Windows.Forms.Button CreateProfileButton;
        private System.Windows.Forms.Label ProficiencyPlusLabel;
    }
}