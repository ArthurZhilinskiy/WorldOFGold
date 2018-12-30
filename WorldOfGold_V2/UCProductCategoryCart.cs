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
    public partial class UCProductCategoryCart : UserControl
    {
        public string  Name { get; set; }
        public Image Image { get; set; }
        public MainForm Form { get; set; }
        public UCProductCategoryCart(string name, Image image, MainForm form)
        {
            InitializeComponent();
            Name = name;
            Image = image;
            Form = form;

            pictureBox1.Image = Image;
            lName.Text = Name;
        }

        int GetCategory(string name)
        {
            int ID = 1;

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
                        ID = Convert.ToInt32(reader["ID"].ToString());
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

        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Продукция WHERE Категория = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Категория", OleDbType.Integer);
                parameter.Value = GetCategory(Name);
                command.Parameters.Add(parameter);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Form.flowLayoutPanel1.Controls.Clear();
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

                        Form.flowLayoutPanel1.Controls.Add(new UCPriduct(reader["Наименование"].ToString(), image, reader["Цена"].ToString(), Form));
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
