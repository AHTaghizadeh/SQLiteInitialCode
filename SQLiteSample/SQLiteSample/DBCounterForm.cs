namespace SQLiteSample
{
    public partial class DBCounterForm : Form
    {
        private CounterManagerLogic cml;
        public DBCounterForm()
        {
            InitializeComponent();
            cml = new CounterManagerLogic();
        }

        private void UpdateDBBt_Click(object sender, EventArgs e)
        {
            cml.IncreaseCount(1);
            CountLb.Text = $"Count: {cml.GetTotalCount()}";
        }
    }
}