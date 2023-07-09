using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityAlertClient
{
    public partial class Lockdown : Form
    {
        public Lockdown()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                ManagementScope scope = new ManagementScope("root\\WMI");
                scope.Connect();
                ManagementClass brightnessClass = new ManagementClass(scope, new ManagementPath("WmiMonitorBrightnessMethods"), null);
                ManagementObjectCollection brightnessCollection = brightnessClass.GetInstances();

                foreach (ManagementObject brightness in brightnessCollection)
                {
                    brightness.InvokeMethod("WmiSetBrightness", new object[] { UInt32.MaxValue, 0 });
                }
            }
            catch (Exception)
            {

            }
            BackgroundImage = null;
        }

        private void Lockdown_Load(object sender, EventArgs e)
        {
            //SystemSounds.Beep.Play();
            Mute();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
            VolDown();
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
    }
}
