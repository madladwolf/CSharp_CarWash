using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CarWash
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Inserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inserir inserir = new Inserir();
            inserir.Show();
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar listar = new Listar();
            listar.Show();
        }
    }
}
