using kiblah.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kiblah_skkb.Data {
    public class ApplicationDbContext : IdentityDbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) {
        }

        public DbSet<Pendaftaran> Pendaftarans { get; set; }
    }
    
}