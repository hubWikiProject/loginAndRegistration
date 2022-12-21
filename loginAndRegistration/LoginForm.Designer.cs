namespace loginAndRegistration
{
    partial class LoginForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.newRegistrationBtn = new System.Windows.Forms.Label();
            this.enterUserButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.mainPanel.Controls.Add(this.newRegistrationBtn);
            this.mainPanel.Controls.Add(this.enterUserButton);
            this.mainPanel.Controls.Add(this.passwordField);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(403, 319);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // newRegistrationBtn
            // 
            this.newRegistrationBtn.AutoSize = true;
            this.newRegistrationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRegistrationBtn.Font = new System.Drawing.Font("Arial", 12.8F);
            this.newRegistrationBtn.Location = new System.Drawing.Point(98, 273);
            this.newRegistrationBtn.Name = "newRegistrationBtn";
            this.newRegistrationBtn.Size = new System.Drawing.Size(201, 25);
            this.newRegistrationBtn.TabIndex = 8;
            this.newRegistrationBtn.Text = "Еще нет аккаунта?";
            this.newRegistrationBtn.Click += new System.EventHandler(this.newRegistrationBtn_Click);
            // 
            // enterUserButton
            // 
            this.enterUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(151)))), ((int)(((byte)(57)))));
            this.enterUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterUserButton.FlatAppearance.BorderSize = 0;
            this.enterUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(151)))), ((int)(((byte)(36)))));
            this.enterUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(151)))), ((int)(((byte)(36)))));
            this.enterUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterUserButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterUserButton.ForeColor = System.Drawing.Color.White;
            this.enterUserButton.Location = new System.Drawing.Point(0, 191);
            this.enterUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterUserButton.Name = "enterUserButton";
            this.enterUserButton.Size = new System.Drawing.Size(403, 63);
            this.enterUserButton.TabIndex = 7;
            this.enterUserButton.Text = "ВОЙТИ";
            this.enterUserButton.UseVisualStyleBackColor = false;
            this.enterUserButton.Click += new System.EventHandler(this.enterUserButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.passwordField.Location = new System.Drawing.Point(59, 138);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(331, 35);
            this.passwordField.TabIndex = 6;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::loginAndRegistration.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(16, 138);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.loginField.Location = new System.Drawing.Point(59, 95);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(331, 35);
            this.loginField.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loginAndRegistration.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(16, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 75);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(363, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 27);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 319);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button enterUserButton;
        private System.Windows.Forms.Label newRegistrationBtn;
    }
}