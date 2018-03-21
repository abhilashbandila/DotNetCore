using Learn.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Data
{
    public class DotNetCoreContext : DbContext
    {
        public DotNetCoreContext(DbContextOptions<DotNetCoreContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
  
}
