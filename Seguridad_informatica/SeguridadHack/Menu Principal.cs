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
            if (ID_Rol == 1)
            {
                AdminUsuarios adminUsuarios = new AdminUsuarios();
                adminUsuarios.ID_Usuario = ID_Usuario;
                adminUsuarios.ID_Rol = ID_Rol;
                adminUsuarios.Show();
                this.Hide();
            }
            else if (ID_Rol == 2)
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección");
            }
            else if (ID_Rol >= 3)
            {
                AdminUsuarios frmAdmonUser = new AdminUsuarios();
                frmAdmonUser.ID_Usuario = ID_Usuario;
                frmAdmonUser.ID_Rol = ID_Rol;
                frmAdmonUser.Show();
                this.Hide();
            }
            
        }

        private void BtnAdminPermiso_Click(object sender, EventArgs e)
        {
            if (ID_Rol == 1)
            {
                AdminPermisos adminPermisos = new AdminPermisos();
                adminPermisos.ID_Usuario = ID_Usuario;
                adminPermisos.ID_Rol = ID_Rol;
                adminPermisos.Show();
                this.Hide();
            }
            else if (ID_Rol == 2)
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección");
            }
            else if (ID_Rol >= 3)
            {
                AdminPermisos adminPermisos = new AdminPermisos();
                adminPermisos.ID_Usuario = ID_Usuario;
                adminPermisos.ID_Rol = ID_Rol;
                adminPermisos.Show();
                this.Hide();
            }
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
        
        
        private void ValidarSesion()
        {
            Usuario user = new Usuario();
            user.Id_Usuario = ID_Usuario;
            ID_Rol = BL_Usuario.ObtenerIDRol(user.Id_Usuario);
        }
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            ValidarSesion();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (ID_Rol == 1)
            {
                Ventas frmVentas = new Ventas();
                frmVentas.ID_Usuario = ID_Usuario;
                frmVentas.ID_Rol = ID_Rol;
                frmVentas.Enum = 1; //1 es para ventas
                frmVentas.Show();
                this.Hide();
            }
            else if (ID_Rol == 2)
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección");
            }
            else if (ID_Rol >= 3)
            {
                Ventas frmVentas = new Ventas();
                frmVentas.ID_Usuario = ID_Usuario;
                frmVentas.ID_Rol = ID_Rol;
                frmVentas.Enum = 1; 
                frmVentas.Show();
                this.Hide();
            }

        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            if (ID_Rol == 1)
            {
                Ventas frmVentas = new Ventas();
                frmVentas.ID_Usuario = ID_Usuario;
                frmVentas.ID_Rol = ID_Rol;
                frmVentas.Enum = 2; //2 es para almacen
                frmVentas.Show();
                this.Hide();
            }
            else if (ID_Rol == 2)
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección");
            }
            else if (ID_Rol >= 3)
            {
                Ventas frmVentas = new Ventas();
                frmVentas.ID_Usuario = ID_Usuario;
                frmVentas.ID_Rol = ID_Rol;
                frmVentas.Enum = 2; 
                frmVentas.Show();
                this.Hide();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (ID_Rol == 1)
            {
                Ventas frmVentas = new Ventas();
                frmVentas.ID_Usuario = ID_Usuario;
                frmVentas.ID_Rol = ID_Rol;
                frmVentas.Enum = 3; //3 es para productos
                frmVentas.Show();
                this.Hide();
            }
            else if (ID_Rol == 2)
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección");
            }
            else if (ID_Rol >= 3)
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
}
