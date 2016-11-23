using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MinhaWebApi.Models
{
    public class MinhaWebApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MinhaWebApiContext() : base("name=MinhaWebApiContext")
        {
        }

        public System.Data.Entity.DbSet<MinhaWebApi.Models.Post> Posts { get; set; }

        public System.Data.Entity.DbSet<MinhaWebApi.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<MinhaWebApi.Models.Comentario> Comentarios { get; set; }

        public System.Data.Entity.DbSet<MinhaWebApi.Models.Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
