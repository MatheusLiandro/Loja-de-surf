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
    public partial class Cad_funcionarios : Form
    {
        public Cad_funcionarios()
        {
            InitializeComponent();
        }

        private void ClearAllBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {

                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }


        private void Cad_funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu voltar = new Menu();
            this.Hide();
            voltar.Show();
        }
    }
}
