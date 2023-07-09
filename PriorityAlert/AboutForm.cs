using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PriorityAlert
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo psInfo = new ProcessStartInfo
            //{
            //    FileName = "https://discord.gg/2mfsz5bCnk",
            //    UseShellExecute = true
            //};
            //Process.Start(psInfo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "'Output errors and warnings quietly'\n" +
                "This will silence any errors and warnings that may occur while using the app.\n\n" +
                "'Use Windows 95/98 design'\nThis can improve visual performance on older systems.\n\n" +
                "'Wait 15 seconds before relaying message'\nThis will process the audio first, wait 15 seconds, then relay it.\n\n" +
                "Use Legacy Fonts\nThis makes the fonts look a bit better on older versions of Windows, but may cause black boxes around labels.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SilenceErrors = checkBox1.Checked;
            Properties.Settings.Default.Use95Design = checkBox2.Checked;
            Properties.Settings.Default.UseCountdown = checkBox3.Checked;
            Properties.Settings.Default.LegacyFont = checkBox4.Checked;
            Properties.Settings.Default.QuitOnFinish = checkBox5.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Some changes may not take effect until you restart the program.", "PriorityAlert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (Properties.Settings.Default.LowRes)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                this.BringToFront();
            }
            checkBox1.Checked = Properties.Settings.Default.SilenceErrors;
            checkBox2.Checked = Properties.Settings.Default.Use95Design;
            checkBox3.Checked = Properties.Settings.Default.UseCountdown;
            checkBox4.Checked = Properties.Settings.Default.LegacyFont;
            checkBox5.Checked = Properties.Settings.Default.QuitOnFinish;
            if (!Properties.Settings.Default.LowRes)
            {
                lblLowRes.Hide();
            }
            this.ResumeLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restore the settings to their defaults?", "PriorityAlert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                MessageBox.Show("The application will now restart.");
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }
    }
}
