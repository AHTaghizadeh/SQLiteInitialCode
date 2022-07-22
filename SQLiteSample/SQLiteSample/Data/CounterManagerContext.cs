using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLiteSample.Models;

namespace SQLiteSample.Data
{
    internal class CounterManagerContext:DbContext
    {
        public CounterManagerContext()
        {

        }

        public CounterManagerContext(DbContextOptions<CounterManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CounterManager> CounterManager { get; set; } = null!;
        public virtual DbSet<CounterStamp> CountStamp { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DB.db");
        }
    }
}
