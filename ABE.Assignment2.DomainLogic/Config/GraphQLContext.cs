using ABE.Assignment2.DomainLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABE.Assignment2.DomainLogic.Config
{
    public class GraphQLContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }
        public GraphQLContext(DbContextOptions<GraphQLContext> optionsbuilder) : base(optionsbuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasData(
                new Teacher
                {
                    FirstName = "Poul",
                    LastName = "Ejnar",
                    Id = 1
                });
        }
    }
}
