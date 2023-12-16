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
    public partial class AdminPermisos : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Rol { get; set; }
        public AdminPermisos()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            try
            {
                dgvRolPermiso.DataSource = BL_RolPermisos.MostrarRolPermiso();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGridPermiso()
        {
            try
            {
                DGVPermisosNew.DataSource = BL_Permisos.Lista();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CargarComboboxROL()
        {
            List<Roles> listaRoles = BL_Roles.Lista();

            DDLRol.DisplayMember = "Rol"; // Mostrará el nombre del rol
            DDLRol.ValueMember = "IdRol"; // El valor asociado será el ID del rol
            DDLRol.DataSource = listaRoles;

        }
        private void CargarComboboxPermiso()
        {
            List<Permisos> listaPermisos = BL_Permisos.Lista();

            DDLPermiso.DisplayMember = "Permiso"; // Mostrará el nombre del permiso
            DDLPermiso.ValueMember = "IdPermiso"; // El valor asociado será el ID del permiso
            DDLPermiso.DataSource = listaPermisos;

        }
        private void dgvRolPermiso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRolPermiso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ValidarSesion()
        {
            Usuario user = new Usuario();
            user.Id_Usuario = ID_Usuario;
            ID_Rol = BL_Usuario.ObtenerIDRol(user.Id_Usuario);
        }
        
        private void AdminPermisos_Load(object sender, EventArgs e)
        {
            
            CargarGrid();
            CargarGridPermiso();
            CargarComboboxPermiso();
            CargarComboboxROL();
            ValidarSesion();

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            RolPermisos rolPermisos = new RolPermisos();
            rolPermisos.UsuarioActualiza = ID_Usuario;
            rolPermisos.IdRolPermiso = Convert.ToInt32(dgvRolPermiso.CurrentRow.Cells["IdRolPermiso"].Value.ToString());
            if (BL_RolPermisos.Anular(rolPermisos))
            {
                  MessageBox.Show("Se anulo el permiso");
                  CargarGrid();
            }
            else
            {
                MessageBox.Show("No se pudo anular el permiso");
                CargarGrid();
            }
            

        }
        private void ValidarInsertar()
        {
            RolPermisos rolPermisos = new RolPermisos();
            rolPermisos.IdRol = Convert.ToInt32(DDLRol.SelectedValue);
            rolPermisos.IdPermiso = Convert.ToInt32(DDLPermiso.SelectedValue);
            rolPermisos.UsuarioRegistro = ID_Usuario;
            if (BL_RolPermisos.Insert(rolPermisos) != null)
            {
                MessageBox.Show("Se inserto el permiso");
                CargarGrid();
            }
            else
            {
                MessageBox.Show("No se pudo insertar el permiso");
                CargarGrid();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ValidarInsertar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Principal menuPrincipal = new Menu_Principal();
            menuPrincipal.ID_Usuario = ID_Usuario;
            menuPrincipal.ID_Rol = ID_Rol;
            menuPrincipal.Show();
            this.Hide();

        }
        private void insertarPermiso()
        {
            if(txtNuevoPermiso.Text != "")
            {
                Permisos permisos = new Permisos();
                permisos.Permiso = txtNuevoPermiso.Text;
                permisos.UsuarioRegistro = ID_Usuario;
                if (BL_Permisos.Insert(permisos) != null)
                {
                    MessageBox.Show("Se inserto el permiso");
                    CargarGridPermiso();
                    CargarComboboxPermiso();
                    txtNuevoPermiso.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el permiso");
                    CargarGridPermiso();
                    CargarComboboxPermiso();
                    txtNuevoPermiso.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese nuevo permiso");
                CargarGridPermiso();
                CargarComboboxPermiso();
                txtNuevoPermiso.Text = "";
            }
        }

        private void AnularPermiso()
        {
            Permisos permisos = new Permisos();
            permisos.UsuarioActualiza = ID_Usuario;
            permisos.IdPermiso = Convert.ToInt32(dgvRolPermiso.CurrentRow.Cells["IdPermiso"].Value.ToString());
            if (BL_Permisos.Anular(permisos))
            {
                MessageBox.Show("Se anulo el permiso");
                CargarGridPermiso();
                CargarComboboxPermiso();
            }
            else
            {
                MessageBox.Show("No se pudo anular el permiso");
                CargarGridPermiso();
                CargarComboboxPermiso();
            }
        }

        private void BtnPermisoInsert_Click(object sender, EventArgs e)
        {
            insertarPermiso();
        }

        private void BtnPermisoAnular_Click(object sender, EventArgs e)
        {
            AnularPermiso();
        }
    }
}
