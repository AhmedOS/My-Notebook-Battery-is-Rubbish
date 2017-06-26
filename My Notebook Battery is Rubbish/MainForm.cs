using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyNotebookBatteryisRubbish
{
    public partial class MainForm : Form
    {
        string con;
        double per;

        public MainForm()
        {
            InitializeComponent();
        }

        void invr()
        {
            bool bo = statop.Enabled;
            wtsh.Enabled = bo;
            statop.Enabled = !bo;
            actop.Enabled = !bo;
            frc.Enabled = !bo;
            pert.Enabled = !bo;
            if (bo)
                start.Text = "Stop";
            else
                start.Text = "Start";
        }

        void act()
        {
            if (actop.SelectedIndex == 0)
                Application.SetSuspendState(PowerState.Suspend, frc.Checked, true);
            else
                Application.SetSuspendState(PowerState.Hibernate, frc.Checked, true);
        }

        public class exes
        {

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

            [FlagsAttribute]
            public enum EXECUTION_STATE : uint
            {
                ES_AWAYMODE_REQUIRED = 0x00000040,
                ES_CONTINUOUS = 0x80000000,
                ES_DISPLAY_REQUIRED = 0x00000002,
                ES_SYSTEM_REQUIRED = 0x00000001
            }

            public static void ssprvnt()
            {
                allow();
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_AWAYMODE_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            }
            public static void sysprvnt()
            {
                allow();
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
            }
            public static void scrnprvnt()
            {
                allow();
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            }
            public static void allow()
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }
        }

        private void statop_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool bo = (statop.SelectedIndex == 0);
            pert.Visible = perl.Visible = !bo;
            pert.ReadOnly = bo;
        }

        private void start_Click(object sender, EventArgs e)
        {
            int tp;
            bool ok = Int32.TryParse(pert.Text, out tp);
            if (statop.SelectedIndex == -1 || actop.SelectedIndex == -1 || (statop.SelectedIndex == 1 && (pert.Text == "" || tp > 100 || tp < 0 || !ok)))
                MessageBox.Show("Are you kidding?!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                invr();
        }

        private void prvntsys_CheckedChanged(object sender, EventArgs e)
        {
            if (prvntsys.Checked == true)
                exes.sysprvnt();
        }

        private void prvntscrn_CheckedChanged(object sender, EventArgs e)
        {
            if (prvntscrn.Checked == true)
                exes.scrnprvnt();
        }

        private void prvntss_CheckedChanged(object sender, EventArgs e)
        {
            if (prvntss.Checked == true)
                exes.ssprvnt();
        }

        private void allowss_CheckedChanged(object sender, EventArgs e)
        {
            if (allowss.Checked == true)
                exes.allow();
        }

        private void upd_Tick(object sender, EventArgs e)
        {
            PowerStatus ps = SystemInformation.PowerStatus;
            con = ps.PowerLineStatus.ToString();
            per = ps.BatteryLifePercent * 100;
            stat.Text = "Power Line Status: " + con + " | Remaining In Battery Life: " + per.ToString() + '%';
        }

        private void wtsh_Tick(object sender, EventArgs e)
        {
            bool st1 = (statop.SelectedIndex == 0 && con == "Offline");
            int pit;
            Int32.TryParse(pert.Text, out pit);
            bool st2 = (statop.SelectedIndex == 1 && per <= pit);
            if (st1 || st2)
            {
                invr();
                act();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Ahmed Osama\nv1.0 | 2016\nahmedosama.me", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void mainf_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && (wtsh.Enabled || !allowss.Checked))
            {
                notifyIcon1.Visible = true;
                this.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        bool op = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (op)
                this.Width += 5;
            else
                this.Width -= 5;
            if (this.Width == 410 || this.Width == 650)
                timer1.Enabled = false;
        }

        private void extraOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = !op;
            timer1.Enabled = true;
        }
    }
}
