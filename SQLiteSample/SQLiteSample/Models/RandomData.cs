using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSample.Models
{
    internal class RandomData
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public int TheActualRandomData { get; set; } = 0;
    }
}
