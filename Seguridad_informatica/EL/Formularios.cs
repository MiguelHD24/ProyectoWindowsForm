using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Formularios")]
	public class Formularios
	 {
		[Key]
		public int IdFormulario { get; set; }
		[MaxLength(50)]
		[Required]
		public string Formulario { get; set; }
		public bool? Activo { get; set; }
		[Required]
		public int UsuarioRegistro { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}
