using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MinhaWebApi.Models
{
    public class Post
    {
        public int id { get; set; }
        public string titulo { get; set; }

        [DataType(DataType.Html)]
        public string conteudo { get; set; }

        public DateTime criado { get; set; }

        public Categoria categoria { get; set; }

        public virtual Usuario usuario { get; set; }
        public int? UsuarioId { get; set; }

        public ICollection<Comentario> comentarios { get; set; }
        
    }
}