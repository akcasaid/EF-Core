using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class AppDbContext:DbContext // Db context sınıfından miras aldım bu bize entitiy framework paketinden geliyor
    {
        public DbSet<Product> Products { get; set; }


        public AppDbContext()
        {

        }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}
