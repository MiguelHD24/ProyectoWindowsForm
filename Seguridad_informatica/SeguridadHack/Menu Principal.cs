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

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
