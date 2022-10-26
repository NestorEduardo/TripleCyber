namespace TripleCyber.Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandomValues_Click(object sender, EventArgs e)
        {
            frmRandomValues frmRandomValues = new frmRandomValues();
            frmRandomValues.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrimeNumbers frmPrimeNumbers = new frmPrimeNumbers();    
            frmPrimeNumbers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmATM frmATM = new frmATM();
            frmATM.Show();
        }

        private void btnCoincidences_Click(object sender, EventArgs e)
        {
            if (Program.numbers.Count == 0)
            {
                MessageBox.Show("Debe generar los numeros aleatorios antes de evaluar las coincidencias");
            }
            else
            {
                frmCoincidences frmCoincidences = new frmCoincidences();
                frmCoincidences.Show();
            }
          
        }
    }
}