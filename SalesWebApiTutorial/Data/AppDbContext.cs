using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebApiTutorial;
using SalesWebApiTutorial.Models;

namespace SalesWebApiTutorial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;

        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;

        public DbSet<OrderLine> OrderLines { get; set; } = default!;
    }
}
