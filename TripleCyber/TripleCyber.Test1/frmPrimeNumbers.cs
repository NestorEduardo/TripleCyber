using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TripleCyber.Test1
{
    public partial class frmPrimeNumbers : Form
    {
        public frmPrimeNumbers()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GeneratePrimesNaive(Convert.ToInt32(numericUpDown1.Value));
        }

        public void GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);

                    listBox1.Items.Add(nextPrime);

                }
                nextPrime += 2;
            }

            Program.primes = primes;
        }
    }
}
