namespace loginAndRegistration
{
    partial class RegistrationForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.emailField = new System.Windows.Forms.TextBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goToLoginForm = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goToLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.passwordField);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.registrationButton);
            this.mainPanel.Controls.Add(this.emailField);
            this.mainPanel.Controls.Add(this.firstNameField);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(641, 348);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F);
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Придумайте пароль:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Придумайте логин:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F);
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите email:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите имя:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.passwordField.Location = new System.Drawing.Point(312, 226);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(316, 35);
            this.passwordField.TabIndex = 11;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.loginField.Location = new System.Drawing.Point(312, 183);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(316, 35);
            this.loginField.TabIndex = 9;
            this.loginField.Enter += new System.EventHandler(this.enterText_Enter);
            this.loginField.Leave += new System.EventHandler(this.enterText_Leave);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(151)))), ((int)(((byte)(36)))));
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(151)))), ((int)(((byte)(36)))));
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(0, 285);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(641, 63);
            this.registrationButton.TabIndex = 12;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // emailField
            // 
            this.emailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.emailField.Location = new System.Drawing.Point(312, 140);
            this.emailField.Margin = new System.Windows.Forms.Padding(4);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(316, 35);
            this.emailField.TabIndex = 6;
            this.emailField.Enter += new System.EventHandler(this.enterText_Enter);
            this.emailField.Leave += new System.EventHandler(this.enterText_Leave);
            // 
            // firstNameField
            // 
            this.firstNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameField.Font = new System.Drawing.Font("Arial", 17.8F);
            this.firstNameField.Location = new System.Drawing.Point(312, 97);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameField.Multiline = true;
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(316, 35);
            this.firstNameField.TabIndex = 4;
            this.firstNameField.Enter += new System.EventHandler(this.enterText_Enter);
            this.firstNameField.Leave += new System.EventHandler(this.enterText_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.goToLoginForm);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 75);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(601, 0);
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
            this.label1.Size = new System.Drawing.Size(641, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMoveWindow_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseMove);
            // 
            // goToLoginForm
            // 
            this.goToLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLoginForm.Image = global::loginAndRegistration.Properties.Resources.back_arrow;
            this.goToLoginForm.Location = new System.Drawing.Point(0, 35);
            this.goToLoginForm.Name = "goToLoginForm";
            this.goToLoginForm.Size = new System.Drawing.Size(40, 40);
            this.goToLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goToLoginForm.TabIndex = 3;
            this.goToLoginForm.TabStop = false;
            this.goToLoginForm.Click += new System.EventHandler(this.goToLoginForm_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 348);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goToLoginForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox goToLoginForm;
    }
}