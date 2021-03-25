using CFSBusinesses.Core.EventsAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CFS.Data
{
    public class CFSDbContext : DbContext
    {
        public CFSDbContext(DbContextOptions<CFSDbContext> options) : base(options)
        {
        }

        public DbSet<CFSEvent> CFSEvents { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
