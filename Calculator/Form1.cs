using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using Numerics;

namespace Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        { // Main Page
            if (tabPage.SelectedIndex == 1)
            {
                this.AcceptButton = factor_factorizeBtn;
            }
        }

        private void tabPageSums_SelectedIndexChanged(object sender, EventArgs e)
        { // Sums Page
            if (tabPageSums.SelectedIndex == 2)
            {
                this.AcceptButton = sum_naturalsBtn;
            }
        }

        private void sum_naturalsBtn_Click(object sender, EventArgs e)
        {
            BigInteger k = BigInteger.Parse(sum_naturals_lowerboundTxtbox.Text);
            BigInteger n = BigInteger.Parse(sum_naturals_upperboundTxtbox.Text);
            BigInteger result = Sums.Naturals(k, n);
            sum_naturals_displayTxtbox.Text = result.ToString();
        }

        private void factor_factorizeBtn_Click(object sender, EventArgs e)
        {
            List<BigInteger> n1_factors = new List<BigInteger>();
            List<BigInteger> n2_factors = new List<BigInteger>();
            BigInteger n1 = new BigInteger();
            BigInteger n2 = new BigInteger();
            try
            {
                n1 = BigInteger.Parse(factors_numTxtbox1.Text);
            }
            catch { }
            try
            {
                n2 = BigInteger.Parse(factors_numTxtbox2.Text);
            }
            catch { }

            bool isprime1 = false;
            if (n1 != 0) { isprime1 = checkPrimality(n1); }
            bool isprime2 = false;
            if (n2 != 0) { isprime2 = checkPrimality(n2); }

            if (isprime1) { factors_primelbl1.Text = "Prime"; } else { factors_primelbl1.Text = ""; }
            if (isprime2) { factors_primelbl2.Text = "Prime"; } else { factors_primelbl2.Text = ""; }
            if (!isprime1 && n1 != 0)
            {
                n1_factors = Factors.getPrimeFactors(n1);
            }
            if (!isprime2 && n2 != 0)
            {
                n2_factors = Factors.getPrimeFactors(n2);
            }

            IEnumerable<BigInteger> intersection;
            if (n1 != 0 && n2 != 0)
                intersection = n1_factors.Intersect(n2_factors);
            else if (n1 != 0)
                intersection = n1_factors;
            else
                intersection = n2_factors;
            factor_resultTxtbox.Text = "";
            foreach (BigInteger i in intersection)
            {
                factor_resultTxtbox.Text += i.ToString() + "  ";
            }
        }

        private void factor_gcfBtn_Click(object sender, EventArgs e)
        {
            BigInteger n1 = new BigInteger();
            BigInteger n2 = new BigInteger();
            try
            {
                n1 = BigInteger.Parse(factors_numTxtbox1.Text);
            }
            catch { }
            try
            {
                n2 = BigInteger.Parse(factors_numTxtbox2.Text);
            }
            catch { }

            bool isprime1 = false;
            if (n1 != 0) { isprime1 = checkPrimality(n1); }
            bool isprime2 = false;
            if (n2 != 0) { isprime2 = checkPrimality(n2); }

            if (isprime1) { factors_primelbl1.Text = "Prime"; } else { factors_primelbl1.Text = ""; }
            if (isprime2) { factors_primelbl2.Text = "Prime"; } else { factors_primelbl2.Text = ""; }

            if (isprime1 || isprime2) { factor_resultTxtbox.Text = "1"; }
            else if (n1 != 0 && n2 != 0)
            {
                BigInteger greatest_common_factor = Factors.gcf(n1, n2);
                factor_resultTxtbox.Text = greatest_common_factor.ToString();
            }
            else
            {
                if (n1 != 0)
                    factor_resultTxtbox.Text = n1.ToString();
                else
                    factor_resultTxtbox.Text = n2.ToString();
            }
        }
        private bool checkPrimality(BigInteger n)
        { // By testing bases 2 and 3, each base covers eachother's Carmichael values and hence, yields 100% primality check via. 2^(p-1) = 3^(p-1) == 1 (mod p)  |  p has no solution
            bool t1 = Factors.FermatPrimalityTest(n, 2);
            bool t2 = Factors.FermatPrimalityTest(n, 3);
            if (t1 && t2)
                return true;
            else
                return false;
        }

    }
}

//Assign each new button the new Enter Press Key whenever the tab selected is appropriate