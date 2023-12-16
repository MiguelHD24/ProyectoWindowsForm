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
    public partial class AdminUsuarios : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Rol { get; set; }
        public AdminUsuarios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ValidarSesion()
        {
            Usuario user = new Usuario();
            user.Id_Usuario = ID_Usuario;
            ID_Rol = BL_Usuario.ObtenerIDRol(user.Id_Usuario);
        }
        private void cargargrid()
        {
            try
            {
                
                dgvUsuarios.DataSource = BL_Usuario.Lista();
                dgvUsuarios.Columns["Password"].Visible = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ValidarUpdate()
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.Id_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString());
                usuario.Nombre = txtNombre.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Login = txtUsuario.Text;
                usuario.Password = BL_Usuario.Sha256(txtPassword.Text);
                usuario.CambiarPassword = true;
                usuario.UsuarioActualiza = ID_Usuario;
                usuario.IdRol = Convert.ToInt32(DDLRol.SelectedValue);
                BL_Usuario.Update(usuario);
                MessageBox.Show("Usuario Actualizado correctamente");
                cargargrid();
                LimpiarControles();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidarCampos()
        {
            if (txtNombre.Text == "NOMBRE")
            {
                MessageBox.Show("Ingresar Nombre");
                return false;
            }
            if (txtCorreo.Text == "CORREO")
            {
                MessageBox.Show("Ingresar Correo");
                return false;
            }
            if (txtUsuario.Text == "USUARIO")
            {
                MessageBox.Show("Ingresar Nombre de Usuario");
                return false;
            }
            if (txtPassword.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Ingresar Contraseña");
                return false;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                return false;
            }
            if (!txtPassword.Text.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe tener al menos una mayuscula");
                return false;
            }
            if (!txtPassword.Text.Any(char.IsLower))
            {
                MessageBox.Show("La contraseña debe tener al menos una minuscula");
                return false;
            }
            if (!txtPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos un numero");
                return false;
            }
            if (!txtPassword.Text.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("La contraseña debe tener al menos un caracter especial");
                return false;
            }
            if (DDLRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar Rol");
                return false;
            }

            return true;
            
            
            
        }
        private void ActualizarROL()
        { 
            Usuario usuario = new Usuario();
            usuario.Id_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString());
            usuario.IdRol = Convert.ToInt32(DDLRol.SelectedValue);
            usuario.UsuarioActualiza = ID_Usuario;
            BL_Usuario.ActualizarRol(usuario.Id_Usuario, usuario.IdRol,ID_Usuario);
            MessageBox.Show("Rol Actualizado correctamente");
            cargargrid();
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;

            DDLRol.SelectedIndex = -1;
        }
        private void ValidarPermisos()
        {
            
            if (ID_Rol == 1)
            {
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                BtnRol.Visible = true;


            }
            else if (ID_Rol == 2)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                BtnRol.Visible = false;

                
            }
        }
        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            cargargrid();
            cargarCombobox();
            ValidarSesion();
            ValidarPermisos();
            txtPassword.UseSystemPasswordChar = true;
            DDLRol.SelectedIndex = -1;
        }
        private void cargarCombobox()
        {
            List<Roles> listaRoles = BL_Roles.Lista();

            DDLRol.DisplayMember = "Rol"; // Mostrará el nombre del rol
            DDLRol.ValueMember = "IdRol"; // El valor asociado será el ID del rol
            DDLRol.DataSource = listaRoles;

        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ValidarUpdate();
            ValidarPermisos();
            DDLRol.SelectedIndex = -1;
        }
        
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvUsuarios_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var IdEncontrado = dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
            this.txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            this.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            Roles roles = new Roles();
            roles.IdRol = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdRol"].Value.ToString());
            if (BL_Roles.ObtenerRol(roles.IdRol) != null)
            {
                this.DDLRol.Text = BL_Roles.ObtenerRol(roles.IdRol);
            }
            else
            {
                this.DDLRol.Text = "En Revision";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString());
            usuario.UsuarioActualiza = ID_Usuario;
            if (!(BL_Usuario.Anular(usuario)))
            {
                MessageBox.Show("No se pudo eliminar el usuario");
                cargargrid();
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Usuario Eliminado correctamente");
                cargargrid();
                LimpiarControles();
                
            }
        }

        private void BtnRol_Click(object sender, EventArgs e)
        {
            ActualizarROL();
            ValidarPermisos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            frmMenu.ID_Usuario = ID_Usuario;
            frmMenu.ID_Rol = ID_Rol;
            frmMenu.Show();
            this.Hide();
        }
    }
}
