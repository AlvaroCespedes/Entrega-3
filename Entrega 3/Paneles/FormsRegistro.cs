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
    public partial class FormsRegistro : Form
    {
        public FormsRegistro()
        {
            InitializeComponent();
        }


        Clases.DataBase database = new Clases.DataBase();

        Clases.MailSender mailSender = new Clases.MailSender();

        Clases.User user = new Clases.User();
        DateTime hora = new DateTime();

        Clases.ProfilelUser perfi2 = new Clases.ProfilelUser();
        double intervalo = 1000;

        //SongClass cancion = new SongClass(); Ya instancie este objeto.
        //Video video = new Video(); // YA instancie
        List<Clases.User> usuarios = new List<Clases.User>();

        Clases.ProfileManagment profileManagment = new Clases.ProfileManagment();
        IDictionary<Clases.User, List<Clases.Profile>> diccUserProfiles = new Dictionary<Clases.User, List<Clases.Profile>>();

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
            if (txtContraseñaR.Text != txtConfirmacionContraseñaR.Text)
            {
                MessageBox.Show("sus contraseñas no coinciden");
            }
            else if (txtANombreUsuarioR.Text == "" || txtConfirmacionContraseñaR.Text == "" ||txtContraseñaR.Text=="" ||txtEdadR.Text=="" ||txtEmailR.Text=="" )
                
                {
                MessageBox.Show("RELLENE TODOS LOS DATOS");
            }
            else if (txtGeneroR.Text=="" ||txtEdadR.Text=="" ||txtNombreR.Text==" " ||txtNumerocelularR.Text=="" || TxtApellidoR.Text=="" ||txtOcupacionR.Text=="" )

            {
                MessageBox.Show("RELLENE TODOS LOS DATOS");
            }
            else if (txtNacionalidadR.Text=="")
            {
                MessageBox.Show("RELLENE TODOS LOS DATOS");
            }
            else 
            { 
            panel1.Visible = true;      //aca agregar verificar si no se equivoca en la confirmacion de contraseña, que el nombre de usuario no exista ....
            }
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
                
                
                string usr = txtANombreUsuarioR.Text;
;                string number = txtNumerocelularR.Text;
                string psswd =txtContraseñaR.Text;
                string name = txtNombreR.Text;
                string Age = txtEdadR.Text;
                int edad = Int32.Parse(Age);//convierto la edad que esta en texto a number
                string lastname = TxtApellidoR.Text;
                string gender = txtGeneroR.Text;
                string nationality = txtNacionalidadR.Text;
                string ocuppation = txtOcupacionR.Text;
                string email = txtEmailR.Text;
                string planSeleccionado = "premiun";
                string infopago = txtNumeroTarjeta.Text;
                MessageBox.Show("Para continuar complete su forma de pago");
                panel2.Visible = true;
                DateTime dateRegister = new DateTime();

                //Agregar el usario a una lista de usuarios
                Clases.User usuario = new Clases.User(usr, number, psswd, name, edad, lastname, gender, nationality, ocuppation, email, infopago, planSeleccionado, dateRegister);
                usuarios.Add(usuario);
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

        private void btnContinuarTarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOlVERAS A LA PANTALLA DE INICIO");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
