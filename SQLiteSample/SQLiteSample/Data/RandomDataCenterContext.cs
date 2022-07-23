using Microsoft.EntityFrameworkCore;
using SQLiteSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLiteSample.Data
{
    internal class RandomDataCenterContext : DbContext
    {
        public RandomDataCenterContext()
        {
        }
        public RandomDataCenterContext(DbContextOptions<RandomDataCenterContext> options)
            : base(options)
        {
        }
        public virtual DbSet<RandomData> RandomDatas { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DB.db");
        }
    }
}
