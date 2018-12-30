namespace WorldOfGold_V2
{
    partial class LoginForm
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
            this.tbLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnReg = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbRLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            // 
            // 
            // 
            this.tbLogin.CustomButton.Image = null;
            this.tbLogin.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbLogin.CustomButton.Name = "";
            this.tbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLogin.CustomButton.TabIndex = 1;
            this.tbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLogin.CustomButton.UseSelectable = true;
            this.tbLogin.CustomButton.Visible = false;
            this.tbLogin.Lines = new string[0];
            this.tbLogin.Location = new System.Drawing.Point(112, 71);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(150, 23);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.UseSelectable = true;
            this.tbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 36);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(322, 391);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnLogIn);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.tbPassword);
            this.metroTabPage1.Controls.Add(this.tbLogin);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(314, 349);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Авторизация";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnLogIn
            // 
            this.btnLogIn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogIn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnLogIn.Location = new System.Drawing.Point(143, 236);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(119, 30);
            this.btnLogIn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Войти";
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин:";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(112, 115);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(150, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnReg);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.tbRPassword);
            this.metroTabPage2.Controls.Add(this.tbRLogin);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(314, 349);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Регистрация";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnReg
            // 
            this.btnReg.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReg.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnReg.Location = new System.Drawing.Point(112, 236);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(150, 30);
            this.btnReg.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Создать аккаунт";
            this.btnReg.UseSelectable = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Логин:";
            // 
            // tbRPassword
            // 
            // 
            // 
            // 
            this.tbRPassword.CustomButton.Image = null;
            this.tbRPassword.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbRPassword.CustomButton.Name = "";
            this.tbRPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRPassword.CustomButton.TabIndex = 1;
            this.tbRPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRPassword.CustomButton.UseSelectable = true;
            this.tbRPassword.CustomButton.Visible = false;
            this.tbRPassword.Lines = new string[0];
            this.tbRPassword.Location = new System.Drawing.Point(112, 115);
            this.tbRPassword.MaxLength = 32767;
            this.tbRPassword.Name = "tbRPassword";
            this.tbRPassword.PasswordChar = '●';
            this.tbRPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRPassword.SelectedText = "";
            this.tbRPassword.SelectionLength = 0;
            this.tbRPassword.SelectionStart = 0;
            this.tbRPassword.ShortcutsEnabled = true;
            this.tbRPassword.Size = new System.Drawing.Size(150, 23);
            this.tbRPassword.TabIndex = 1;
            this.tbRPassword.UseSelectable = true;
            this.tbRPassword.UseSystemPasswordChar = true;
            this.tbRPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbRLogin
            // 
            // 
            // 
            // 
            this.tbRLogin.CustomButton.Image = null;
            this.tbRLogin.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbRLogin.CustomButton.Name = "";
            this.tbRLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRLogin.CustomButton.TabIndex = 1;
            this.tbRLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRLogin.CustomButton.UseSelectable = true;
            this.tbRLogin.CustomButton.Visible = false;
            this.tbRLogin.Lines = new string[0];
            this.tbRLogin.Location = new System.Drawing.Point(112, 71);
            this.tbRLogin.MaxLength = 32767;
            this.tbRLogin.Name = "tbRLogin";
            this.tbRLogin.PasswordChar = '\0';
            this.tbRLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRLogin.SelectedText = "";
            this.tbRLogin.SelectionLength = 0;
            this.tbRLogin.SelectionStart = 0;
            this.tbRLogin.ShortcutsEnabled = true;
            this.tbRLogin.Size = new System.Drawing.Size(150, 23);
            this.tbRLogin.TabIndex = 1;
            this.tbRLogin.UseSelectable = true;
            this.tbRLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbLogin;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox tbRPassword;
        private MetroFramework.Controls.MetroTextBox tbRLogin;
    }
}

