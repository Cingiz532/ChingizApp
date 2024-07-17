using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CINGIZ\MSSQLSERVER01;Database=Chingiz;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
