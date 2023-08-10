﻿namespace etb
{
    partial class FormLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxRegisterMail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxBirthDay = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCreditCard = new System.Windows.Forms.MaskedTextBox();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(324, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.Location = new System.Drawing.Point(39, 174);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(242, 49);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(109, 117);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(172, 27);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(109, 51);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(172, 27);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(35, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Parola";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(35, 54);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-Mail:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Controls.Add(this.tabPageRegister);
            this.tabControl1.Location = new System.Drawing.Point(132, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 535);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tabPageLogin.Controls.Add(this.groupBox1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(340, 502);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Giriş Yap";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tabPageRegister.Controls.Add(this.groupBox2);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 29);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(340, 502);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Kayıt Ol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChoosePhoto);
            this.groupBox2.Controls.Add(this.maskedTextBoxCreditCard);
            this.groupBox2.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox2.Controls.Add(this.radioButtonFemale);
            this.groupBox2.Controls.Add(this.radioButtonMale);
            this.groupBox2.Controls.Add(this.maskedTextBoxBirthDay);
            this.groupBox2.Controls.Add(this.textBoxAddress);
            this.groupBox2.Controls.Add(this.textBoxRegisterPassword);
            this.groupBox2.Controls.Add(this.textBoxRegisterMail);
            this.groupBox2.Controls.Add(this.textBoxSurname);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelRegisterPassword);
            this.groupBox2.Controls.Add(this.labelRegisterEmail);
            this.groupBox2.Controls.Add(this.labelSurname);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Location = new System.Drawing.Point(4, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 489);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "İsim:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(17, 71);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(63, 20);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Soyisim:";
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(17, 141);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(53, 20);
            this.labelRegisterPassword.TabIndex = 3;
            this.labelRegisterPassword.Text = "Parola:";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(17, 106);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(55, 20);
            this.labelRegisterEmail.TabIndex = 2;
            this.labelRegisterEmail.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "label10";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 27);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(128, 69);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(172, 27);
            this.textBoxSurname.TabIndex = 11;
            // 
            // textBoxRegisterMail
            // 
            this.textBoxRegisterMail.Location = new System.Drawing.Point(128, 102);
            this.textBoxRegisterMail.Name = "textBoxRegisterMail";
            this.textBoxRegisterMail.Size = new System.Drawing.Size(172, 27);
            this.textBoxRegisterMail.TabIndex = 12;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(128, 135);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(172, 27);
            this.textBoxRegisterPassword.TabIndex = 14;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(128, 234);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(172, 27);
            this.textBoxAddress.TabIndex = 16;
            // 
            // maskedTextBoxBirthDay
            // 
            this.maskedTextBoxBirthDay.Location = new System.Drawing.Point(128, 168);
            this.maskedTextBoxBirthDay.Name = "maskedTextBoxBirthDay";
            this.maskedTextBoxBirthDay.Size = new System.Drawing.Size(172, 27);
            this.maskedTextBoxBirthDay.TabIndex = 19;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(128, 202);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(62, 24);
            this.radioButtonMale.TabIndex = 20;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Erkek";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(235, 201);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(65, 24);
            this.radioButtonFemale.TabIndex = 21;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Kadın";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(128, 268);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(172, 27);
            this.maskedTextBoxPhone.TabIndex = 22;
            // 
            // maskedTextBoxCreditCard
            // 
            this.maskedTextBoxCreditCard.Location = new System.Drawing.Point(128, 301);
            this.maskedTextBoxCreditCard.Mask = "0000000000000000";
            this.maskedTextBoxCreditCard.Name = "maskedTextBoxCreditCard";
            this.maskedTextBoxCreditCard.Size = new System.Drawing.Size(172, 27);
            this.maskedTextBoxCreditCard.TabIndex = 23;
            this.maskedTextBoxCreditCard.ValidatingType = typeof(int);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonChoosePhoto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonChoosePhoto.Location = new System.Drawing.Point(128, 335);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(172, 40);
            this.buttonChoosePhoto.TabIndex = 24;
            this.buttonChoosePhoto.Text = "Fotoğraf Seç";
            this.buttonChoosePhoto.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(670, 626);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageRegister.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterMail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthDay;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCreditCard;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}
