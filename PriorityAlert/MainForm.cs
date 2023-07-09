using PriorityAlert.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityAlert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            lblVersion.Text = this.Tag.ToString() + "\nBunnyTub on Discord";

            comboCode.Items.AddRange(MessageTypes.AlertCodes.OrderBy(x => x.Name).Select(x => x.Name).ToArray());
            comboOriginator.Items.AddRange(MessageTypes.Originators.OrderBy(x => x.Name).Select(x => x.Name).ToArray());

            //for (int x = 0; x <= 99; x++)
            //{
            //    if (x <= 60)
            //    {
            //        comboLengthMinutes.Items.Add(x.ToString());
            //    }
            //    comboLengthHour.Items.Add(x.ToString());
            //}

            this.ResumeLayout();
        }
    }
}
