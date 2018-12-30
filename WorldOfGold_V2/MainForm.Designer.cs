namespace WorldOfGold_V2
{
    partial class MainForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProduction = new MetroFramework.Controls.MetroButton();
            this.btnClients = new MetroFramework.Controls.MetroButton();
            this.btnSales = new MetroFramework.Controls.MetroButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new MetroFramework.Controls.MetroButton();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Location = new System.Drawing.Point(23, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(728, 382);
            this.panel5.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 380);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnProduction
            // 
            this.btnProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnProduction.BackColor = System.Drawing.Color.White;
            this.btnProduction.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProduction.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnProduction.Location = new System.Drawing.Point(144, 9);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(145, 36);
            this.btnProduction.TabIndex = 5;
            this.btnProduction.Text = "Продукция";
            this.btnProduction.UseCustomBackColor = true;
            this.btnProduction.UseSelectable = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnClients
            // 
            this.btnClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClients.BackColor = System.Drawing.Color.White;
            this.btnClients.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClients.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClients.Location = new System.Drawing.Point(295, 9);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(145, 36);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseCustomBackColor = true;
            this.btnClients.UseSelectable = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSales
            // 
            this.btnSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSales.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSales.Location = new System.Drawing.Point(446, 9);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(145, 36);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Продажи";
            this.btnSales.UseCustomBackColor = true;
            this.btnSales.UseSelectable = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnProduction);
            this.panel6.Controls.Add(this.btnSales);
            this.panel6.Controls.Add(this.btnClients);
            this.panel6.Location = new System.Drawing.Point(23, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(728, 50);
            this.panel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(336, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "МИР ЗОЛОТА";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddNewProduct.BackColor = System.Drawing.Color.White;
            this.btnAddNewProduct.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddNewProduct.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnAddNewProduct.Location = new System.Drawing.Point(23, 484);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(174, 36);
            this.btnAddNewProduct.TabIndex = 5;
            this.btnAddNewProduct.Text = "Добавить продукцию";
            this.btnAddNewProduct.UseCustomBackColor = true;
            this.btnAddNewProduct.UseSelectable = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 543);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton btnSales;
        private MetroFramework.Controls.MetroButton btnClients;
        private MetroFramework.Controls.MetroButton btnProduction;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnAddNewProduct;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}