namespace TimerReminderApp
{
    public partial class TimeReminderForm : Form
    {
        private int remainingSeconds;
        private bool started = false;

        public TimeReminderForm()
        {
            InitializeComponent();
        }

        private void TimeReminderForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                niMain.Visible = true;
            }
        }

        private void btnStartCancel_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                int hours = (int)nudHours.Value;
                int minutes = (int)nudMinutes.Value;

                remainingSeconds = (hours * 3600) + (minutes * 60);

                SetbtnStartCancelText();
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;

                tmrCountdown.Start();
            }
            else
            {
                tmrCountdown.Stop();
            }
        }

        private void niMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            niMain.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            niMain.Visible = false;
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            if (nudHours.Value > 0 || nudMinutes.Value > 0)
                btnStartCancel.Enabled = true;
            else
                btnStartCancel.Enabled = false;
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (nudHours.Value > 0 || nudMinutes.Value > 0)
                btnStartCancel.Enabled = true;
            else
                btnStartCancel.Enabled = false;
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
            }
            else
            {
                tmrCountdown.Stop();
                ShowReminderApp();
            }
        }

        private void ShowReminderApp()
        {
            Show();
            WindowState = FormWindowState.Normal;

            MessageBox.Show(txtReminderDescription.Text, "Timer Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetbtnStartCancelText()
        {
            if (started)
            {
                btnStartCancel.Text = "Start";
            }
            else
            {
                btnStartCancel.Text = "Cancel";
            }

            started = !started;
        }
    }
}
