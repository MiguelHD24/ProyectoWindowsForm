using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Usuario")]
	public class Usuario
	 {
		[Key]
		public int Id_Usuario { get; set; }
		[MaxLength(200)]
		[Required]
		public string Nombre { get; set; }
		[MaxLength(200)]
		[Required]
		public string Correo { get; set; }
		[MaxLength(50)]
		[Required]
		public string Login { get; set; }
		[Required]
		public byte[] Password { get; set; }
		[Required]
		public int IdRol { get; set; }
		[Required]
		public int Contador { get; set; }
		[Required]
		public bool Bloqueado { get; set; }
		[Required]
		public bool CambiarPassword { get; set; }
		[Required]
		public bool Activo { get; set; }
		[Required]
		public int UsuarioRegistro { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public int? UsuarioActualiza { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	 }
}
