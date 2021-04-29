
namespace Stepino
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxComm = new System.Windows.Forms.GroupBox();
            this.gbxMotion = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.gbxComm.SuspendLayout();
            this.gbxMotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(6, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4750,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.White;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(6, 81);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.White;
            this.btnScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Location = new System.Drawing.Point(6, 22);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(93, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan Ports";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(6, 51);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(93, 23);
            this.portComboBox.TabIndex = 4;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(6, 80);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.White;
            this.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Location = new System.Drawing.Point(6, 109);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(93, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 163);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(245, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(88, 17);
            this.statusLabel.Text = "No Connection";
            // 
            // gbxComm
            // 
            this.gbxComm.Controls.Add(this.btnScan);
            this.gbxComm.Controls.Add(this.portComboBox);
            this.gbxComm.Controls.Add(this.btnDisconnect);
            this.gbxComm.Controls.Add(this.btnConnect);
            this.gbxComm.Location = new System.Drawing.Point(12, 9);
            this.gbxComm.Name = "gbxComm";
            this.gbxComm.Size = new System.Drawing.Size(109, 141);
            this.gbxComm.TabIndex = 9;
            this.gbxComm.TabStop = false;
            this.gbxComm.Text = "Communication";
            // 
            // gbxMotion
            // 
            this.gbxMotion.Controls.Add(this.btnRun);
            this.gbxMotion.Controls.Add(this.btnHome);
            this.gbxMotion.Controls.Add(this.numericUpDown1);
            this.gbxMotion.Controls.Add(this.btnGo);
            this.gbxMotion.Location = new System.Drawing.Point(144, 9);
            this.gbxMotion.Name = "gbxMotion";
            this.gbxMotion.Size = new System.Drawing.Size(91, 141);
            this.gbxMotion.TabIndex = 10;
            this.gbxMotion.TabStop = false;
            this.gbxMotion.Text = "Motion";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(6, 109);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 185);
            this.Controls.Add(this.gbxMotion);
            this.Controls.Add(this.gbxComm);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMain";
            this.Text = "Stepino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbxComm.ResumeLayout(false);
            this.gbxMotion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox gbxComm;
        private System.Windows.Forms.GroupBox gbxMotion;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer;
    }
}

