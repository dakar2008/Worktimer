namespace WorkTimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Stopwatchlabel = new System.Windows.Forms.Label();
            this.StartSWBtn = new System.Windows.Forms.Button();
            this.StopSWBtn = new System.Windows.Forms.Button();
            this.ResetSWBtn = new System.Windows.Forms.Button();
            this.PreSaveSWBtn = new System.Windows.Forms.Button();
            this.Worktitlebox = new System.Windows.Forms.TextBox();
            this.WorkTitleLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.worktitlelist = new System.Windows.Forms.ListBox();
            this.GetWorkInfoBtn = new System.Windows.Forms.Button();
            this.SelectedWorkTitleLabel = new System.Windows.Forms.Label();
            this.SelectedWorkTimerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DeleteSelectedBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.themepicker = new System.Windows.Forms.ComboBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.SettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stopwatchlabel
            // 
            this.Stopwatchlabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopwatchlabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Stopwatchlabel.Location = new System.Drawing.Point(17, 9);
            this.Stopwatchlabel.Name = "Stopwatchlabel";
            this.Stopwatchlabel.Size = new System.Drawing.Size(944, 146);
            this.Stopwatchlabel.TabIndex = 0;
            this.Stopwatchlabel.Text = "00:00:00:00:000";
            this.Stopwatchlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartSWBtn
            // 
            this.StartSWBtn.BackColor = System.Drawing.Color.DimGray;
            this.StartSWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartSWBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSWBtn.ForeColor = System.Drawing.Color.White;
            this.StartSWBtn.Location = new System.Drawing.Point(207, 158);
            this.StartSWBtn.Name = "StartSWBtn";
            this.StartSWBtn.Size = new System.Drawing.Size(184, 46);
            this.StartSWBtn.TabIndex = 1;
            this.StartSWBtn.Text = "Start";
            this.StartSWBtn.UseVisualStyleBackColor = false;
            this.StartSWBtn.Click += new System.EventHandler(this.StartSWBtn_Click);
            // 
            // StopSWBtn
            // 
            this.StopSWBtn.BackColor = System.Drawing.Color.DimGray;
            this.StopSWBtn.Enabled = false;
            this.StopSWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopSWBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopSWBtn.ForeColor = System.Drawing.Color.White;
            this.StopSWBtn.Location = new System.Drawing.Point(397, 158);
            this.StopSWBtn.Name = "StopSWBtn";
            this.StopSWBtn.Size = new System.Drawing.Size(184, 46);
            this.StopSWBtn.TabIndex = 2;
            this.StopSWBtn.Text = "Pause";
            this.StopSWBtn.UseVisualStyleBackColor = false;
            this.StopSWBtn.Click += new System.EventHandler(this.StopSWBtn_Click);
            // 
            // ResetSWBtn
            // 
            this.ResetSWBtn.BackColor = System.Drawing.Color.DimGray;
            this.ResetSWBtn.Enabled = false;
            this.ResetSWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSWBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSWBtn.ForeColor = System.Drawing.Color.White;
            this.ResetSWBtn.Location = new System.Drawing.Point(587, 158);
            this.ResetSWBtn.Name = "ResetSWBtn";
            this.ResetSWBtn.Size = new System.Drawing.Size(184, 46);
            this.ResetSWBtn.TabIndex = 3;
            this.ResetSWBtn.Text = "Reset";
            this.ResetSWBtn.UseVisualStyleBackColor = false;
            this.ResetSWBtn.Click += new System.EventHandler(this.ResetSWBtn_Click);
            // 
            // PreSaveSWBtn
            // 
            this.PreSaveSWBtn.BackColor = System.Drawing.Color.DimGray;
            this.PreSaveSWBtn.Enabled = false;
            this.PreSaveSWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreSaveSWBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSaveSWBtn.ForeColor = System.Drawing.Color.White;
            this.PreSaveSWBtn.Location = new System.Drawing.Point(777, 158);
            this.PreSaveSWBtn.Name = "PreSaveSWBtn";
            this.PreSaveSWBtn.Size = new System.Drawing.Size(184, 46);
            this.PreSaveSWBtn.TabIndex = 4;
            this.PreSaveSWBtn.Text = "Save";
            this.PreSaveSWBtn.UseVisualStyleBackColor = false;
            this.PreSaveSWBtn.Click += new System.EventHandler(this.PreSaveSWBtn_Click);
            // 
            // Worktitlebox
            // 
            this.Worktitlebox.BackColor = System.Drawing.Color.Black;
            this.Worktitlebox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worktitlebox.ForeColor = System.Drawing.Color.White;
            this.Worktitlebox.Location = new System.Drawing.Point(158, 210);
            this.Worktitlebox.Name = "Worktitlebox";
            this.Worktitlebox.Size = new System.Drawing.Size(706, 27);
            this.Worktitlebox.TabIndex = 5;
            this.Worktitlebox.Visible = false;
            this.Worktitlebox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Worktitlebox_KeyDown);
            // 
            // WorkTitleLabel
            // 
            this.WorkTitleLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTitleLabel.ForeColor = System.Drawing.Color.White;
            this.WorkTitleLabel.Location = new System.Drawing.Point(17, 210);
            this.WorkTitleLabel.Name = "WorkTitleLabel";
            this.WorkTitleLabel.Size = new System.Drawing.Size(135, 27);
            this.WorkTitleLabel.TabIndex = 6;
            this.WorkTitleLabel.Text = "Navn På Arbejde:";
            this.WorkTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkTitleLabel.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.DimGray;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(870, 210);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(91, 27);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Gem";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // worktitlelist
            // 
            this.worktitlelist.BackColor = System.Drawing.Color.Black;
            this.worktitlelist.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worktitlelist.ForeColor = System.Drawing.Color.White;
            this.worktitlelist.FormattingEnabled = true;
            this.worktitlelist.ItemHeight = 16;
            this.worktitlelist.Location = new System.Drawing.Point(17, 243);
            this.worktitlelist.Name = "worktitlelist";
            this.worktitlelist.Size = new System.Drawing.Size(847, 132);
            this.worktitlelist.TabIndex = 8;
            this.worktitlelist.TabStop = false;
            this.worktitlelist.Visible = false;
            // 
            // GetWorkInfoBtn
            // 
            this.GetWorkInfoBtn.BackColor = System.Drawing.Color.DimGray;
            this.GetWorkInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetWorkInfoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWorkInfoBtn.ForeColor = System.Drawing.Color.White;
            this.GetWorkInfoBtn.Location = new System.Drawing.Point(870, 243);
            this.GetWorkInfoBtn.Name = "GetWorkInfoBtn";
            this.GetWorkInfoBtn.Size = new System.Drawing.Size(91, 132);
            this.GetWorkInfoBtn.TabIndex = 9;
            this.GetWorkInfoBtn.Text = "Hent Info";
            this.GetWorkInfoBtn.UseVisualStyleBackColor = false;
            this.GetWorkInfoBtn.Visible = false;
            this.GetWorkInfoBtn.Click += new System.EventHandler(this.GetWorkInfoBtn_Click);
            // 
            // SelectedWorkTitleLabel
            // 
            this.SelectedWorkTitleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedWorkTitleLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedWorkTitleLabel.Location = new System.Drawing.Point(17, 381);
            this.SelectedWorkTitleLabel.Name = "SelectedWorkTitleLabel";
            this.SelectedWorkTitleLabel.Size = new System.Drawing.Size(847, 53);
            this.SelectedWorkTitleLabel.TabIndex = 10;
            this.SelectedWorkTitleLabel.Text = "Arbejdstitel";
            this.SelectedWorkTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectedWorkTitleLabel.Visible = false;
            // 
            // SelectedWorkTimerLabel
            // 
            this.SelectedWorkTimerLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedWorkTimerLabel.ForeColor = System.Drawing.Color.Orange;
            this.SelectedWorkTimerLabel.Location = new System.Drawing.Point(17, 434);
            this.SelectedWorkTimerLabel.Name = "SelectedWorkTimerLabel";
            this.SelectedWorkTimerLabel.Size = new System.Drawing.Size(847, 65);
            this.SelectedWorkTimerLabel.TabIndex = 11;
            this.SelectedWorkTimerLabel.Text = "00:00:00:00:000";
            this.SelectedWorkTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectedWorkTimerLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteSelectedBtn
            // 
            this.DeleteSelectedBtn.BackColor = System.Drawing.Color.DimGray;
            this.DeleteSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteSelectedBtn.Location = new System.Drawing.Point(870, 381);
            this.DeleteSelectedBtn.Name = "DeleteSelectedBtn";
            this.DeleteSelectedBtn.Size = new System.Drawing.Size(91, 118);
            this.DeleteSelectedBtn.TabIndex = 12;
            this.DeleteSelectedBtn.Text = "Slet Valgte";
            this.DeleteSelectedBtn.UseVisualStyleBackColor = false;
            this.DeleteSelectedBtn.Visible = false;
            this.DeleteSelectedBtn.Click += new System.EventHandler(this.DeleteSelectedBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.DimGray;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Location = new System.Drawing.Point(17, 158);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(184, 46);
            this.SettingBtn.TabIndex = 13;
            this.SettingBtn.Text = "Indstillinger";
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.ThemeLabel);
            this.SettingsBox.Controls.Add(this.themepicker);
            this.SettingsBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBox.ForeColor = System.Drawing.Color.White;
            this.SettingsBox.Location = new System.Drawing.Point(967, 9);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Padding = new System.Windows.Forms.Padding(10);
            this.SettingsBox.Size = new System.Drawing.Size(404, 490);
            this.SettingsBox.TabIndex = 14;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Indstillinger";
            this.SettingsBox.Visible = false;
            // 
            // themepicker
            // 
            this.themepicker.BackColor = System.Drawing.Color.Black;
            this.themepicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themepicker.ForeColor = System.Drawing.Color.White;
            this.themepicker.FormattingEnabled = true;
            this.themepicker.Items.AddRange(new object[] {
            "Mørkt Tema",
            "Lys Tema",
            "Regnbue Tema"});
            this.themepicker.Location = new System.Drawing.Point(103, 23);
            this.themepicker.Name = "themepicker";
            this.themepicker.Size = new System.Drawing.Size(288, 24);
            this.themepicker.TabIndex = 0;
            this.themepicker.SelectionChangeCommitted += new System.EventHandler(this.themepicker_SelectionChangeCommitted);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(13, 26);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(84, 16);
            this.ThemeLabel.TabIndex = 1;
            this.ThemeLabel.Text = "Vælg Tema:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1379, 507);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.DeleteSelectedBtn);
            this.Controls.Add(this.SelectedWorkTimerLabel);
            this.Controls.Add(this.SelectedWorkTitleLabel);
            this.Controls.Add(this.GetWorkInfoBtn);
            this.Controls.Add(this.worktitlelist);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.WorkTitleLabel);
            this.Controls.Add(this.Worktitlebox);
            this.Controls.Add(this.PreSaveSWBtn);
            this.Controls.Add(this.ResetSWBtn);
            this.Controls.Add(this.StopSWBtn);
            this.Controls.Add(this.StartSWBtn);
            this.Controls.Add(this.Stopwatchlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Work Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stopwatchlabel;
        private System.Windows.Forms.Button StartSWBtn;
        private System.Windows.Forms.Button StopSWBtn;
        private System.Windows.Forms.Button ResetSWBtn;
        private System.Windows.Forms.Button PreSaveSWBtn;
        private System.Windows.Forms.TextBox Worktitlebox;
        private System.Windows.Forms.Label WorkTitleLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox worktitlelist;
        private System.Windows.Forms.Button GetWorkInfoBtn;
        private System.Windows.Forms.Label SelectedWorkTitleLabel;
        private System.Windows.Forms.Label SelectedWorkTimerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DeleteSelectedBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.ComboBox themepicker;
    }
}

