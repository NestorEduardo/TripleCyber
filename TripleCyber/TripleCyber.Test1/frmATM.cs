using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleCyber.Test1
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Dictionary<int, int> bills = new Dictionary<int, int>();
            List<int> allBills = new List<int>() { 2000, 1000, 500, 200, 100, 50, 25, 20, 10, 5, 1 };
            List<int> availalbleBills = new List<int>() { 2000, 1000, 500, 200, 100, 50, 25, 20, 10, 5, 1 }; ;

            var given = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            var input = numericUpDown1.Value;
      
            for (int i = 0; i < given.Length; i++)
            {
                var bill = availalbleBills.Max();

                while (input >= bill)
                {
                    input -= bill;
                    given[i] += 1;
                }

                availalbleBills.RemoveAt(0);
            }

            for (int i = 0; i < allBills.Count; i++)
            {
                if (given[i] > 0)
                {
                    label2.Text += $"{allBills[i]} : {given[i]}\n";
                }
            }
        }
    }
}
