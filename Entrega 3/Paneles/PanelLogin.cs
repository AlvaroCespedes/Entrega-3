using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_3
{
    public partial class PanelLogin : Form
    {
        public PanelLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtUser.Text)//aca hay que poner que se verifique el inicio de secion
            {
                MessageBox.Show("Inicio con exito");
                this.Hide();
                PanelUsuario panelUser = new PanelUsuario();
                panelUser.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();


        }
    }
}
