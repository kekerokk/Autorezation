
namespace Авторизация
{
    partial class Form3
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
            this.registrationButton = new System.Windows.Forms.Button();
            this.regLoginTextBox = new System.Windows.Forms.Label();
            this.regPasswordTextBox = new System.Windows.Forms.Label();
            this.loginRegTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(379, 281);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(134, 23);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registationButton);
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.AutoSize = true;
            this.regLoginTextBox.Location = new System.Drawing.Point(298, 154);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(38, 13);
            this.regLoginTextBox.TabIndex = 1;
            this.regLoginTextBox.Text = "Логин";
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.AutoSize = true;
            this.regPasswordTextBox.Location = new System.Drawing.Point(298, 206);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.Size = new System.Drawing.Size(45, 13);
            this.regPasswordTextBox.TabIndex = 2;
            this.regPasswordTextBox.Text = "Пароль";
            // 
            // loginRegTextBox
            // 
            this.loginRegTextBox.Location = new System.Drawing.Point(379, 154);
            this.loginRegTextBox.MaxLength = 20;
            this.loginRegTextBox.Name = "loginRegTextBox";
            this.loginRegTextBox.Size = new System.Drawing.Size(134, 20);
            this.loginRegTextBox.TabIndex = 3;
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(379, 203);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.Size = new System.Drawing.Size(134, 20);
            this.passwordRegTextBox.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordRegTextBox);
            this.Controls.Add(this.loginRegTextBox);
            this.Controls.Add(this.regPasswordTextBox);
            this.Controls.Add(this.regLoginTextBox);
            this.Controls.Add(this.registrationButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label regLoginTextBox;
        private System.Windows.Forms.Label regPasswordTextBox;
        private System.Windows.Forms.TextBox loginRegTextBox;
        private System.Windows.Forms.TextBox passwordRegTextBox;
    }
}