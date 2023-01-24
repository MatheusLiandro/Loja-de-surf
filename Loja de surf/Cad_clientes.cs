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
    public partial class Cad_clientes : Form
    {
        public Cad_clientes()
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

        private void ShowAllButtons()
        {
            Action<Control.ControlCollection> func = null;
            func = (buttons) =>
            {
                foreach (Control button in buttons)
                {

                    if (button is Button)
                    {
                        button.Visible = true;
                    }
                    else
                        func(button.Controls);
                }
            };
            func(Controls);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowAllButtons();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            ShowAllButtons();
        }

        private void Cad_clientes_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu mainmenu = new Menu();
            this.Hide();
            mainmenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }
    }
}
