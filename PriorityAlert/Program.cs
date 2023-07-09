using PriorityAlert.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PriorityAlert
{
    internal class Interesting
    {
        public NotifyIcon NtIcon = new NotifyIcon
        {
            BalloonTipIcon = ToolTipIcon.Error,
            BalloonTipTitle = "Encoder Failure",
            BalloonTipText = "Something unexpected has occurred.\nClick here to view more advanced details about the error.",
            Visible = true,
            Text = "PriorityAlert",
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        };
    }
    internal static class Program
    {
        static Interesting Notify;

        [STAThread]
        internal static void Main()
        {
            int MajorVersion = 1;
            int MinorVersion = 0;
            int Revision = 0;
            string FusionVersion = "v" + MajorVersion.ToString() + "." + MinorVersion.ToString() + "." + Revision.ToString();

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ApplicationExit += ProperTermination;
            Application.ThreadException += UnhandledTermination;
            Settings.Default.SettingsSaving += SavingContents;


            if (Settings.Default.Use95Design) Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            else Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(Settings.Default.LegacyFont);

            Notify = new Interesting();
            Notify.NtIcon.BalloonTipClicked += ErrorInformation;

            Application.Run(new MainForm { Tag = FusionVersion });
        }

        private static string HResult = "?";
        private static string ExceptionMessage = "An unknown error has occurred.";
        private static string ExceptionStackTrace = "Stack trace failed.";

        private static void ErrorInformation(object sender, EventArgs e)
        {
            Notify.NtIcon.Visible = false;
            System.Windows.Forms.MessageBox.Show(HResult + "\n" + ExceptionMessage + "\n" + ExceptionStackTrace + "\n\nIt may be possible to continue normally.", "PriorityAlert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (Form form in Application.OpenForms)
            {
                form.BringToFront();
            }
            Notify.NtIcon.Visible = true;
        }

        private static void SavingContents(object sender, CancelEventArgs e)
        {

        }

        internal static void ProperTermination(object sender, EventArgs e)
        {

        }

        internal static void UnhandledTermination(object sender, ThreadExceptionEventArgs e)
        {
            HResult = e.Exception.HResult.ToString();
            ExceptionMessage = e.Exception.Message;
            ExceptionStackTrace = e.Exception.StackTrace;
            Notify.NtIcon.ShowBalloonTip(15000);
        }
    }

    public static class MessageBox
    {
        public static DialogResult Show(string text = "", string title = "PriorityAlert", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (Settings.Default.SilenceErrors) return System.Windows.Forms.MessageBox.Show(text, title, buttons);
            else return System.Windows.Forms.MessageBox.Show(text, title, buttons, icon);
        }
    }
}