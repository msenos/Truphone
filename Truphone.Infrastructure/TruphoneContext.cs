using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Truphone.Infrastructure
{
    public class TruphoneContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public string DbPath { get; }

        public TruphoneContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "truphone.db");
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}

