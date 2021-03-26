using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCUDEMY.Models;
using MVCUDEMY.Models.Enums;

namespace MVCUDEMY.Data
{
    public class MVCUDEMYContext : DbContext
    {
        public MVCUDEMYContext (DbContextOptions<MVCUDEMYContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
