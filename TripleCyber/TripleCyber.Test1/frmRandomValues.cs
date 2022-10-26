namespace TripleCyber.Test1
{
    public partial class frmRandomValues : Form
    {
        public frmRandomValues()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int minimum = 1;
            int maximium = 100;

            GetRandomNumbers(minimum, maximium, Convert.ToInt32(numericUpDown1.Value));
        }

        public void GetRandomNumbers(int from, int to, int numberOfElement)
        {
            List<int> numbers = new List<int>();    
            var random = new Random();
            while (listBox1.Items.Count < numberOfElement)
            {
                int element = random.Next(from, to);

                if (!listBox1.Items.Contains(element))
                {
                    numbers.Add(element);
                    listBox1.Items.Add(element);
                }
            }

            Program.numbers = numbers;
        }
    }
}
