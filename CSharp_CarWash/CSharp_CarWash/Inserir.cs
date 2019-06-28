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
    public partial class Inserir : Form
    {
        public string matricula, marca, modelo, ano, data, tipoLavagem;

        List<Carro> listaCarros = new List<Carro>();

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        public Inserir()
        {
            InitializeComponent();
            cb_tipoLavagem.Items.Add("Completa");
            cb_tipoLavagem.Items.Add("Metade");
            cb_tipoLavagem.Items.Add("Apenas aspirar");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            data = dtp_data.Text;
            matricula = txt_matricula.Text;
            marca = txt_marca.Text;
            modelo = txt_modelo.Text;
            ano = txt_ano.Text;
            tipoLavagem = cb_tipoLavagem.Text;
            Carro carro = new Carro(matricula, marca, modelo, int.Parse(ano), DateTime.Parse(data), tipoLavagem);
            listaCarros.Add(carro);
            try
            {
                string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WashyWashy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(conn);
                SqlCommand sqlCommand = new SqlCommand();
                string cmd = $"insert into WashyAgenda values ('{carro.matricula}','{carro.marca}','{carro.modelo}','{carro.ano}','{carro.getAno()}','{carro.tipoLavagem}')";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = cmd;
                sqlCommand.Connection = connection;

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na BD" +
                    ex);
            }
            MessageBox.Show(carro.ToString());
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
