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

namespace CSharp_CarWash
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            PreencheBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void PreencheBD()
        {
            try
            {
                string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WashyWashy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(conStr);

                string sql = $"select * from WashyAgenda";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conStr);
                DataSet dataSet = new DataSet();

                conn.Open();
                sqlDataAdapter.Fill(dataSet, "WashyAgenda");
                conn.Close();

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "WashyAgenda";
            }catch(Exception ex)
            {
                MessageBox.Show("Erro!" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
