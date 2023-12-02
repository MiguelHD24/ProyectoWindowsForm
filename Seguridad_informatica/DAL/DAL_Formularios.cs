using System;
using System.Collections.Generic;
using System.Linq;
using EL;

namespace DAL
{
	 public static class DAL_Formularios
	{
		 public static Formularios Insert (Formularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 Entidad.Activo = true;
				 Entidad.FechaRegistro = DateTime.Now;
				 bd.Formularios.Add(Entidad);
				 bd.SaveChanges();
				 return Entidad;
			}
		}
		 public static bool Update (Formularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Formularios.Find(Entidad.IdFormulario);
				 Registro.Formulario = Entidad.Formulario;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Anular (Formularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 var Registro = bd.Formularios.Find(Entidad.IdFormulario);
				 Registro.Activo = Entidad.Activo;
				 Registro.UsuarioActualiza = Entidad.UsuarioActualiza;
				 Registro.FechaActualizacion = Entidad.FechaActualizacion;
				 return bd.SaveChanges() > 0;
			}
		}
		 public static bool Existe (Formularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Formularios.Where(a=>a.IdFormulario == Entidad.IdFormulario).Count() > 0;
			}
		}
		 public static Formularios Registro (Formularios Entidad)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Formularios.Where(a=>a.IdFormulario == Entidad.IdFormulario).SingleOrDefault();
			}
		}
		 public static List<Formularios> Lista (bool Activo = true)
		{
			 using (BDSistemLock bd = new BDSistemLock ())
			{
				 return bd.Formularios.Where(a=>a.Activo == Activo).ToList();
			}
		}
	}
}
