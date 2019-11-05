using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projeto_Crud.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public int Telefone { get; set; }
        
    }
}