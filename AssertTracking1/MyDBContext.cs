using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertTracking1
{
    internal class MyDBContext :DbContext
    {
       public DbSet<Asset> assets { get; set; } 
        string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Asset;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
