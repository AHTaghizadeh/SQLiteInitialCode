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
        CounterManagerContext cmc;
        public CounterManagerLogic()
        {
            CounterManagerContext cmc = new CounterManagerContext();
            var cm = cmc.CounterManager;
            if(cm == null)
            {
                // there is nothing here. Create one.
                var ncm = new CounterManager();
                ncm.Id = 1;
                ncm.totalCount = 10;
                // ncm.counterStamps = new List<CounterStamp>();
                // CounterStamp cs = new CounterStamp();
                // cs.Id = 1;
                // cs.randomDate = "Something";
                // cs.creationTime = DateTime.Now;
                // cmc.CountStamp.Add(cs);
                // ncm.counterStamps.Add(cs);
                cmc.CounterManager.Add(ncm);
                cmc.SaveChangesAsync();
            }
            else
            {
                var ncm = new CounterManager();
                ncm.Id = 1;
                ncm.totalCount = 10;
                // ncm.counterStamps = new List<CounterStamp>();
                // CounterStamp cs = new CounterStamp();
                // cs.Id = 1;
                // cs.randomDate = "Something";
                // cs.creationTime = DateTime.Now;
                // cmc.CountStamp.Add(cs);
                // ncm.counterStamps.Add(cs);
                cmc.CounterManager.Add(ncm);
                cmc.SaveChangesAsync();
            }
        }
        public int GetTotalCount()
        {
            var cm = cmc.CounterManager.Where(p => true).FirstOrDefault();
            if(cm is CounterManager)
            {
                return cm.totalCount;
            }

            return latestCount;
        }
        public async Task IncreaseCountAsync(int x)
        {
            var cm = cmc.CounterManager.Where(p => true).FirstOrDefault();
            if(cm is CounterManager)
            {
                cm.totalCount=cm.totalCount + x;
            }
            await cmc.SaveChangesAsync();
            var its = cmc.CounterManager;
            return;
        }
    }
}
