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
    public partial class UCAddNewProduct : UserControl
    {
        public UCAddNewProduct()
        {
            InitializeComponent();
            GetCategoriesName();
        }
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";

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

        void GetCategoriesName()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT Наименование From Категории_продукции", connection);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(reader["Наименование"].ToString());
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

        int GetCategory()
        {
            int ID = 1;

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID From Категории_продукции WHERE Наименование = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Наименование", OleDbType.VarChar);
                parameter.Value = cmbCategory.Text;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Продукция(Наименование, Изображение, Категория, Проба, Материал, Описание, Цена) VALUES(?,?,?,?,?,?,?)", connection);
                OleDbParameter parameter = new OleDbParameter("Наименование", OleDbType.VarChar);
                parameter.Value = tbName.Text;
                command.Parameters.Add(parameter);

                MemoryStream memoryStream = new MemoryStream();
                System.Drawing.Imaging.ImageFormat format = pictureBox1.Image.RawFormat;
                pictureBox1.Image.Save(memoryStream, format);
                OleDbParameter parameter1 = new OleDbParameter("Изображение", OleDbType.Binary);
                parameter1.Value = memoryStream.ToArray();
                command.Parameters.Add(parameter1);

                OleDbParameter parameter2 = new OleDbParameter("Категория", OleDbType.Integer);
                parameter2.Value = GetCategory();
                command.Parameters.Add(parameter2);

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

                command.ExecuteReader();


                MetroFramework.MetroMessageBox.Show(this, "Запись успешно добавлена", "Доавление новой продукции");
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
