using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudaspnet.Models
{
    public class eletronico
    {
        [Key]
        public int codigo { get; set; }
        public string aparelho { get; set; }
        public string descricao { get; set; }
    }
}