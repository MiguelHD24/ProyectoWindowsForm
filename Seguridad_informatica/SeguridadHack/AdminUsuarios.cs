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
        private void ValidarUpdate()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar Nombre");
                return;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Ingresar Correo");
                return;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingresar Nombre de Usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingresar Contraseña");
                return;
            } 
            if (DDLRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar Rol");
                return;
            }
            
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
        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            cargargrid();
            cargarCombobox();
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
