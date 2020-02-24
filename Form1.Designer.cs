﻿namespace ImgToP3D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PathSourceText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LIT = new System.Windows.Forms.CheckBox();
            this.ATST = new System.Windows.Forms.CheckBox();
            this.TSID = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.UVMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BlendMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiffHEX = new System.Windows.Forms.TextBox();
            this.DiffuseBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PathOutputText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.PathSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.PathOutputDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffuseBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathSourceText
            // 
            this.PathSourceText.Location = new System.Drawing.Point(6, 23);
            this.PathSourceText.Name = "PathSourceText";
            this.PathSourceText.ReadOnly = true;
            this.PathSourceText.Size = new System.Drawing.Size(321, 20);
            this.PathSourceText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(333, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LIT
            // 
            this.LIT.AutoSize = true;
            this.LIT.Location = new System.Drawing.Point(9, 135);
            this.LIT.Name = "LIT";
            this.LIT.Size = new System.Drawing.Size(63, 17);
            this.LIT.TabIndex = 2;
            this.LIT.Text = "Lighting";
            this.LIT.UseVisualStyleBackColor = true;
            // 
            // ATST
            // 
            this.ATST.AutoSize = true;
            this.ATST.Location = new System.Drawing.Point(9, 158);
            this.ATST.Name = "ATST";
            this.ATST.Size = new System.Drawing.Size(77, 17);
            this.ATST.TabIndex = 2;
            this.ATST.Text = "Alpha Test";
            this.ATST.UseVisualStyleBackColor = true;
            // 
            // TSID
            // 
            this.TSID.AutoSize = true;
            this.TSID.Location = new System.Drawing.Point(9, 181);
            this.TSID.Name = "TSID";
            this.TSID.Size = new System.Drawing.Size(77, 17);
            this.TSID.TabIndex = 2;
            this.TSID.Text = "Two Sided";
            this.TSID.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // UVMode
            // 
            this.UVMode.FormattingEnabled = true;
            this.UVMode.Items.AddRange(new object[] {
            "Tile",
            "Clamp"});
            this.UVMode.Location = new System.Drawing.Point(78, 103);
            this.UVMode.Name = "UVMode";
            this.UVMode.Size = new System.Drawing.Size(157, 21);
            this.UVMode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UV Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterMode
            // 
            this.FilterMode.FormattingEnabled = true;
            this.FilterMode.Items.AddRange(new object[] {
            "Nearest Neighbour",
            "Linear",
            "Nearest Neighbour, Mip Nearest Neighbour",
            "Linear, Mip Nearest Neighbour",
            "Linear, Mip Linear"});
            this.FilterMode.Location = new System.Drawing.Point(78, 73);
            this.FilterMode.Name = "FilterMode";
            this.FilterMode.Size = new System.Drawing.Size(157, 21);
            this.FilterMode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Mode:";
            // 
            // BlendMode
            // 
            this.BlendMode.FormattingEnabled = true;
            this.BlendMode.Items.AddRange(new object[] {
            "None",
            "Alpha",
            "Additive",
            "Subtractive"});
            this.BlendMode.Location = new System.Drawing.Point(78, 44);
            this.BlendMode.Name = "BlendMode";
            this.BlendMode.Size = new System.Drawing.Size(157, 21);
            this.BlendMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blend Mode:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.PathSourceText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 63);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "path to image(s)";
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Settings.AutoSize = true;
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.DiffHEX);
            this.Settings.Controls.Add(this.DiffuseBox);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.BlendMode);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.FilterMode);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.UVMode);
            this.Settings.Controls.Add(this.TSID);
            this.Settings.Controls.Add(this.ATST);
            this.Settings.Controls.Add(this.LIT);
            this.Settings.Location = new System.Drawing.Point(3, 76);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(257, 217);
            this.Settings.TabIndex = 6;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "HEX:";
            // 
            // DiffHEX
            // 
            this.DiffHEX.Location = new System.Drawing.Point(139, 18);
            this.DiffHEX.Name = "DiffHEX";
            this.DiffHEX.Size = new System.Drawing.Size(96, 20);
            this.DiffHEX.TabIndex = 6;
            this.DiffHEX.Text = "#FFFFFF";
            this.DiffHEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiffHEX_KeyPress);
            // 
            // DiffuseBox
            // 
            this.DiffuseBox.BackColor = System.Drawing.Color.White;
            this.DiffuseBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiffuseBox.Location = new System.Drawing.Point(78, 18);
            this.DiffuseBox.Name = "DiffuseBox";
            this.DiffuseBox.Size = new System.Drawing.Size(20, 20);
            this.DiffuseBox.TabIndex = 5;
            this.DiffuseBox.TabStop = false;
            this.DiffuseBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Diffuse:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.PathOutputText);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(4, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output .p3dxml file";
            // 
            // PathOutputText
            // 
            this.PathOutputText.Location = new System.Drawing.Point(6, 23);
            this.PathOutputText.Name = "PathOutputText";
            this.PathOutputText.ReadOnly = true;
            this.PathOutputText.Size = new System.Drawing.Size(320, 20);
            this.PathOutputText.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(332, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 365);
            this.panel1.TabIndex = 8;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(285, 260);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(126, 16);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Wæsel On A Stick";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(338, 244);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 16);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tool page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(378, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(269, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 142);
            this.button3.TabIndex = 10;
            this.button3.Text = "PUSH\r\nDA\r\nBUTTON";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PathSourceDialog
            // 
            this.PathSourceDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 404);
            this.Name = "Form1";
            this.Text = "BITSS - Batch Image To Shader Script";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiffuseBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PathSourceText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox LIT;
        private System.Windows.Forms.CheckBox ATST;
        private System.Windows.Forms.CheckBox TSID;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox UVMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BlendMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PathOutputText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox DiffuseBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiffHEX;
        private System.Windows.Forms.OpenFileDialog PathSourceDialog;
        private System.Windows.Forms.SaveFileDialog PathOutputDialog;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
    }
}
