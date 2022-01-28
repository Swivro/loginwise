﻿namespace Lain
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.minimaltheme = new System.Windows.Forms.RadioButton();
            this.carameltheme = new System.Windows.Forms.RadioButton();
            this.limetheme = new System.Windows.Forms.RadioButton();
            this.magmatheme = new System.Windows.Forms.RadioButton();
            this.oceantheme = new System.Windows.Forms.RadioButton();
            this.zergtheme = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rLarge = new Lain.ColoredRadioButton();
            this.rNormal = new Lain.ColoredRadioButton();
            this.rSmall = new Lain.ColoredRadioButton();
            this.checkBox4 = new Lain.ColoredCheckBox();
            this.checkBox3 = new Lain.ColoredCheckBox();
            this.checkBox2 = new Lain.ColoredCheckBox();
            this.checkBox1 = new Lain.ColoredCheckBox();
            this.sizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimaltheme
            // 
            this.minimaltheme.AutoSize = true;
            this.minimaltheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimaltheme.ForeColor = System.Drawing.Color.Gray;
            this.minimaltheme.Location = new System.Drawing.Point(152, 126);
            this.minimaltheme.Margin = new System.Windows.Forms.Padding(2);
            this.minimaltheme.Name = "minimaltheme";
            this.minimaltheme.Size = new System.Drawing.Size(106, 32);
            this.minimaltheme.TabIndex = 76;
            this.minimaltheme.Text = "Minimal";
            this.minimaltheme.UseVisualStyleBackColor = true;
            this.minimaltheme.CheckedChanged += new System.EventHandler(this.minimaltheme_CheckedChanged);
            // 
            // carameltheme
            // 
            this.carameltheme.AutoSize = true;
            this.carameltheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carameltheme.ForeColor = System.Drawing.Color.DarkOrange;
            this.carameltheme.Location = new System.Drawing.Point(152, 50);
            this.carameltheme.Margin = new System.Windows.Forms.Padding(2);
            this.carameltheme.Name = "carameltheme";
            this.carameltheme.Size = new System.Drawing.Size(106, 32);
            this.carameltheme.TabIndex = 75;
            this.carameltheme.Text = "Caramel";
            this.carameltheme.UseVisualStyleBackColor = true;
            this.carameltheme.CheckedChanged += new System.EventHandler(this.carameltheme_CheckedChanged);
            // 
            // limetheme
            // 
            this.limetheme.AutoSize = true;
            this.limetheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limetheme.ForeColor = System.Drawing.Color.LimeGreen;
            this.limetheme.Location = new System.Drawing.Point(152, 88);
            this.limetheme.Margin = new System.Windows.Forms.Padding(2);
            this.limetheme.Name = "limetheme";
            this.limetheme.Size = new System.Drawing.Size(77, 32);
            this.limetheme.TabIndex = 74;
            this.limetheme.Text = "Lime";
            this.limetheme.UseVisualStyleBackColor = true;
            this.limetheme.CheckedChanged += new System.EventHandler(this.limetheme_CheckedChanged);
            // 
            // magmatheme
            // 
            this.magmatheme.AutoSize = true;
            this.magmatheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magmatheme.ForeColor = System.Drawing.Color.Tomato;
            this.magmatheme.Location = new System.Drawing.Point(38, 88);
            this.magmatheme.Margin = new System.Windows.Forms.Padding(2);
            this.magmatheme.Name = "magmatheme";
            this.magmatheme.Size = new System.Drawing.Size(101, 32);
            this.magmatheme.TabIndex = 73;
            this.magmatheme.Text = "Magma";
            this.magmatheme.UseVisualStyleBackColor = true;
            this.magmatheme.CheckedChanged += new System.EventHandler(this.magmatheme_CheckedChanged);
            // 
            // oceantheme
            // 
            this.oceantheme.AutoSize = true;
            this.oceantheme.Checked = true;
            this.oceantheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceantheme.ForeColor = System.Drawing.Color.DodgerBlue;
            this.oceantheme.Location = new System.Drawing.Point(38, 50);
            this.oceantheme.Margin = new System.Windows.Forms.Padding(2);
            this.oceantheme.Name = "oceantheme";
            this.oceantheme.Size = new System.Drawing.Size(90, 32);
            this.oceantheme.TabIndex = 72;
            this.oceantheme.TabStop = true;
            this.oceantheme.Text = "Ocean";
            this.oceantheme.UseVisualStyleBackColor = true;
            this.oceantheme.CheckedChanged += new System.EventHandler(this.oceantheme_CheckedChanged);
            // 
            // zergtheme
            // 
            this.zergtheme.AutoSize = true;
            this.zergtheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zergtheme.ForeColor = System.Drawing.Color.MediumOrchid;
            this.zergtheme.Location = new System.Drawing.Point(38, 126);
            this.zergtheme.Margin = new System.Windows.Forms.Padding(2);
            this.zergtheme.Name = "zergtheme";
            this.zergtheme.Size = new System.Drawing.Size(75, 32);
            this.zergtheme.TabIndex = 71;
            this.zergtheme.Text = "Zerg";
            this.zergtheme.UseVisualStyleBackColor = true;
            this.zergtheme.CheckedChanged += new System.EventHandler(this.zergtheme_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(192, 28);
            this.label27.TabIndex = 70;
            this.label27.Tag = "themeable";
            this.label27.Text = "Choose your theme";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(269, 521);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 39);
            this.btnOk.TabIndex = 77;
            this.btnOk.Tag = "themeable";
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimer.Enabled = false;
            this.txtTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.White;
            this.txtTimer.Location = new System.Drawing.Point(168, 420);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ShortcutsEnabled = false;
            this.txtTimer.Size = new System.Drawing.Size(62, 34);
            this.txtTimer.TabIndex = 80;
            this.txtTimer.Text = "2";
            this.txtTimer.TextChanged += new System.EventHandler(this.txtTimer_TextChanged);
            this.txtTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 81;
            this.label1.Text = "minutes";
            // 
            // sizePanel
            // 
            this.sizePanel.Controls.Add(this.label2);
            this.sizePanel.Controls.Add(this.rLarge);
            this.sizePanel.Controls.Add(this.rNormal);
            this.sizePanel.Controls.Add(this.rSmall);
            this.sizePanel.Location = new System.Drawing.Point(12, 174);
            this.sizePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(276, 165);
            this.sizePanel.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 84;
            this.label2.Tag = "themeable";
            this.label2.Text = "Choose your font size";
            // 
            // rLarge
            // 
            this.rLarge.AutoSize = true;
            this.rLarge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLarge.ForeColor = System.Drawing.Color.White;
            this.rLarge.Location = new System.Drawing.Point(25, 116);
            this.rLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rLarge.Name = "rLarge";
            this.rLarge.Size = new System.Drawing.Size(83, 32);
            this.rLarge.TabIndex = 79;
            this.rLarge.Tag = "";
            this.rLarge.Text = "Large";
            this.rLarge.UseVisualStyleBackColor = true;
            this.rLarge.CheckedChanged += new System.EventHandler(this.rLarge_CheckedChanged);
            // 
            // rNormal
            // 
            this.rNormal.AutoSize = true;
            this.rNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNormal.ForeColor = System.Drawing.Color.White;
            this.rNormal.Location = new System.Drawing.Point(25, 78);
            this.rNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rNormal.Name = "rNormal";
            this.rNormal.Size = new System.Drawing.Size(100, 32);
            this.rNormal.TabIndex = 78;
            this.rNormal.Tag = "";
            this.rNormal.Text = "Normal";
            this.rNormal.UseVisualStyleBackColor = true;
            this.rNormal.CheckedChanged += new System.EventHandler(this.rNormal_CheckedChanged);
            // 
            // rSmall
            // 
            this.rSmall.AutoSize = true;
            this.rSmall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSmall.ForeColor = System.Drawing.Color.White;
            this.rSmall.Location = new System.Drawing.Point(25, 40);
            this.rSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rSmall.Name = "rSmall";
            this.rSmall.Size = new System.Drawing.Size(82, 32);
            this.rSmall.TabIndex = 77;
            this.rSmall.Tag = "";
            this.rSmall.Text = "Small";
            this.rSmall.UseVisualStyleBackColor = true;
            this.rSmall.CheckedChanged += new System.EventHandler(this.rSmall_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(18, 382);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(255, 32);
            this.checkBox4.TabIndex = 84;
            this.checkBox4.Text = "Hide account passwords";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(18, 459);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(308, 32);
            this.checkBox3.TabIndex = 79;
            this.checkBox3.Text = "Start Loginwise with Windows";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(18, 421);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 32);
            this.checkBox2.TabIndex = 78;
            this.checkBox2.Text = "Auto lock in";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 345);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(324, 32);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Always ask for master password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(370, 572);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.sizePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.minimaltheme);
            this.Controls.Add(this.carameltheme);
            this.Controls.Add(this.limetheme);
            this.Controls.Add(this.magmatheme);
            this.Controls.Add(this.oceantheme);
            this.Controls.Add(this.zergtheme);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.checkBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.sizePanel.ResumeLayout(false);
            this.sizePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColoredCheckBox checkBox1;
        private System.Windows.Forms.RadioButton minimaltheme;
        private System.Windows.Forms.RadioButton carameltheme;
        private System.Windows.Forms.RadioButton limetheme;
        private System.Windows.Forms.RadioButton magmatheme;
        private System.Windows.Forms.RadioButton oceantheme;
        private System.Windows.Forms.RadioButton zergtheme;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnOk;
        private ColoredCheckBox checkBox2;
        private ColoredCheckBox checkBox3;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.Label label2;
        private ColoredRadioButton rLarge;
        private ColoredRadioButton rNormal;
        private ColoredRadioButton rSmall;
        private ColoredCheckBox checkBox4;
    }
}