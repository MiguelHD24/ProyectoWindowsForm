
using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SeguridadHack
{
    public partial class FormLogin : Form
    {
        public static int ID_Usuario;
        public static int ID_Rol;
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LimpiarControles()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtContraseña.UseSystemPasswordChar = true;
            if (txtUsuario.Text == ""|| txtContraseña.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingresar Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Ingresar Contraseña");
                return false;
            }
            if (txtUsuario.Text == "USUARIO")
            {
                MessageBox.Show("Ingresar Usuario");
                return false;
            }
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Ingresar Contraseña");
                return false;
            }
            return true;


        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (validarCampos()) 
                { 
                    Usuario user = new Usuario();
                    user.Login = txtUsuario.Text;
                    byte[] Password = BL_Usuario.Sha256(txtContraseña.Text);
                    ID_Usuario = BL_Usuario.ObtenerIDUsuarioSiCredencialesValidas(txtUsuario.Text);
                    if(ID_Usuario < 1)
                    {
                        MessageBox.Show("Usuario Incorrecto");
                        return;
                    }
                    if(BL_Usuario.ValidarCredenciales(txtUsuario.Text, Password))
                    {
                        user.Id_Usuario = ID_Usuario;
                        ID_Rol = BL_Usuario.ObtenerIDRol(user.Id_Usuario);
                        Menu_Principal frmMenu = new Menu_Principal();
                        frmMenu.ID_Usuario = user.Id_Usuario;
                        frmMenu.ID_Rol = ID_Rol;
                        frmMenu.Show();
                        this.Hide();

                    }
                    
                }
            }
            catch 
            { 

            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LabelFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Iniciar el Timer para actualizar la hora cada segundo
            Timer1.Interval = 1000; // Intervalo de actualización en milisegundos (1000 ms = 1 segundo)
            Timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabelHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }


        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }


        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true; // Ocultar caracteres de contraseña
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false; // Mostrar caracteres de contraseña
            }
        }
        private void MinimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cerra toda la aplicacion
            Application.Exit();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.Show();
            this.Hide();
        }
    }
}
