using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaWebApi.Models
{
    public class Categoria
    {
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        public virtual ICollection<Post> posts { get; set; }
    }
}