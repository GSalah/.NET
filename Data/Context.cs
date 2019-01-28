using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  class Context : DbContext
    {
        public Context() : base("db_name") {}
        public DbSet<Bibliotheque> Bibliotheques { get; set; }

    }

}
