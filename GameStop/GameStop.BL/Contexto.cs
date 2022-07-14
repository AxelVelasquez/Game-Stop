using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class Contexto: DbContext
    {
        public Contexto() : base("GameStopDB")
        {

        }
        public DbSet<Producto> Productos { get; set; }
    }
}
