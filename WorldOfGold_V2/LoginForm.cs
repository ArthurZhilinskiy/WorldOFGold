using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfGold_V2
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("Select * From Пользователи WHERE Логин = ? AND Пароль = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbLogin.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Пароль", OleDbType.VarChar);
                parameter1.Value = tbPassword.Text;
                command.Parameters.Add(parameter1);

                OleDbDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    tbLogin.WithError = true;
                    tbPassword.WithError = true;
                }
                while (reader.Read())
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM Пользователи WHERE Логин = ?", connection);
                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbRLogin.Text;
                command.Parameters.Add(parameter);

                
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    throw new Exception("Логин занят другим Пользователем! Введеите другой логин");
                }
                reader.Close();
                connection.Close();
                regNewUser();
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

        void regNewUser()
        {
            OleDbConnection connection = new OleDbConnection(connstring);

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Пользователи(Логин, Пароль) VALUES(?, ?)", connection);

                OleDbParameter parameter = new OleDbParameter("Логин", OleDbType.VarChar);
                parameter.Value = tbRLogin.Text;
                command.Parameters.Add(parameter);

                OleDbParameter parameter1 = new OleDbParameter("Пароль", OleDbType.VarChar);
                parameter1.Value = tbRPassword.Text;
                command.Parameters.Add(parameter1);

                command.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Пользователь успешно добавлен!", "Регистрация нового пользователя");
                tbRLogin.Clear();
                tbRPassword.Clear();
                connection.Close();
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
