using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projeto_Crud.Models
{
    public class Context : DbContext
    {
        public DbSet<Clientes>clientes{get;set;}    
    }
}