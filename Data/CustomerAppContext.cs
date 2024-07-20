using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerApp.Models;

namespace CustomerApp.Data
{
    public class CustomerAppContext : DbContext
    {
        public CustomerAppContext (DbContextOptions<CustomerAppContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerApp.Models.Customer> Customer { get; set; } = default!;
    }
}
