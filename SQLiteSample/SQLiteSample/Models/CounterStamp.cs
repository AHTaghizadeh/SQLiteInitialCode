using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSample.Models
{
    internal class CounterStamp
    {
        public int Id { get; set; }
        string randomDate = null!;
        DateTime creationTime = DateTime.Now;
    }
}
