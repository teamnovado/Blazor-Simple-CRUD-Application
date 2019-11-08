using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Datalayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Datalayer.Context
{
    public class VerifieerContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

        public VerifieerContext(DbContextOptions<VerifieerContext> options) : base(options)
        { }

        public override int SaveChanges()
        {
            UpdateEntityDates();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            UpdateEntityDates();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateEntityDates()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is EntityBase && (
                                e.State == EntityState.Added
                                || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).LastModified = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((EntityBase)entityEntry.Entity).Created = DateTime.Now;
                }
            }
        }
    }
}
