using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("RolFormularios")]
	public class RolFormularios
	 {
		[Key]
		public int IdRolFormulario { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public int IdFormulario { get; set; }
		public bool? Activo { get; set; }
		[Required]
		public int UsuarioRegistro { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}
