using Waterlog.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Waterlog.Database
{
    public class SqliteContext : DbContext
    {
        public SqliteContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data source=aquarium.db");
        }

        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
        {
            base.Database.Migrate();
        }

        public DbSet<Aquarium> Aquarium { get; set; }
        public DbSet<Decoration> Decorations { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Livestock> Livestock { get; set; }
        public DbSet<Tank> Tank { get; set; }
    }
}
