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
    public partial class Menu_Principal : Form
    {
        public int ID_Usuario { get; set; }
        public int ID_Rol { get; set; }
        public int Enum { get; set; }
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cerra toda la aplicacion
            Application.Exit();
        }
        private void MinimizarFormulario()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            MinimizarFormulario();
        }

        private void BtnAdminUser_Click(object sender, EventArgs e)
        {
            AdminUsuarios frmAdmonUser = new AdminUsuarios();
            frmAdmonUser.ID_Usuario = ID_Usuario;
            frmAdmonUser.ID_Rol = ID_Rol;
            frmAdmonUser.Show();
            this.Hide();
        }

        private void BtnAdminPermiso_Click(object sender, EventArgs e)
        {
            AdminPermisos adminPermisos = new AdminPermisos();
            adminPermisos.ID_Usuario = ID_Usuario;
            adminPermisos.ID_Rol = ID_Rol;
            adminPermisos.Show();
            this.Hide();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.ID_Usuario = ID_Usuario;
            frmRegistro.ID_Rol = ID_Rol;
            frmRegistro.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
        
        private void ValidarPermisos()
        {
            //validar si el rol es administrador
            if (ID_Rol == 1)
            {
                //si es administrador se muestran todos los botones
                BtnAdminUser.Visible = true;
                BtnAdminPermiso.Visible = true;
                BtnRegistro.Visible = true;
                BtnAlmacen.Visible = true;
                BtnVentas.Visible = true;
                BtnProductos.Visible = true;
            }
            else if (ID_Rol == 2)
            {
                //si no es En Revision se ocultan los botones
                BtnAdminUser.Visible = false;
                BtnAdminPermiso.Visible = false;
                BtnRegistro.Visible = false;
                BtnAlmacen.Visible = false;
                BtnVentas.Visible = false;
                BtnProductos.Visible = false;
            }
            else if (ID_Rol == 3) 
            {
                 //si es Gerente 
                BtnAdminUser.Visible = true;
                BtnAdminPermiso.Visible = false;
                BtnRegistro.Visible = true;
                BtnAlmacen.Visible = true;
                BtnVentas.Visible = true;
                BtnProductos.Visible = true;

            }
            else if (ID_Rol == 4)
            {
                //si es Vendedor 
                BtnAdminUser.Visible = false;
                BtnAdminPermiso.Visible = false;
                BtnRegistro.Visible = false;
                BtnAlmacen.Visible = false;
                BtnVentas.Visible = true;
                BtnProductos.Visible = false;
            }
            else if (ID_Rol == 5)
            {
                //si es Almacenista 
                BtnAdminUser.Visible = false;
                BtnAdminPermiso.Visible = false;
                BtnRegistro.Visible = false;
                BtnAlmacen.Visible = true;
                BtnVentas.Visible = false;
                BtnProductos.Visible = true;
            }
            else
            {
                BtnAdminUser.Visible = false;
                BtnAdminPermiso.Visible = false;
                BtnRegistro.Visible = false;
                BtnAlmacen.Visible = false;
                BtnVentas.Visible = false;
                BtnProductos.Visible = false;

            }
        }
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            ValidarPermisos();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.ID_Usuario = ID_Usuario;
            frmVentas.ID_Rol = ID_Rol;
            frmVentas.Enum = 1; //1 es para ventas
            frmVentas.Show();
            this.Hide();

        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.ID_Usuario = ID_Usuario;
            frmVentas.ID_Rol = ID_Rol;
            frmVentas.Enum = 2; 
            frmVentas.Show();
            this.Hide();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.ID_Usuario = ID_Usuario;
            frmVentas.ID_Rol = ID_Rol;
            frmVentas.Enum = 3; 
            frmVentas.Show();
            this.Hide();
        }
    }
}
