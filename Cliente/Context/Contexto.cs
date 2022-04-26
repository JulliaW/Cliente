using Cliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cliente.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBCliente")
        {
        }

        public DbSet<ClienteModel> Cliente { get; set; }
    }
}