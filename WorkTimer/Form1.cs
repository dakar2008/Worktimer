using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorkTimer.Models;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace WorkTimer
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        public static string workingpath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public static string completexmlpath = workingpath + "/workingtimes.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw = new Stopwatch();
            timer1.Start();
            if (!File.Exists(completexmlpath))
            {
                XmlTextWriter xtw;
                xtw = new XmlTextWriter(completexmlpath, Encoding.UTF8);
                xtw.WriteStartDocument();
                xtw.WriteStartElement("WorkingTimes");
                xtw.WriteEndElement();
                xtw.Close();
            }
            else
            {
                List<WorkTime> worktimelist = Helper.GetWorkTimes(completexmlpath);
                if (worktimelist.Any())
                {
                    worktimelist = Helper.GetWorkTimes(completexmlpath);
                    worktitlelist.DisplayMember = "Title";
                    worktitlelist.DataSource = worktimelist;
                    worktitlelist.Visible = true;
                    GetWorkInfoBtn.Visible = true;
                }
            }
            if(Properties.Settings.Default.ThemeUsed == "Dark Theme")
            {
                themepicker.SelectedIndex = 0;
                Theme_Dark();
            }
            else if(Properties.Settings.Default.ThemeUsed == "Light Theme")
            {
                themepicker.SelectedIndex = 1;
                Theme_Light();
            }
            else
            {
                themepicker.SelectedIndex = 2;
                Theme_Rainbow();
            }
        }

        private void StartSWBtn_Click(object sender, EventArgs e)
        {
            sw.Start();
            StartSWBtn.Enabled = false;
            StopSWBtn.Enabled = true;
            ResetSWBtn.Enabled = false;
            PreSaveSWBtn.Enabled = false;
        }

        private void StopSWBtn_Click(object sender, EventArgs e)
        {
            sw.Stop();
            StopSWBtn.Enabled = false;
            StartSWBtn.Enabled = true;
            ResetSWBtn.Enabled = true;
            PreSaveSWBtn.Enabled = true;
            StartSWBtn.Text = "Resume";
        }

        private void ResetSWBtn_Click(object sender, EventArgs e)
        {
            sw.Reset();
            ResetSWBtn.Enabled = false;
            StopSWBtn.Enabled = false;
            StartSWBtn.Enabled = true;
            PreSaveSWBtn.Enabled = false;
            WorkTitleLabel.Visible = false;
            Worktitlebox.Visible = false;
            Worktitlebox.Clear();
            SaveBtn.Visible = false;
            StartSWBtn.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            Stopwatchlabel.Text = string.Format("{0}:{1}:{2}:{3}:{4}", ts.Days.ToString().PadLeft(2, '0'), ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
        }

        private void PreSaveSWBtn_Click(object sender, EventArgs e)
        {
            WorkTitleLabel.Visible = true;
            Worktitlebox.Visible = true;
            SaveBtn.Visible = true;
            Worktitlebox.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<WorkTime> worktimelist = Helper.GetWorkTimes(completexmlpath);
            if (Worktitlebox.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Du skal indtaste en titel", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    Worktitlebox.Focus();
                }
            }
            else if(worktimelist.Any(m => m.Title == Worktitlebox.Text))
            {
                DialogResult result = MessageBox.Show("Titlen findes allerede", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    Worktitlebox.SelectAll();
                    Worktitlebox.Focus();
                }
            }
            else
            {
                TimeSpan ts = sw.Elapsed;
                WorkTime newworktime = new WorkTime();
                newworktime.Title = Worktitlebox.Text;
                newworktime.Time = string.Format("{0}:{1}:{2}:{3}:{4}", ts.Days.ToString().PadLeft(2, '0'), ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(3, '0'));
                Helper.AddToDatabase(completexmlpath, newworktime);
                Worktitlebox.Clear();
                worktimelist = Helper.GetWorkTimes(completexmlpath);
                worktitlelist.DisplayMember = "Title";
                worktitlelist.DataSource = worktimelist;
                worktitlelist.Visible = true;
                GetWorkInfoBtn.Visible = true;
                ResetSWBtn.PerformClick();
            }
        }

        private void GetWorkInfoBtn_Click(object sender, EventArgs e)
        {
            SelectedWorkTitleLabel.Text = ((WorkTime)worktitlelist.SelectedItem).Title;
            SelectedWorkTimerLabel.Text = ((WorkTime)worktitlelist.SelectedItem).Time;
            DeleteSelectedBtn.Tag = ((WorkTime)worktitlelist.SelectedItem).ID;
            SelectedWorkTitleLabel.Visible = true;
            SelectedWorkTimerLabel.Visible = true;
            DeleteSelectedBtn.Visible = true;
        }

        private void DeleteSelectedBtn_Click(object sender, EventArgs e)
        {
            string ID = ((WorkTime)worktitlelist.SelectedItem).ID;
            Helper.RemoveFromDatabase(completexmlpath, ID);
            worktitlelist.DataSource = null;
            worktitlelist.Items.Clear();
            List<WorkTime> worktimelist = Helper.GetWorkTimes(completexmlpath);
            worktimelist = Helper.GetWorkTimes(completexmlpath);
            worktitlelist.DisplayMember = "Title";
            worktitlelist.DataSource = worktimelist;
            if(worktitlelist.Items.Count == 0)
            {
                WorkTitleLabel.Visible = false;
                Worktitlebox.Visible = false;
                SaveBtn.Visible = false;
                worktitlelist.Visible = false;
                SelectedWorkTimerLabel.Visible = false;
                SelectedWorkTitleLabel.Visible = false;
                GetWorkInfoBtn.Visible = false;
                DeleteSelectedBtn.Visible = false;
            }
        }

        private void Worktitlebox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveBtn.PerformClick();
            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowSettings)
            {
                Properties.Settings.Default.ShowSettings = false;
                Properties.Settings.Default.Save();
                SettingsBox.Visible = false;
            }
            else
            {
                Properties.Settings.Default.ShowSettings = true;
                Properties.Settings.Default.Save();
                SettingsBox.Visible = true;
            }
        }

        public void Theme_Dark()
        {
            this.BackColor = Color.Black;
            Stopwatchlabel.ForeColor = Color.AntiqueWhite;

            SettingBtn.BackColor = Color.DimGray;
            SettingBtn.ForeColor = Color.White;
            StartSWBtn.BackColor = Color.DimGray;
            StartSWBtn.ForeColor = Color.White;
            StopSWBtn.BackColor = Color.DimGray;
            StopSWBtn.ForeColor = Color.White;
            ResetSWBtn.BackColor = Color.DimGray;
            ResetSWBtn.ForeColor = Color.White;
            PreSaveSWBtn.BackColor = Color.DimGray;
            PreSaveSWBtn.ForeColor = Color.White;
            SaveBtn.BackColor = Color.DimGray;
            SaveBtn.ForeColor = Color.White;
            GetWorkInfoBtn.BackColor = Color.DimGray;
            GetWorkInfoBtn.ForeColor = Color.White;
            DeleteSelectedBtn.BackColor = Color.DimGray;
            DeleteSelectedBtn.ForeColor = Color.White;

            WorkTitleLabel.ForeColor = Color.White;
            Worktitlebox.BackColor = Color.Black;
            Worktitlebox.ForeColor = Color.White;
            worktitlelist.BackColor = Color.Black;
            worktitlelist.ForeColor = Color.White;
            SelectedWorkTitleLabel.ForeColor = Color.White;
            SelectedWorkTitleLabel.BackColor = Color.Transparent;
            SelectedWorkTimerLabel.ForeColor = Color.Orange;
            SelectedWorkTimerLabel.BackColor = Color.Transparent;
            SettingsBox.BackColor = Color.Black;
            SettingsBox.ForeColor = Color.White;
            ThemeLabel.ForeColor = Color.White;
            ThemeLabel.BackColor = Color.Transparent;

            themepicker.ForeColor = Color.White;
            themepicker.BackColor = Color.Black;
            themepicker.FlatStyle = FlatStyle.Flat;

            Properties.Settings.Default.ThemeUsed = "Dark Theme";
            Properties.Settings.Default.Save();
        }
        public void Theme_Light()
        {
            this.BackColor = Color.White;
            Stopwatchlabel.ForeColor = Color.Black;

            SettingBtn.BackColor = Color.Silver;
            SettingBtn.ForeColor = Color.Black;
            StartSWBtn.BackColor = Color.Silver;
            StartSWBtn.ForeColor = Color.Black;
            StopSWBtn.BackColor = Color.Silver;
            StopSWBtn.ForeColor = Color.Black;
            ResetSWBtn.BackColor = Color.Silver;
            ResetSWBtn.ForeColor = Color.Black;
            PreSaveSWBtn.BackColor = Color.Silver;
            PreSaveSWBtn.ForeColor = Color.Black;
            SaveBtn.BackColor = Color.Silver;
            SaveBtn.ForeColor = Color.Black;
            GetWorkInfoBtn.BackColor = Color.Silver;
            GetWorkInfoBtn.ForeColor = Color.Black;
            DeleteSelectedBtn.BackColor = Color.Silver;
            DeleteSelectedBtn.ForeColor = Color.Black;

            WorkTitleLabel.ForeColor = Color.Black;
            Worktitlebox.BackColor = Color.Silver;
            Worktitlebox.ForeColor = Color.Black;
            worktitlelist.BackColor = Color.Silver;
            worktitlelist.ForeColor = Color.Black;
            SelectedWorkTitleLabel.ForeColor = Color.Black;
            SelectedWorkTitleLabel.BackColor = Color.Transparent;
            SelectedWorkTimerLabel.ForeColor = Color.Red;
            SelectedWorkTimerLabel.BackColor = Color.Transparent;

            SettingsBox.BackColor = Color.Transparent;
            SettingsBox.ForeColor = Color.Black;
            ThemeLabel.ForeColor = Color.Black;
            ThemeLabel.BackColor = Color.Transparent;

            themepicker.ForeColor = Color.Black;
            themepicker.BackColor = Color.FromKnownColor(KnownColor.Control);
            themepicker.FlatStyle = FlatStyle.Standard;

            Properties.Settings.Default.ThemeUsed = "Light Theme";
            Properties.Settings.Default.Save();
        }
        public void Theme_Rainbow()
        {
            this.BackColor = Color.LawnGreen;
            Stopwatchlabel.ForeColor = Color.Red;

            SettingBtn.BackColor = Color.Red;
            SettingBtn.ForeColor = Color.Yellow;

            StartSWBtn.BackColor = Color.Blue;
            StartSWBtn.ForeColor = Color.Orange;

            StopSWBtn.BackColor = Color.DarkGreen;
            StopSWBtn.ForeColor = Color.White;

            ResetSWBtn.BackColor = Color.DodgerBlue;
            ResetSWBtn.ForeColor = Color.White;

            PreSaveSWBtn.BackColor = Color.Yellow;
            PreSaveSWBtn.ForeColor = Color.Black;

            SaveBtn.BackColor = Color.Red;
            SaveBtn.ForeColor = Color.Yellow;

            GetWorkInfoBtn.BackColor = Color.Blue;
            GetWorkInfoBtn.ForeColor = Color.Orange;

            DeleteSelectedBtn.BackColor = Color.DodgerBlue;
            DeleteSelectedBtn.ForeColor = Color.White;

            WorkTitleLabel.ForeColor = Color.DarkRed;

            Worktitlebox.BackColor = Color.Orange;
            Worktitlebox.ForeColor = Color.Black;

            worktitlelist.BackColor = Color.Blue;
            worktitlelist.ForeColor = Color.Yellow;

            SelectedWorkTitleLabel.ForeColor = Color.Orange;
            SelectedWorkTitleLabel.BackColor = Color.Transparent;

            SelectedWorkTimerLabel.ForeColor = Color.Red;
            SelectedWorkTimerLabel.BackColor = Color.Transparent;

            SettingsBox.BackColor = Color.Transparent;
            SettingsBox.ForeColor = Color.Red;
            SettingsBox.FlatStyle = FlatStyle.Standard;

            ThemeLabel.ForeColor = Color.Blue;
            ThemeLabel.BackColor = Color.Transparent;

            themepicker.ForeColor = Color.Yellow;
            themepicker.BackColor = Color.Red;

            Properties.Settings.Default.ThemeUsed = "Rainbow Theme";
            Properties.Settings.Default.Save();
        }

        private void themepicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(themepicker.SelectedIndex == 0)
            {
                Theme_Dark();
            }
            else if(themepicker.SelectedIndex == 1)
            {
                Theme_Light();
            }
            else
            {
                Theme_Rainbow();
            }
        }
    }
}