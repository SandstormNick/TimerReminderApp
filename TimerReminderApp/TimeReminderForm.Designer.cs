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
            txtReminderDescription = new TextBox();
            nudHours = new NumericUpDown();
            nudMinutes = new NumericUpDown();
            lblHours = new Label();
            lblMinutes = new Label();
            btnStartCancel = new Button();
            niMain = new NotifyIcon(components);
            cmsNotifyMain = new ContextMenuStrip(components);
            showAppToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tmrCountdown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            cmsNotifyMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtReminderDescription
            // 
            txtReminderDescription.Location = new Point(12, 12);
            txtReminderDescription.Name = "txtReminderDescription";
            txtReminderDescription.Size = new Size(386, 27);
            txtReminderDescription.TabIndex = 0;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(104, 58);
            nudHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(75, 27);
            nudHours.TabIndex = 1;
            nudHours.ValueChanged += nudHours_ValueChanged;
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(104, 102);
            nudMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(75, 27);
            nudMinutes.TabIndex = 2;
            nudMinutes.ValueChanged += nudMinutes_ValueChanged;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHours.Location = new Point(12, 53);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(68, 28);
            lblHours.TabIndex = 3;
            lblHours.Text = "Hours:";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutes.Location = new Point(12, 97);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(86, 28);
            lblMinutes.TabIndex = 4;
            lblMinutes.Text = "Minutes:";
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
            // TimeReminderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 192);
            Controls.Add(btnStartCancel);
            Controls.Add(lblMinutes);
            Controls.Add(lblHours);
            Controls.Add(nudMinutes);
            Controls.Add(nudHours);
            Controls.Add(txtReminderDescription);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TimeReminderForm";
            Text = "Timer Reminder";
            Resize += TimeReminderForm_Resize;
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            cmsNotifyMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReminderDescription;
        private NumericUpDown nudHours;
        private NumericUpDown nudMinutes;
        private Label lblHours;
        private Label lblMinutes;
        private Button btnStartCancel;
        private NotifyIcon niMain;
        private ContextMenuStrip cmsNotifyMain;
        private ToolStripMenuItem showAppToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCountdown;
    }
}
