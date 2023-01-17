namespace Arduino_PulseGenerator
{
    partial class FormMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.numericUpDownFreq = new System.Windows.Forms.NumericUpDown();
            this.lblms = new System.Windows.Forms.Label();
            this.picturePulse = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblRxData = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePulse)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(173, 91);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 49);
            this.btnSend.TabIndex = 104;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(173, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 49);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(173, 21);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 49);
            this.btnOpen.TabIndex = 101;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.ItemHeight = 26;
            this.cmbPortName.Location = new System.Drawing.Point(20, 30);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(104, 34);
            this.cmbPortName.TabIndex = 100;
            this.cmbPortName.DropDown += new System.EventHandler(this.cmbPortName_DropDown);
            // 
            // numericUpDownFreq
            // 
            this.numericUpDownFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownFreq.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownFreq.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownFreq.Location = new System.Drawing.Point(20, 100);
            this.numericUpDownFreq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFreq.Name = "numericUpDownFreq";
            this.numericUpDownFreq.Size = new System.Drawing.Size(104, 33);
            this.numericUpDownFreq.TabIndex = 108;
            this.numericUpDownFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFreq.ThousandsSeparator = true;
            this.numericUpDownFreq.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFreq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDownFreq_KeyDown);
            // 
            // lblms
            // 
            this.lblms.AutoSize = true;
            this.lblms.BackColor = System.Drawing.SystemColors.Control;
            this.lblms.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblms.ForeColor = System.Drawing.Color.Red;
            this.lblms.Location = new System.Drawing.Point(122, 102);
            this.lblms.Name = "lblms";
            this.lblms.Size = new System.Drawing.Size(37, 26);
            this.lblms.TabIndex = 110;
            this.lblms.Text = "ms";
            // 
            // picturePulse
            // 
            this.picturePulse.Image = global::Arduino_PulseGenerator.Properties.Resources.pulse;
            this.picturePulse.Location = new System.Drawing.Point(12, 161);
            this.picturePulse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picturePulse.Name = "picturePulse";
            this.picturePulse.Size = new System.Drawing.Size(265, 144);
            this.picturePulse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePulse.TabIndex = 111;
            this.picturePulse.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblRxData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(299, 24);
            this.statusStrip1.TabIndex = 113;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLblRxData
            // 
            this.toolStripStatusLblRxData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLblRxData.Name = "toolStripStatusLblRxData";
            this.toolStripStatusLblRxData.Size = new System.Drawing.Size(60, 19);
            this.toolStripStatusLblRxData.Text = "Rx Data";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picturePulse);
            this.Controls.Add(this.numericUpDownFreq);
            this.Controls.Add(this.lblms);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbPortName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 384);
            this.MinimumSize = new System.Drawing.Size(315, 384);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino pulse generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePulse)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbPortName;
        public System.Windows.Forms.NumericUpDown numericUpDownFreq;
        private System.Windows.Forms.Label lblms;
        private System.Windows.Forms.PictureBox picturePulse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblRxData;
    }
}

