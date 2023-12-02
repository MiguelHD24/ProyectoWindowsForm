using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_RolFormularios
	{
		 public static RolFormularios Insert (RolFormularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.RolFormularios.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (RolFormularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
				 Registro.IdRol = Entidad.IdRol;
				 Registro.IdFormulario = Entidad.IdFormulario;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (RolFormularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (RolFormularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolFormularios.Where(a=>a.IdRolFormulario == Entidad.IdRolFormulario).Count() > 0;
			}
		}
		 public static RolFormularios Registro (RolFormularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolFormularios.Where(a=>a.IdRolFormulario == Entidad.IdRolFormulario).SingleOrDefault();
			}
		}
		 public static List<RolFormularios> Lista (bool Activo = true)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.RolFormularios.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
