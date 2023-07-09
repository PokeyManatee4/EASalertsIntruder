namespace PriorityAlert
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.btnGeneratePlay = new System.Windows.Forms.Button();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.lblOriginator = new System.Windows.Forms.Label();
            this.comboOriginator = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.comboCode = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Magenta;
            this.lblVersion.Location = new System.Drawing.Point(492, 282);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(165, 44);
            this.lblVersion.TabIndex = 149;
            this.lblVersion.Text = "v0.0.0\r\nBunnyTub on Discord";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.Location = new System.Drawing.Point(510, 11);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(147, 36);
            this.btnAbout.TabIndex = 128;
            this.btnAbout.Tag = "disable";
            this.btnAbout.Text = "Open Fusion Settings";
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnnouncement.Location = new System.Drawing.Point(9, 121);
            this.lblAnnouncement.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(114, 15);
            this.lblAnnouncement.TabIndex = 132;
            this.lblAnnouncement.Text = "Announcement Text";
            // 
            // btnGeneratePlay
            // 
            this.btnGeneratePlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGeneratePlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneratePlay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePlay.Location = new System.Drawing.Point(510, 91);
            this.btnGeneratePlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneratePlay.Name = "btnGeneratePlay";
            this.btnGeneratePlay.Size = new System.Drawing.Size(147, 189);
            this.btnGeneratePlay.TabIndex = 130;
            this.btnGeneratePlay.Text = "PLAY";
            this.btnGeneratePlay.UseVisualStyleBackColor = false;
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnouncement.ForeColor = System.Drawing.Color.White;
            this.txtAnnouncement.Location = new System.Drawing.Point(12, 138);
            this.txtAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnouncement.MaxLength = 10000;
            this.txtAnnouncement.Multiline = true;
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnnouncement.Size = new System.Drawing.Size(476, 188);
            this.txtAnnouncement.TabIndex = 126;
            this.txtAnnouncement.Tag = "disable";
            // 
            // lblOriginator
            // 
            this.lblOriginator.AutoSize = true;
            this.lblOriginator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOriginator.Location = new System.Drawing.Point(9, 9);
            this.lblOriginator.Margin = new System.Windows.Forms.Padding(0);
            this.lblOriginator.Name = "lblOriginator";
            this.lblOriginator.Size = new System.Drawing.Size(103, 15);
            this.lblOriginator.TabIndex = 139;
            this.lblOriginator.Text = "Priority & Alerting";
            this.lblOriginator.UseMnemonic = false;
            // 
            // comboOriginator
            // 
            this.comboOriginator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboOriginator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOriginator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOriginator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboOriginator.ForeColor = System.Drawing.Color.White;
            this.comboOriginator.FormattingEnabled = true;
            this.comboOriginator.Location = new System.Drawing.Point(12, 26);
            this.comboOriginator.Margin = new System.Windows.Forms.Padding(2);
            this.comboOriginator.Name = "comboOriginator";
            this.comboOriginator.Size = new System.Drawing.Size(476, 29);
            this.comboOriginator.TabIndex = 110;
            this.comboOriginator.Tag = "disable";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCode.Location = new System.Drawing.Point(9, 65);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 15);
            this.lblCode.TabIndex = 136;
            this.lblCode.Text = "Code";
            // 
            // comboCode
            // 
            this.comboCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboCode.ForeColor = System.Drawing.Color.White;
            this.comboCode.FormattingEnabled = true;
            this.comboCode.Location = new System.Drawing.Point(12, 82);
            this.comboCode.Margin = new System.Windows.Forms.Padding(2);
            this.comboCode.Name = "comboCode";
            this.comboCode.Size = new System.Drawing.Size(476, 29);
            this.comboCode.TabIndex = 112;
            this.comboCode.Tag = "disable";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(510, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 150;
            this.button1.Tag = "disable";
            this.button1.Text = "Open Fusion Settings";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(668, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.btnGeneratePlay);
            this.Controls.Add(this.txtAnnouncement);
            this.Controls.Add(this.lblOriginator);
            this.Controls.Add(this.comboOriginator);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.comboCode);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriorityAlert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.Button btnGeneratePlay;
        private System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.Label lblOriginator;
        private System.Windows.Forms.ComboBox comboOriginator;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox comboCode;
        private System.Windows.Forms.Button button1;
    }
}