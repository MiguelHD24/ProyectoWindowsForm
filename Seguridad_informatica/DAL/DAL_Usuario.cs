using System;
using System.Collections.Generic;
using System.Linq;
using EL;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;

namespace DAL
{
	 public static class DAL_Usuario
	{
		 public static Usuario Insert (Usuario Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Usuario.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Usuario Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Usuario.Find(Entidad.Id_Usuario);
				 Registro.Nombre = Entidad.Nombre;
				 Registro.Correo = Entidad.Correo;
				 Registro.Login = Entidad.Login;
				 Registro.Password = Entidad.Password;
				 Registro.IdRol = Entidad.IdRol;
				 Registro.Contador = Entidad.Contador;
				 Registro.Bloqueado = Entidad.Bloqueado;
				 Registro.CambiarPassword = Entidad.CambiarPassword;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Usuario Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Usuario.Find(Entidad.Id_Usuario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Usuario Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Usuario.Where(a=>a.Id_Usuario == Entidad.Id_Usuario).Count() > 0;
			}
		}
        public static int ObtenerIDUsuarioSiCredencialesValidas(string UserName)
        {
            using (BDSistemLock bd = new BDSistemLock())
            {
                var usuarioEncontrado = bd.Usuario
                    .FirstOrDefault(a => a.Login.ToLower() == UserName.ToLower());

                if (usuarioEncontrado != null)
                {
                    return usuarioEncontrado.Id_Usuario;
                }
                else
                {
                    return -1; // Valor que indica que las credenciales no son válidas
                }
            }
        }

        public static bool ValidarCredenciales(string UserName, byte[] Password)
        {
            using (BDSistemLock bd = new BDSistemLock())
            {
                return bd.Usuario.Where(a => a.Login.ToLower() == UserName.ToLower() && a.Password == Password).Count() > 0;
            }
        }
        public static Usuario Registro (Usuario Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Usuario.Where(a=>a.Id_Usuario == Entidad.Id_Usuario).SingleOrDefault();
			}
		}
		 public static List<Usuario> Lista (bool Activo = true)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Usuario.Where(a=>a.Activo == Activo).ToList();
			}
		}

		public static byte[] Sha256 (string input)
		{
			using (SHA256 sha256 = SHA256.Create ())
			{ 
				return sha256.ComputeHash(UTF8Encoding.UTF8.GetBytes (input));
			}
		}

		public static int ObtenerIDRol (int Id_Usuario)
		{
			using (BDSistemLock bd = new BDSistemLock ())
			{
				var usuarioEncontrado = bd.Usuario.Where(a=> a.Id_Usuario == Id_Usuario).FirstOrDefault();

                if (usuarioEncontrado != null)
                {
                    return usuarioEncontrado.IdRol;
                }
                else
                {
                    return -1; // Valor que indica que las credenciales no son válidas
                }
            }
		}
		

		public static List<Usuario> ListaUsuario()
		{
            using (BDSistemLock bd = new BDSistemLock())
			{
                return bd.Usuario.Select(a => new Usuario
				{
                    Id_Usuario = a.Id_Usuario,
                    Nombre = a.Nombre,
                    Correo = a.Correo,
                    Login = a.Login,
                    Bloqueado = a.Bloqueado,
                    CambiarPassword = a.CambiarPassword,
                    
                }).ToList();
            }
        }

		
	}
}
