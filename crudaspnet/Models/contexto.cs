using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace crudaspnet.Models
{
    public class contexto: DbContext
    {
        public DbSet<eletronico> Eletronico { get; set; }
    }
}