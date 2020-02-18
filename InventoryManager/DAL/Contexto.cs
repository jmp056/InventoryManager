using InventoryManager.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace InventoryManager.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios{ get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
