namespace WorldOfGold_V2
{
    partial class UCAddNewProduct
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescription = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaterial = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProb = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbMaterial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbProb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 370);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAdd.Location = new System.Drawing.Point(453, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnView.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnView.Location = new System.Drawing.Point(59, 202);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(170, 36);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "Обзор";
            this.btnView.UseCustomBackColor = true;
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(440, 52);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(183, 29);
            this.cmbCategory.TabIndex = 16;
            this.cmbCategory.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(436, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Вид продукции:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(237, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Описание:";
            // 
            // tbDescription
            // 
            // 
            // 
            // 
            this.tbDescription.CustomButton.Image = null;
            this.tbDescription.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.tbDescription.CustomButton.Name = "";
            this.tbDescription.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescription.CustomButton.TabIndex = 1;
            this.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescription.CustomButton.UseSelectable = true;
            this.tbDescription.CustomButton.Visible = false;
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(239, 159);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(384, 79);
            this.tbDescription.TabIndex = 14;
            this.tbDescription.UseSelectable = true;
            this.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(237, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Цена:";
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(241, 267);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(183, 23);
            this.tbPrice.TabIndex = 14;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(436, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Материал:";
            // 
            // tbMaterial
            // 
            // 
            // 
            // 
            this.tbMaterial.CustomButton.Image = null;
            this.tbMaterial.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbMaterial.CustomButton.Name = "";
            this.tbMaterial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMaterial.CustomButton.TabIndex = 1;
            this.tbMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMaterial.CustomButton.UseSelectable = true;
            this.tbMaterial.CustomButton.Visible = false;
            this.tbMaterial.Lines = new string[0];
            this.tbMaterial.Location = new System.Drawing.Point(440, 107);
            this.tbMaterial.MaxLength = 32767;
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.PasswordChar = '\0';
            this.tbMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMaterial.SelectedText = "";
            this.tbMaterial.SelectionLength = 0;
            this.tbMaterial.SelectionStart = 0;
            this.tbMaterial.ShortcutsEnabled = true;
            this.tbMaterial.Size = new System.Drawing.Size(183, 23);
            this.tbMaterial.TabIndex = 14;
            this.tbMaterial.UseSelectable = true;
            this.tbMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(237, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Проба:";
            // 
            // tbProb
            // 
            // 
            // 
            // 
            this.tbProb.CustomButton.Image = null;
            this.tbProb.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbProb.CustomButton.Name = "";
            this.tbProb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbProb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbProb.CustomButton.TabIndex = 1;
            this.tbProb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbProb.CustomButton.UseSelectable = true;
            this.tbProb.CustomButton.Visible = false;
            this.tbProb.Lines = new string[0];
            this.tbProb.Location = new System.Drawing.Point(241, 107);
            this.tbProb.MaxLength = 32767;
            this.tbProb.Name = "tbProb";
            this.tbProb.PasswordChar = '\0';
            this.tbProb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProb.SelectedText = "";
            this.tbProb.SelectionLength = 0;
            this.tbProb.SelectionStart = 0;
            this.tbProb.ShortcutsEnabled = true;
            this.tbProb.Size = new System.Drawing.Size(183, 23);
            this.tbProb.TabIndex = 14;
            this.tbProb.UseSelectable = true;
            this.tbProb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(237, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Наименование:";
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(239, 55);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(183, 23);
            this.tbName.TabIndex = 14;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorldOfGold_V2.Properties.Resources.icons8_unsplash_80;
            this.pictureBox1.Location = new System.Drawing.Point(59, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // UCAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UCAddNewProduct";
            this.Size = new System.Drawing.Size(710, 370);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnView;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox tbMaterial;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox tbProb;
    }
}
