using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolPermisos")]
	public class RolPermisos
	 {
		[Key]
		public int IdRolPermiso { get; set; }
		public int IdRol { get; set; }
		public int IdPermiso { get; set; }
		public bool? Activo { get; set; }
		[Required]
		public int UsuarioRegistro { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
    public class RolPermisoViewModel
    {
        public int IdRolPermiso { get; set; }
        public string Rol { get; set; }
        public string Permiso { get; set; }
    }
}
