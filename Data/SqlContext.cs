using ef_web_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_web_app.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}
