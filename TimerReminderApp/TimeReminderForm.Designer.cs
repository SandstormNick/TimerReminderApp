namespace TimerReminderApp
{
    partial class TimeReminderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeReminderForm));
            btnStartCancel = new Button();
            niMain = new NotifyIcon(components);
            cmsNotifyMain = new ContextMenuStrip(components);
            showAppToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tmrCountdown = new System.Windows.Forms.Timer(components);
            pnlFormControls = new Panel();
            lblMinutes = new Label();
            lblHours = new Label();
            nudMinutes = new NumericUpDown();
            nudHours = new NumericUpDown();
            txtReminderDescription = new TextBox();
            lblDisplayTime = new Label();
            cmsNotifyMain.SuspendLayout();
            pnlFormControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            SuspendLayout();
            // 
            // btnStartCancel
            // 
            btnStartCancel.Enabled = false;
            btnStartCancel.Location = new Point(12, 146);
            btnStartCancel.Name = "btnStartCancel";
            btnStartCancel.Size = new Size(386, 29);
            btnStartCancel.TabIndex = 5;
            btnStartCancel.Text = "Start";
            btnStartCancel.UseVisualStyleBackColor = true;
            btnStartCancel.Click += btnStartCancel_Click;
            // 
            // niMain
            // 
            niMain.ContextMenuStrip = cmsNotifyMain;
            niMain.Icon = (Icon)resources.GetObject("niMain.Icon");
            niMain.Text = "Timer Reminder";
            niMain.MouseDoubleClick += niMain_MouseDoubleClick;
            // 
            // cmsNotifyMain
            // 
            cmsNotifyMain.ImageScalingSize = new Size(20, 20);
            cmsNotifyMain.Items.AddRange(new ToolStripItem[] { showAppToolStripMenuItem, exitToolStripMenuItem });
            cmsNotifyMain.Name = "cmsNotifyMain";
            cmsNotifyMain.Size = new Size(147, 52);
            // 
            // showAppToolStripMenuItem
            // 
            showAppToolStripMenuItem.Name = "showAppToolStripMenuItem";
            showAppToolStripMenuItem.Size = new Size(146, 24);
            showAppToolStripMenuItem.Text = "Show App";
            showAppToolStripMenuItem.Click += showAppToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tmrCountdown
            // 
            tmrCountdown.Interval = 1000;
            tmrCountdown.Tick += tmrCountdown_Tick;
            // 
            // pnlFormControls
            // 
            pnlFormControls.Controls.Add(lblMinutes);
            pnlFormControls.Controls.Add(lblHours);
            pnlFormControls.Controls.Add(nudMinutes);
            pnlFormControls.Controls.Add(nudHours);
            pnlFormControls.Controls.Add(txtReminderDescription);
            pnlFormControls.Location = new Point(2, 4);
            pnlFormControls.Name = "pnlFormControls";
            pnlFormControls.Size = new Size(403, 136);
            pnlFormControls.TabIndex = 6;
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutes.Location = new Point(8, 95);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(86, 28);
            lblMinutes.TabIndex = 9;
            lblMinutes.Text = "Minutes:";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHours.Location = new Point(8, 51);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(68, 28);
            lblHours.TabIndex = 8;
            lblHours.Text = "Hours:";
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(100, 100);
            nudMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(75, 27);
            nudMinutes.TabIndex = 7;
            nudMinutes.ValueChanged += nudMinutes_ValueChanged;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(100, 56);
            nudHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(75, 27);
            nudHours.TabIndex = 6;
            nudHours.ValueChanged += nudHours_ValueChanged;
            // 
            // txtReminderDescription
            // 
            txtReminderDescription.Location = new Point(8, 10);
            txtReminderDescription.Name = "txtReminderDescription";
            txtReminderDescription.Size = new Size(386, 27);
            txtReminderDescription.TabIndex = 5;
            // 
            // lblDisplayTime
            // 
            lblDisplayTime.AutoSize = true;
            lblDisplayTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayTime.Location = new Point(72, 30);
            lblDisplayTime.Name = "lblDisplayTime";
            lblDisplayTime.Size = new Size(253, 81);
            lblDisplayTime.TabIndex = 10;
            lblDisplayTime.Text = "00:00:00";
            lblDisplayTime.Visible = false;
            // 
            // TimeReminderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 192);
            Controls.Add(btnStartCancel);
            Controls.Add(pnlFormControls);
            Controls.Add(lblDisplayTime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TimeReminderForm";
            Text = "Timer Reminder";
            Resize += TimeReminderForm_Resize;
            cmsNotifyMain.ResumeLayout(false);
            pnlFormControls.ResumeLayout(false);
            pnlFormControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStartCancel;
        private NotifyIcon niMain;
        private ContextMenuStrip cmsNotifyMain;
        private ToolStripMenuItem showAppToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCountdown;
        private Panel pnlFormControls;
        private Label lblMinutes;
        private Label lblHours;
        private NumericUpDown nudMinutes;
        private NumericUpDown nudHours;
        private TextBox txtReminderDescription;
        private Label lblDisplayTime;
    }
}
