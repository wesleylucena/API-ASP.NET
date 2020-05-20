using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIrest.Model
{
    public class Cadastro
    {
        [Key]
        public int id { get; set; }

        [MaxLength(60, ErrorMessage = "esse campo deve ter no minimo 2 caracteres e no maximo 60")]
        [MinLength(2, ErrorMessage = "esse campo deve ter no minimo 2 caracteres e no maximo 60")]
        public string Nome { get; set; }

        [MaxLength(60, ErrorMessage = "esse campo deve ter no minimo 8 caracteres e no maximo 60")]
        [MinLength(2, ErrorMessage = "esse campo deve ter no minimo 2 caracteres e no maximo 60")]
        public string Senha { get; set; }
    }
}
