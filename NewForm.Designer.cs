﻿namespace Lain
{
    partial class NewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxRandomChars = new System.Windows.Forms.TextBox();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(16, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(594, 34);
            this.txtName.TabIndex = 62;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 61;
            this.label1.Tag = "themeable";
            this.label1.Text = "Title";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(16, 108);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(594, 34);
            this.txtMail.TabIndex = 64;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 63;
            this.label2.Tag = "themeable";
            this.label2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(16, 176);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(594, 34);
            this.txtPassword.TabIndex = 66;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 65;
            this.label3.Tag = "themeable";
            this.label3.Text = "Password";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(16, 368);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(594, 223);
            this.txtNote.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(11, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 67;
            this.label4.Tag = "themeable";
            this.label4.Text = "Notes (optional)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(398, 614);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 39);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Tag = "themeable";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(508, 614);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 39);
            this.btnOk.TabIndex = 69;
            this.btnOk.Tag = "themeable";
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 79;
            this.label5.Tag = "";
            this.label5.Text = "Length:";
            // 
            // txtMaxRandomChars
            // 
            this.txtMaxRandomChars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxRandomChars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMaxRandomChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxRandomChars.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRandomChars.ForeColor = System.Drawing.Color.White;
            this.txtMaxRandomChars.Location = new System.Drawing.Point(88, 221);
            this.txtMaxRandomChars.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxRandomChars.MaxLength = 888;
            this.txtMaxRandomChars.Name = "txtMaxRandomChars";
            this.txtMaxRandomChars.Size = new System.Drawing.Size(92, 30);
            this.txtMaxRandomChars.TabIndex = 78;
            this.txtMaxRandomChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxRandomChars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxRandomChars_KeyPress);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyPassword.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopyPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyPassword.Image")));
            this.btnCopyPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyPassword.Location = new System.Drawing.Point(361, 221);
            this.btnCopyPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(108, 31);
            this.btnCopyPassword.TabIndex = 77;
            this.btnCopyPassword.Tag = "themeable";
            this.btnCopyPassword.Text = "Copy";
            this.btnCopyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateRandom.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRandom.ForeColor = System.Drawing.Color.White;
            this.btnGenerateRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateRandom.Image")));
            this.btnGenerateRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateRandom.Location = new System.Drawing.Point(185, 221);
            this.btnGenerateRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(171, 31);
            this.btnGenerateRandom.TabIndex = 76;
            this.btnGenerateRandom.Tag = "themeable";
            this.btnGenerateRandom.Text = "Generate random";
            this.btnGenerateRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateRandom.UseVisualStyleBackColor = false;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(11, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 28);
            this.label6.TabIndex = 80;
            this.label6.Tag = "themeable";
            this.label6.Text = "Website URL (optional)";
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.White;
            this.txtLink.Location = new System.Drawing.Point(16, 298);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(594, 34);
            this.txtLink.TabIndex = 81;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(628, 665);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaxRandomChars);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new account...";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxRandomChars;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLink;
    }
}