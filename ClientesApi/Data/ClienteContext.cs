using ClientesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesApi.Data;

public class ClienteContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    public ClienteContext(DbContextOptions<ClienteContext> opts) : base(opts)
    {
        
    }
}
