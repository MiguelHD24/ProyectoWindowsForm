using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
	 public class BDSistemLock:DbContext
	{
		public BDSistemLock():base(Conexion.ConexionString(true)){}
		 public virtual DbSet<Formularios> Formularios{get;set;}
		 public virtual DbSet<Permisos> Permisos{get;set;}
		 public virtual DbSet<Roles> Roles{get;set;}
		 public virtual DbSet<RolFormularios> RolFormularios{get;set;}
		 public virtual DbSet<RolPermisos> RolPermisos{get;set;}
		 public virtual DbSet<Usuario> Usuario{get;set;}
		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Formularios>().Property(e => e.Formulario).IsUnicode(false);
			modelBuilder.Entity<Permisos>().Property(e => e.Permiso).IsUnicode(false);
			modelBuilder.Entity<Roles>().Property(e => e.Rol).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Nombre).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Correo).IsUnicode(false);
			modelBuilder.Entity<Usuario>().Property(e => e.Login).IsUnicode(false);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			 base.OnModelCreating(modelBuilder);
		}
		}
	}
