namespace OneLastSong
{
    partial class frmMain
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnFiveMore = new System.Windows.Forms.Button();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
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
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtTime
            // 
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Location = new System.Drawing.Point(47, 11);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(154, 25);
            this.txtTime.TabIndex = 0;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // cmbOption
            // 
            this.cmbOption.CausesValidation = false;
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Hibernate",
            "Shut Down",
            "Stand-by",
            "Restart (for some reason...)"});
            this.cmbOption.Location = new System.Drawing.Point(47, 54);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(154, 21);
            this.cmbOption.TabIndex = 1;
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
            // btnFiveMore
            // 
            this.btnFiveMore.Enabled = false;
            this.btnFiveMore.Location = new System.Drawing.Point(5, 205);
            this.btnFiveMore.Name = "btnFiveMore";
            this.btnFiveMore.Size = new System.Drawing.Size(244, 23);
            this.btnFiveMore.TabIndex = 4;
            this.btnFiveMore.Text = "Add 5 Minutes";
            this.btnFiveMore.UseVisualStyleBackColor = true;
            this.btnFiveMore.Click += new System.EventHandler(this.btnFiveMore_Click);
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Checked = true;
            this.chkMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonitor.Location = new System.Drawing.Point(53, 84);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(134, 17);
            this.chkMonitor.TabIndex = 2;
            this.chkMonitor.Text = "Turn off my monitor too";
            this.chkMonitor.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 233);
            this.Controls.Add(this.chkMonitor);
            this.Controls.Add(this.btnFiveMore);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Last Song by MJones";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timTimer;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button btnFiveMore;
        private System.Windows.Forms.CheckBox chkMonitor;
    }
}

