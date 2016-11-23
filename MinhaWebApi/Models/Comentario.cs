using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaWebApi.Models
{
    public class Comentario
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime criado { get; set; }
        
        public Post post { get; set; }
        public Usuario usuario { get; set; }
    }
}