using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Roles
	{
		 public static Roles Insert (Roles Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Roles.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Roles Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Roles.Find(Entidad.IdRol);
				 Registro.Rol = Entidad.Rol;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Roles Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Roles.Find(Entidad.IdRol);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Roles Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Roles.Where(a=>a.IdRol == Entidad.IdRol).Count() > 0;
			}
		}
		 public static Roles Registro (Roles Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Roles.Where(a=>a.IdRol == Entidad.IdRol).SingleOrDefault();
			}
		}
		 public static List<Roles> Lista (bool Activo = true)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Roles.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
