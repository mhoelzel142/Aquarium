using Waterlog.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Data.Sqlite;

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
            // Ensure database is created, however this does not create tables
            base.Database.Migrate();

            // Create tables in Sqlite Db
            RelationalDatabaseCreator creator = (RelationalDatabaseCreator)base.Database.GetService<IDatabaseCreator>();
            try
            {
                creator.CreateTables();

            }
            catch (SqliteException)
            {

            }
        }

        public DbSet<Aquarium> Aquarium { get; set; }
        public DbSet<Decoration> Decorations { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Livestock> Livestock { get; set; }
        public DbSet<Tank> Tank { get; set; }
        public DbSet<Reading> Reading { get; set; }
        public DbSet<AquariumTask> AquariumTask { get; set; }
        public DbSet<AquariumTaskType> AquariumTaskType { get; set; }
        public DbSet<AquariumTaskFrequency> AquariumTaskFrequency { get; set; }
    }
}
