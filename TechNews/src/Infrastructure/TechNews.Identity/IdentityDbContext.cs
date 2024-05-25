using TechNews.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using TechNews.Domain.Entities;
using State = TechNews.Identity.Models.State;
using City = TechNews.Identity.Models.City;

namespace TechNews.Identity
{
    [ExcludeFromCodeCoverage]
    public class IdentityDbContext: IdentityDbContext<ApplicationUser>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
        }

        //public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);

            

            builder.Entity<ApplicationUser>()
                .HasOne<Country>(a => a.Country)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasOne<State>(a => a.State)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasOne<City>(a => a.City)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            //foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            builder.Entity<ApplicationUser>()
                .HasIndex(x => x.CountryId)
                .IsUnique(false);
            builder.Entity<ApplicationUser>()
                .HasIndex(x => x.CityId)
                .IsUnique(false);
            builder.Entity<ApplicationUser>()
                .HasIndex(x => x.StateId)
                .IsUnique(false);
        }

    }
}
