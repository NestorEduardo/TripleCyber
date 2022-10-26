using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleCyber.Test1
{
    public partial class frmCoincidences : Form
    {
        public frmCoincidences()
        {
            InitializeComponent();
        }

        private void frmCoincidences_Load(object sender, EventArgs e)
        {
            Program.numbers.Sort();
            foreach (var number in Program.numbers)
            {
                if (IsPrime(number))
                {
                    listBox1.Items.Add(number);
                }
            }

            GenerateFibonacciSerie();

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public void GenerateFibonacciSerie()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            number = (int)listBox1.Items[listBox1.Items.Count - 1];

            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                listBox2.Items.Add(n2);
            }
        }
    }
}
