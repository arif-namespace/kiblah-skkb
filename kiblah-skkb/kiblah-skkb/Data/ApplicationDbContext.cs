using kiblah.Models;
using kiblah_skkb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kiblah_skkb.Data {
    public class ApplicationDbContext : IdentityDbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) {
        }

        public DbSet<Pendaftaran> Pendaftarans { get; set; }
        public DbSet<Negeri> Negeri { get; set; }
    }
    
}