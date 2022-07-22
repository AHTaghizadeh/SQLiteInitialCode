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
            var cm = cmc.CounterManager.FirstOrDefault();
            if(cm == null)
            {
                // there is nothing here. Create one.
                var ncm = new CounterManager();
                ncm.Id = 1;
                ncm.totalCount = 1;
                // ncm.counterStamps = new List<CounterStamp>();
                CounterStamp cs = new CounterStamp();
                cs.Id = 1;
                cs.randomDate = "Something";
                cs.creationTime = DateTime.Now;
                // cmc.CountStamp.Add(cs);
                // ncm.counterStamps.Add(cs);
                cmc.CounterManager.Add(ncm);
                cmc.SaveChanges();
            }

            latestCount = 0;
        }
        public int GetTotalCount()
        {
            using CounterManagerContext cmc = new CounterManagerContext();
            var cm = cmc.CounterManager.Where(p => true).FirstOrDefault();
            if(cm is CounterManager)
            {
                return cm.totalCount;
            }

            return latestCount;
        }
        public void IncreaseCount(int x)
        {

            using CounterManagerContext cmc = new CounterManagerContext();
            var cm = cmc.CounterManager.Where(p => true).FirstOrDefault();
            if(cm is CounterManager)
            {
                cm.totalCount=cm.totalCount + x;
            }
            cmc.SaveChanges();
            return;
        }
    }
}
