using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cliente.Models
{
    public class ClienteModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        public string CPF { get; set; }

        public string Telefone { get; set; }
    }
}