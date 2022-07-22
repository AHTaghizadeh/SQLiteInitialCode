using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteSample.Models;
using SQLiteSample.Data;

namespace SQLiteSample
{
    internal class CounterManagerLogic
    {
        private int latestCount;
        public CounterManagerLogic()
        {
            using CounterManagerContext cmc = new CounterManagerContext();

            latestCount = 0;
        }
        public int GetTotalCount()
        {
            return latestCount;
        }
        public void IncreaseCount(int x)
        {

            latestCount++;
            return;
        }
    }
}
