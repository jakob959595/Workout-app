namespace Glavni_program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Workout = new System.Windows.Forms.Button();
            this.Exercises = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.MyWorkOutApp = new System.Windows.Forms.Label();
            this.Content_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ControlPanel.Controls.Add(this.Settings);
            this.ControlPanel.Controls.Add(this.Progress);
            this.ControlPanel.Controls.Add(this.Exercises);
            this.ControlPanel.Controls.Add(this.Workout);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(180, 487);
            this.ControlPanel.TabIndex = 0;
            // 
            // Workout
            // 
            this.Workout.Dock = System.Windows.Forms.DockStyle.Top;
            this.Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Workout.Location = new System.Drawing.Point(0, 0);
            this.Workout.Name = "Workout";
            this.Workout.Size = new System.Drawing.Size(180, 121);
            this.Workout.TabIndex = 0;
            this.Workout.Text = "Workout";
            this.Workout.UseVisualStyleBackColor = true;
            // 
            // Exercises
            // 
            this.Exercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exercises.Location = new System.Drawing.Point(0, 121);
            this.Exercises.Name = "Exercises";
            this.Exercises.Size = new System.Drawing.Size(180, 121);
            this.Exercises.TabIndex = 1;
            this.Exercises.Text = "Exercises";
            this.Exercises.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Top;
            this.Progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Progress.Location = new System.Drawing.Point(0, 242);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(180, 121);
            this.Progress.TabIndex = 2;
            this.Progress.Text = "Progress";
            this.Progress.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(0, 363);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(180, 121);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.Lime;
            this.NamePanel.Controls.Add(this.MyWorkOutApp);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(180, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(708, 80);
            this.NamePanel.TabIndex = 1;
            // 
            // MyWorkOutApp
            // 
            this.MyWorkOutApp.AutoSize = true;
            this.MyWorkOutApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.MyWorkOutApp.Location = new System.Drawing.Point(135, 9);
            this.MyWorkOutApp.Name = "MyWorkOutApp";
            this.MyWorkOutApp.Size = new System.Drawing.Size(408, 63);
            this.MyWorkOutApp.TabIndex = 0;
            this.MyWorkOutApp.Text = "MyWorkOutApp";
            this.MyWorkOutApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Content_panel
            // 
            this.Content_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_panel.Location = new System.Drawing.Point(180, 80);
            this.Content_panel.Name = "Content_panel";
            this.Content_panel.Size = new System.Drawing.Size(708, 407);
            this.Content_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 487);
            this.Controls.Add(this.Content_panel);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.ControlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ControlPanel.ResumeLayout(false);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button Workout;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Progress;
        private System.Windows.Forms.Button Exercises;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label MyWorkOutApp;
        private System.Windows.Forms.FlowLayoutPanel Content_panel;
        private System.Windows.Forms.Timer timer1;
    }
}

