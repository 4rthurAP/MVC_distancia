using ProvaCandidato.Data.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data
{
  public class ContextoPrincipal : DbContext
  {
    const string CONNECTION_STRING = @"Data Source=DESKTOP-ARTKF28\\SQLEXPRESS;Initial Catalog=Desenvolvimento;Integrated Security=True";
    public ContextoPrincipal() : base(CONNECTION_STRING) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);
    }
  }
}
