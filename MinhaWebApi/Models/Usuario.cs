using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaWebApi.Models
{
    public class Usuario
    {
        public int id { get; set; }

        [Required]
        public string login { get; set; }

        [Required, DataType(DataType.Password)]
        public string senha { get; set; }

        public ICollection<Post> posts { get; set; }
        public ICollection<Comentario> comentarios { get; set; }

    }
}