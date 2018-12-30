using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfGold_V2
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";


        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new UCAddNewProduct());
        }

        void getCategories()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Категории_продукции", connection);

                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Image image;
                        if (!reader.IsDBNull(reader.GetOrdinal("Изображение")))
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            memoryStream.Write((byte[])reader["Изображение"], 0, ((byte[])reader["Изображение"]).Length);
                            image = Image.FromStream(memoryStream);
                        }
                        else
                        {
                            image = Properties.Resources.icons8_unsplash_80;
                        }

                        UCProductCategoryCart Cart = new UCProductCategoryCart(reader["Наименование"].ToString(), image, this);
                        flowLayoutPanel1.Controls.Add(Cart);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            getCategories();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new UCClient());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new UCSales());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
