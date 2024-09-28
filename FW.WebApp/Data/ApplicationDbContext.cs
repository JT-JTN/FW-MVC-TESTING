using FW.CoreBusiness;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FW.WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<AppColor> AppColors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Client>(cl =>
            {
                cl.HasMany(c => c.Vehicles)
                                    .WithOne(v => v.Client)
                                    .HasForeignKey(v => v.Owner)
                                    .OnDelete(DeleteBehavior.ClientSetNull);
                cl.HasIndex(cl => cl.EmailAddress).IsUnique();
                cl.HasIndex(cl => cl.PhoneNumber).IsUnique();
                cl.Property(cl => cl.Created).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                cl.Property(cl => cl.Updated).HasDefaultValueSql("GETDATE()").ValueGeneratedOnUpdate();
            });

            builder.Entity<AppColor>(ac =>
            {
                ac.HasMany(v => v.Vehicles)
                                    .WithOne(c => c.AppColor)
                                    .HasForeignKey(v => v.Color)
                                    .OnDelete(DeleteBehavior.ClientSetNull); 
                ac.HasIndex(ac => ac.Name).IsUnique();
                ac.HasIndex(ac => ac.Abbreviation).IsUnique();
            });
        }
    }
}
