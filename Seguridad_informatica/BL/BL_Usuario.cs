using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using DAL;
namespace BL
{
	 public static class BL_Usuario
	{
		 public static Usuario Insert (Usuario Entidad)
		{
			 return DAL_Usuario.Insert(Entidad);
		}
		 public static bool Update (Usuario Entidad)
		{
			 return DAL_Usuario.Update(Entidad);
		}
		 public static bool Anular (Usuario Entidad)
		{
			 return DAL_Usuario.Anular(Entidad);
		}
		 public static bool Existe (Usuario Entidad)
		{
			 return DAL_Usuario.Existe(Entidad);
		}
        public static int ObtenerIDUsuarioSiCredencialesValidas(string UserName)
		{
			return DAL_Usuario.ObtenerIDUsuarioSiCredencialesValidas(UserName);
		}

         public static Usuario Registro (Usuario Entidad)
		{
			 return DAL_Usuario.Registro(Entidad);
		}
		 public static List<Usuario> Lista (bool Activo = true)
		{
			 return DAL_Usuario.Lista(Activo);
		}
        public static byte[] Sha256(string input)
		{
			return DAL_Usuario.Sha256(input);
		}

        public static bool ValidarCredenciales(string UserName, byte[] Password)
		{
			return DAL_Usuario.ValidarCredenciales(UserName, Password);
		}

        public static int ObtenerIDRol(int Id_Usuario)
		{
			return DAL_Usuario.ObtenerIDRol(Id_Usuario);
		}
        public static List<Usuario> ListaUsuario()
		{
			return DAL_Usuario.ListaUsuario();
		}
    }
}
