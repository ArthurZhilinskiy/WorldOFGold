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
    public partial class UCBuy : UserControl
    {
        public string ID_Продукции { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public Image Image { get; set; }
        public UCBuy(string ID_Продукции, string name, string price, Image image)
        {
            InitializeComponent();
            this.ID_Продукции = ID_Продукции;
            Name = name;
            Price = price;
            Image = image;

            lName.Text = Name;
            lPrice.Text = Price;
            pictureBox1.Image = Image;
        }
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private void btnSale_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Клиенты(Фамилия, Имя, Отчество, Телефон, E_mail) VALUES(?,?,?,?,?)", connection);
                OleDbParameter parameter = new OleDbParameter("Фамилия", OleDbType.VarChar);
                parameter.Value = tbFa.Text;
                command.Parameters.Add(parameter);
                

                OleDbParameter parameter2 = new OleDbParameter("Имя", OleDbType.VarChar);
                parameter2.Value = tbNa.Text;
                command.Parameters.Add(parameter2);

                OleDbParameter parameter3 = new OleDbParameter("Отчество", OleDbType.VarChar);
                parameter3.Value = tbOt.Text;
                command.Parameters.Add(parameter3);


                OleDbParameter parameter4 = new OleDbParameter("Телефон", OleDbType.VarChar);
                parameter4.Value = tbPh.Text;
                command.Parameters.Add(parameter4);

                OleDbParameter parameter5 = new OleDbParameter("E_mail", OleDbType.VarChar);
                parameter5.Value = tbEm.Text;
                command.Parameters.Add(parameter5);
                
                command.ExecuteNonQuery();
                connection.Close();
                InsertSales();


                MetroFramework.MetroMessageBox.Show(this, "Успешно продана!", "Продажа продукции");

                this.Dispose();

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

        int getClientID()
        {
            int ID = 1;

            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ID FROM Клиенты WHERE Фамилия = ? AND Имя = ? AND Отчество = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Фамилия", OleDbType.VarChar);
                parameter.Value = tbFa.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Имя", OleDbType.VarChar);
                parameter1.Value = tbNa.Text;
                command.Parameters.Add(parameter1);

                OleDbParameter parameter2 = new OleDbParameter("Отчество", OleDbType.VarChar);
                parameter2.Value = tbOt.Text;
                command.Parameters.Add(parameter2);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ID = Convert.ToInt32(reader[0].ToString());
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

        void InsertSales()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Продажи(ID_Клиента, ID_Продукции, [Дата продажи]) VALUES(?,?,?)", connection);

                
                OleDbParameter parameter = new OleDbParameter("ID_Клиента", OleDbType.Integer);
                parameter.Value = getClientID();
                command.Parameters.Add(parameter);


                OleDbParameter parameter2 = new OleDbParameter("ID_Продукции", OleDbType.Integer);
                parameter2.Value = Convert.ToInt32(ID_Продукции);
                command.Parameters.Add(parameter2);

                OleDbParameter parameter3 = new OleDbParameter("Дата продажи", OleDbType.VarChar);
                parameter3.Value = DateTime.Now.ToShortDateString();
                command.Parameters.Add(parameter3);

                command.ExecuteNonQuery();


                
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
