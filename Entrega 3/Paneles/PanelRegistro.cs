using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_3.Paneles
{
    public partial class PanelRegistro : Form
    {
        public PanelRegistro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)

            
        { 
           
            panel1.Visible = true;      //aca agregar verificar si no se equivoca en la confirmacion de contraseña, que el nombre de usuario no exista ....
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnContinuar2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Plan basico seleccionado, no se realizaran cargos en su tarjeta");

            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("Para continuar complete su forma de pago");
                panel2.Visible = true;
            }
            else if (radioButton5.Checked==true)
            {
                MessageBox.Show("Para continuar complete su forma de pago");
                
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("ingrese una opccion para poder continuar");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelDatosTarjeta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverTarjeta_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
