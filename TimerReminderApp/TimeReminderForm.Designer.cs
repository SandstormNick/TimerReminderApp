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
            txtReminderDescription = new TextBox();
            nudHours = new NumericUpDown();
            nudMinutes = new NumericUpDown();
            lblHours = new Label();
            lblMinutes = new Label();
            btnStartCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
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
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(104, 102);
            nudMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(75, 27);
            nudMinutes.TabIndex = 2;
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
            btnStartCancel.Location = new Point(12, 146);
            btnStartCancel.Name = "btnStartCancel";
            btnStartCancel.Size = new Size(386, 29);
            btnStartCancel.TabIndex = 5;
            btnStartCancel.Text = "Start";
            btnStartCancel.UseVisualStyleBackColor = true;
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
            Name = "TimeReminderForm";
            Text = "Timer Reminder";
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
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
    }
}
