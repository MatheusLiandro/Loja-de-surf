using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_surf
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_clientes cadCliente = new Cad_clientes();
            this.Hide();
            cadCliente.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_funcionarios cadFuncionario = new Cad_funcionarios();
            this.Hide();
            cadFuncionario.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login voltar = new Login();
            this.Hide();
            voltar.Show();
        }
    }
}
