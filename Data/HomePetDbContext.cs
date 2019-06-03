using Microsoft.EntityFrameworkCore;
using HomePet.Models;
namespace HomePet.Data
{
    public class HomePetDbContext : DbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public HomePetDbContext(DbContextOptions<HomePetDbContext> o) : base(o) {

    }
}
}