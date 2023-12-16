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
    public partial class Ventas : Form
    {
        public int Enum { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Rol { get; set; }
        public Ventas()
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
        private void ActualizarBoton()
        {
            if (Enum == 1)
            {
                BtnRegresar.Text = "Ventas";
            }
            else if (Enum == 2)
            {
                BtnRegresar.Text = "Almacen";
            }
            else if (Enum == 3)
            { 
                BtnRegresar.Text = "Administracion de Productos";
            }
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            ActualizarBoton();
            ValidarSesion();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            frmMenu.ID_Usuario = ID_Usuario;
            frmMenu.ID_Rol = ID_Rol;
            frmMenu.Show();
            this.Hide();
        }
    }
}
