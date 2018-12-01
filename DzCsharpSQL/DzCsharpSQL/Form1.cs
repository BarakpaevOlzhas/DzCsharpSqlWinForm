using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DzCsharpSQL
{
    public partial class Form1 : Form
    {
        private string baseName = "MyBD";
        private string server = "localhost";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlConnectionBuilder = new SqlConnectionStringBuilder();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnectionBuilder.Password = textBoxPassword.Text;
                sqlConnectionBuilder.UserID = textBoxUserId.Text;
                sqlConnectionBuilder.DataSource = server;
                sqlConnectionBuilder.InitialCatalog = baseName;

                sqlConnection.ConnectionString = sqlConnectionBuilder.ConnectionString;

                try
                {
                sqlConnection.Open();

                    MessageBox.Show("Открыт");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
