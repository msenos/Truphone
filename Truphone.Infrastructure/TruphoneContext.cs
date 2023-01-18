using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Truphone.Infrastructure.Models;

namespace Truphone.Infrastructure
{
    public class TruphoneContext : DbContext
    {
        public TruphoneContext(DbContextOptions<TruphoneContext> options) : base(options)
        {
            
        }
     
        public DbSet<Device> Devices { get; set; }
        public DbSet<Brand> Brands { get; set; }

        

    }
}

