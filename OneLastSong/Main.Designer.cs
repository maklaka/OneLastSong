namespace OneLastSong
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnGo = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.FiveMoreMinutes = new System.Windows.Forms.Button();
            this.DisableMonitor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(5, 105);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(244, 66);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.OnGoClick);
            // 
            // Time
            // 
            this.Time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Time.Location = new System.Drawing.Point(47, 11);
            this.Time.Multiline = true;
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(154, 25);
            this.Time.TabIndex = 0;
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // Options
            // 
            this.Options.CausesValidation = false;
            this.Options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "Hibernate",
            "Shut Down",
            "Stand-by",
            "Restart (for some reason...)"});
            this.Options.Location = new System.Drawing.Point(47, 54);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(154, 21);
            this.Options.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "my PC";
            // 
            // lblCountDown
            // 
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(5, 176);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(244, 25);
            this.lblCountDown.TabIndex = 7;
            this.lblCountDown.Text = "00:00";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiveMoreMinutes
            // 
            this.FiveMoreMinutes.Enabled = false;
            this.FiveMoreMinutes.Location = new System.Drawing.Point(5, 205);
            this.FiveMoreMinutes.Name = "FiveMoreMinutes";
            this.FiveMoreMinutes.Size = new System.Drawing.Size(244, 23);
            this.FiveMoreMinutes.TabIndex = 4;
            this.FiveMoreMinutes.Text = "Add 5 Minutes";
            this.FiveMoreMinutes.UseVisualStyleBackColor = true;
            this.FiveMoreMinutes.Click += new System.EventHandler(this.OnFiveMoreMinutesClick);
            // 
            // DisableMonitor
            // 
            this.DisableMonitor.AutoSize = true;
            this.DisableMonitor.Checked = true;
            this.DisableMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableMonitor.Location = new System.Drawing.Point(53, 84);
            this.DisableMonitor.Name = "DisableMonitor";
            this.DisableMonitor.Size = new System.Drawing.Size(134, 17);
            this.DisableMonitor.TabIndex = 2;
            this.DisableMonitor.Text = "Turn off my monitor too";
            this.DisableMonitor.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 233);
            this.Controls.Add(this.DisableMonitor);
            this.Controls.Add(this.FiveMoreMinutes);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Last Song by MJones";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button FiveMoreMinutes;
        private System.Windows.Forms.CheckBox DisableMonitor;
    }
}

