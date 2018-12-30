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
    public partial class UCClient : UserControl
    {
        public UCClient()
        {
            InitializeComponent();
            LoadData();
        }

        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        void LoadData()
        {
            OleDbConnection connection = new OleDbConnection(connstring);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Клиенты", connection);
                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader["ID"].ToString();
                    data[data.Count - 1][1] = reader["Фамилия"].ToString();
                    data[data.Count - 1][2] = reader["Имя"].ToString();
                    data[data.Count - 1][3] = reader["Отчество"].ToString();
                    data[data.Count - 1][4] = reader["Телефон"].ToString();
                    data[data.Count - 1][5] = reader["E_mail"].ToString();
                }

                foreach (string[] s in data)
                    metroGrid1.Rows.Add(s);
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string fam = tbSearch.Text;
            if (fam != "")
            {
                for (int i = 0; i < metroGrid1.RowCount; i++)
                {
                    metroGrid1.Rows[i].Selected = false;
                    for (int j = 0; j < metroGrid1.ColumnCount; j++)
                        if (metroGrid1.Rows[i].Cells[j].Value != null)
                            if (metroGrid1.Rows[i].Cells[j].Value.ToString().Contains(fam))
                            {
                                metroGrid1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else
            {
                for (int i = 0; i < metroGrid1.RowCount; i++)
                {
                    metroGrid1.Rows[i].Selected = false;

                }
            }
          
        }
    }
}
