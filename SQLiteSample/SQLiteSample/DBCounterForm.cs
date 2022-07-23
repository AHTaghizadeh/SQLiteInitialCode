using SQLiteSample.Models;
using SQLiteSample.Data;

namespace SQLiteSample
{
    public partial class DBCounterForm : Form
    {
        Random rand = new Random();
        int maxNumberOfTries = 0;
        public DBCounterForm()
        {
            InitializeComponent();
            UpdateLable();
        }

        private void UpdateDBBt_Click(object sender, EventArgs e)
        {
            int numberOfTries = 0;
            bool newlyAdded = false;
            using RandomDataCenterContext ctx = new RandomDataCenterContext();
            while(newlyAdded == false)
            {
                numberOfTries++;
                RandomData rd1 = new RandomData()
                {
                    Id = rand.Next(0, 10000) + numberOfTries,
                    TheActualRandomData = rand.Next(100000, 200000) + numberOfTries,
                    CreationTime = DateTime.Now
                };
                if(IsIdPresent(rd1.Id))
                {
                    continue;
                }
                try
                {
                    ctx.RandomDatas.Add(rd1);
                    ctx.SaveChanges();
                    if (numberOfTries > maxNumberOfTries) maxNumberOfTries = numberOfTries;
                    UpdateLable();
                    newlyAdded = true;
                    break;
                }
                catch (Exception error)
                {
                    // removed to increase speed.
                    // MessageBox.Show("Something went wrong. Try again");
                    // MessageBox.Show(error.Message);
                }
            }
            MessageBox.Show($"Added a new entry with {numberOfTries} tries");
        }
        private bool IsIdPresent(int idToCheck)
        {
            using RandomDataCenterContext ctx = new RandomDataCenterContext();
            var x = ctx.RandomDatas.Where(p => p.Id == idToCheck);
            if (x.Count() > 0) return true;
            else return false;
        }
        private void UpdateLable()
        {
            int numberOfEntries = GetNumberOfEntities();
            double averageOfEntires = GetAverageOfEntities();
            NAveLb.Text = $"#, Average: {numberOfEntries}, {averageOfEntires} \n MaximumTriesSoFar={maxNumberOfTries}";
        }
        private int GetNumberOfEntities()
        {
            using RandomDataCenterContext ctx = new RandomDataCenterContext();
            return ctx.RandomDatas.Count();
        }
        private double GetAverageOfEntities()
        {
            int sum = 0;
            using RandomDataCenterContext ctx = new RandomDataCenterContext();
            var randomDatas = ctx.RandomDatas;
            foreach (RandomData rd in randomDatas)
            {
                sum += rd.TheActualRandomData;
            }
            return (double)sum / GetNumberOfEntities();
        }
    }
}