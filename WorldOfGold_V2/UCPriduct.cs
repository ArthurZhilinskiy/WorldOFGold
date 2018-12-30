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

namespace WorldOfGold_V2
{
    public partial class UCPriduct : UserControl
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public MainForm Form { get; set; }
        public string Price { get; set; }
        public UCPriduct(string name, Image image, string price, MainForm form)
        {
            InitializeComponent();
            Name = name;
            Image = image;
            Price = price;
            Form = form;

            pictureBox1.Image = Image;
            lName.Text = Name;
            lPrice.Text = Price;
        }

        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";

        string GetCategory(string name)
        {
            string ID = "";

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID From Категории_продукции WHERE Наименование = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Наименование", OleDbType.VarChar);
                parameter.Value = name;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ID = reader["ID"].ToString();
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
            return ID;

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Form.flowLayoutPanel1.Controls.Clear();

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * From Продукция WHERE Наименование = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Наименование", OleDbType.VarChar);
                parameter.Value = Name;
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Form.flowLayoutPanel1.Controls.Add(new UCBuyProduct(Name, Image, reader["Проба"].ToString(), reader["ID"].ToString(), reader["Материал"].ToString(), reader["Цена"].ToString() ,reader["Описание"].ToString(), this, Form));
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
    }
}
