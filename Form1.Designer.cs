
namespace Авторизация
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordCheck = new System.Windows.Forms.CheckBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(173, 175);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(173, 251);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(267, 175);
            this.LoginTextBox.MaxLength = 20;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(132, 20);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(267, 244);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(132, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(267, 286);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(132, 22);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordCheck
            // 
            this.passwordCheck.AutoSize = true;
            this.passwordCheck.Location = new System.Drawing.Point(406, 246);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(127, 17);
            this.passwordCheck.TabIndex = 5;
            this.passwordCheck.Text = "Посмотреть пароль";
            this.passwordCheck.UseVisualStyleBackColor = true;
            this.passwordCheck.CheckedChanged += new System.EventHandler(this.passwordCheck_CheckedChanged);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(267, 326);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(132, 22);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.passwordCheck);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.CheckBox passwordCheck;
        private System.Windows.Forms.Button registrationButton;
    }
}

