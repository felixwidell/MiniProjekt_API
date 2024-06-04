using Microsoft.EntityFrameworkCore;
using MiniProjekt_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MiniProjekt_API.Data
{

    public class ApiContext : DbContext
    {
        public DbSet<InterestLinks> InterestLinks { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<RelationTable> RelationTable { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=MiniProjektAPI;Integrated Security=True");
        //    }
        //}
    }
}