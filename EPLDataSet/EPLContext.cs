using EPLDataSet.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EPLDataSet
{
    public class EPLContext : DbContext
    {
        public EPLContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Team> Teams { get; set; }



    }
}
