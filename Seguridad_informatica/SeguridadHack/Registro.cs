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

namespace SeguridadHack
{
    public partial class Registro : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Rol { get; set; }
        public Registro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }
        private void InicializarVariable()
        {
            if (ID_Usuario < 0) 
            {
                 ID_Usuario = 1;
            }
        }
        private bool ValidarInsertar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar Nombre");
                return false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingresar Correo");
                return false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingresar Nombre de Usuario");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingresar Contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmar.Text))
            {
                MessageBox.Show("Confirmar Contraseña");
                return false;
            }
            if (!(txtPassword.Text == txtConfirmar.Text))
            {
                MessageBox.Show("La contraseña no coincide");
                return false;
            }
            return true;
        }
        private void Guardar()
        {
            try
            {
                Usuario User = new Usuario();
                if (ValidarInsertar())
                {
                    if (ID_Rol < 1)
                    { 
                        ID_Rol = 2; 
                    }
                    User.Nombre = txtNombre.Text;
                    User.Correo = txtCorreo.Text;
                    User.Login = txtUsuario.Text;
                    User.Password = BL_Usuario.Sha256(txtPassword.Text);
                    User.IdRol = 2;
                    User.Bloqueado = false;
                    User.Contador = 0;
                    User.UsuarioRegistro = ID_Usuario;
                    User.CambiarPassword = false;
                    if (BL_Usuario.Insert(User).Id_Usuario > 0)
                    {
                        MessageBox.Show("Se agrego correctamente");
                        return;
                    }
                    MessageBox.Show("No se agrego correctamente");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Guardar();
            if (ID_Rol ==2)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
            else
            {
                Menu_Principal frmMenu = new Menu_Principal();
                frmMenu.ID_Usuario = ID_Usuario;
                frmMenu.ID_Rol = ID_Rol;
                frmMenu.Show();
                this.Hide();
            }
            
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO";
                txtCorreo.ForeColor = Color.DimGray;
            }
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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.LightGray;
                txtConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmar.ForeColor = Color.DimGray;
                txtConfirmar.UseSystemPasswordChar = false;
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
            Application.Exit();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            InicializarVariable();
        }
    }
}
