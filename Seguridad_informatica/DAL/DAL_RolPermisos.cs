using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_RolPermisos
	{
		 public static RolPermisos Insert (RolPermisos Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.RolPermisos.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (RolPermisos Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.IdPermiso = Entidad.IdPermiso;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (RolPermisos Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (RolPermisos Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolPermisos.Where(a=>a.IdRolPermiso == Entidad.IdRolPermiso).Count() > 0;
			}
		}
		 public static RolPermisos Registro (RolPermisos Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolPermisos.Where(a=>a.IdRolPermiso == Entidad.IdRolPermiso).SingleOrDefault();
			}
		}
		 public static List<RolPermisos> Lista (bool Activo = true)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolPermisos.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
