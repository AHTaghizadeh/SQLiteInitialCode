using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSample.Models
{
    internal class CounterManager
    {
        public int Id { get; set; }
        int totalCount;
        ICollection<CounterStamp> counterStamps = null!;
    }
}
