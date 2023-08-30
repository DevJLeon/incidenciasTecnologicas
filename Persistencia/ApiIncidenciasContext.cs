using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class ApiIncidenciasContext : DbContext
{
    public ApiIncidenciasContext(DbContextOptions<ApiIncidenciasContext> options) : base(options)
    {
    }
}