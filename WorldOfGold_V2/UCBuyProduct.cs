using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WorldOfGold_V2
{
    public partial class UCBuyProduct : UserControl
    {
        public string  Name { get; set; }
        public Image Image { get; set; }
        public string  Prob { get; set; }
        public string ID { get; set; }
        public string Material { get; set; }
        public string  Price { get; set; }
        public string  Description { get; set; }
        public UCPriduct  UCPriduct { get; set; }
        public MainForm Form { get; set; }

        public UCBuyProduct(string name, Image image, string prob, string id, string material, string price, string description, UCPriduct uCPriduct, MainForm mainForm)
        {
            InitializeComponent();
            Name = name;
            Image = image;
            Prob = prob;
            ID = id;
            Material = material;
            Price = price;
            Description = description;
            UCPriduct = uCPriduct;
            Form = mainForm;

            lName.Text = Name;
            pictureBox1.Image = Image;
            lProb.Text = Prob;
            lID.Text = ID;
            lMaterial.Text = Material;
            lPrice.Text = Price;
            lDescription.Text = Description;
        }
        Image GetImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All files(*.*) | *.*";
            Image img = Properties.Resources.icons8_unsplash_80;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog.FileName);
            }
            return img;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetImage();
        }
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private void btnChange_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroButton btn = sender as MetroFramework.Controls.MetroButton;
            if (btn.Text == "Изменить")
            {
                btn.Text = "Применить";
                tbDescription.Visible = true;
                tbMaterial.Visible = true;
                tbName.Visible = true;
                tbPrice.Visible = true;
                tbProb.Visible = true;
                btnView.Visible = true;

                tbDescription.Text = lDescription.Text;
                tbMaterial.Text = lMaterial.Text;
                tbPrice.Text = lPrice.Text;
                tbName.Text = lName.Text;
                tbProb.Text = lProb.Text;

                return;
            }
            if (btn.Text == "Применить")
            {
                btn.Text = "Изменить";
                tbDescription.Visible = false;
                tbMaterial.Visible = false;
                tbName.Visible = false;
                tbPrice.Visible = false;
                tbProb.Visible = false;
                btnView.Visible = false;


                OleDbConnection connection = new OleDbConnection(connstring);
                try
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand("UPDATE Продукция SET Наименование = ?, Изображение = ?, Проба = ?, Материал = ?, Описание = ?, Цена = ? WHERE ID = ?", connection);
                    OleDbParameter parameter = new OleDbParameter("Наименование", OleDbType.VarChar);
                    parameter.Value = tbName.Text;
                    command.Parameters.Add(parameter);

                    MemoryStream memoryStream = new MemoryStream();
                    System.Drawing.Imaging.ImageFormat format = pictureBox1.Image.RawFormat;
                    pictureBox1.Image.Save(memoryStream, format);
                    OleDbParameter parameter1 = new OleDbParameter("Изображение", OleDbType.Binary);
                    parameter1.Value = memoryStream.ToArray();
                    command.Parameters.Add(parameter1);

                    OleDbParameter parameter3 = new OleDbParameter("Проба", OleDbType.VarChar);
                    parameter3.Value = tbProb.Text;
                    command.Parameters.Add(parameter3);

                    OleDbParameter parameter4 = new OleDbParameter("Материал", OleDbType.VarChar);
                    parameter4.Value = tbMaterial.Text;
                    command.Parameters.Add(parameter4);

                    OleDbParameter parameter5 = new OleDbParameter("Описание", OleDbType.VarChar);
                    parameter5.Value = tbDescription.Text;
                    command.Parameters.Add(parameter5);

                    OleDbParameter parameter6 = new OleDbParameter("Цена", OleDbType.VarChar);
                    parameter6.Value = tbPrice.Text;
                    command.Parameters.Add(parameter6);

                    OleDbParameter parameter7 = new OleDbParameter("ID", OleDbType.Integer);
                    parameter7.Value = Convert.ToInt32(lID.Text);
                    command.Parameters.Add(parameter7);

                    command.ExecuteNonQuery();


                    MetroFramework.MetroMessageBox.Show(this, "Запись успешно изменена", "Изменение продукции");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                lDescription.Text = tbDescription.Text;
                lMaterial.Text = tbMaterial.Text;
                lPrice.Text = tbPrice.Text;
                lName.Text = tbName.Text;
                lProb.Text = tbProb.Text;

                return;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("DELETE FROM Продукция WHERE ID = ?", connection);

                OleDbParameter parameter = new OleDbParameter("ID", OleDbType.Integer);
                parameter.Value = Convert.ToInt32(lID.Text);
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();


                MetroFramework.MetroMessageBox.Show(this, "Запись успешно изменена", "Изменение продукции");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            UCPriduct.pictureBox1_Click(sender, e);
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            Form.flowLayoutPanel1.Controls.Clear();
            Form.flowLayoutPanel1.Controls.Add(new UCBuy(ID, lName.Text, lPrice.Text, Image));
        }
    }
}
