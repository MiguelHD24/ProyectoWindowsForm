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

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {

                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            //txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            //txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            //txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            //DDLRol.ValueMember = dgvUsuarios.CurrentRow.Cells["IdRol"].Value.ToString();
        }
    }
}
