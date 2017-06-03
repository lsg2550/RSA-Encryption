using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA_Encryption.rsa;

namespace RSA_Encryption {
    public partial class rsaForm : Form {
        public rsaForm() {
            InitializeComponent();

            //Prime Initialize
            Prime.init();
            textboxLog.Text = Prime.toString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e) {
            bool pBool = false, qBool = false;
            int p = 0, q = 0, n = 0, r = 0;

            //Testing TextBoxP Primality
            if (!int.TryParse(textboxP.Text, out p)) {
                textboxLog.Text += Environment.NewLine + "P is not prime.";
            } else {
                if (Prime.isPrime(p)) {
                    textboxLog.Text += Environment.NewLine + "P is prime";
                    pBool = true;
                }
            }
            //Testing TextBoxQ Primality
            if (!int.TryParse(textboxQ.Text, out q)) {
                textboxLog.Text += Environment.NewLine + "P is not prime.";
            } else {
                if (Prime.isPrime(q)) {
                    textboxLog.Text += Environment.NewLine + "Q is prime";
                    qBool = true;
                }
            }

            //If both are prime, do the rest of the calculations
            if ((pBool && qBool) && (p != q)) {
                //Setting N and R
                n = p * q;
                r = (p - 1) * (q - 1);

                //GUI Updates
                groupbox2.Show();
                textboxN.Text += n;
                textboxR.Text += q;

                //Warnings to User regarding primes
                if (n < 90) {
                    textboxLog.Text += Environment.NewLine + "WARNING - N<90: some letters (some upper-case and all lower-case letters) will not be recognized";
                } else if (n < 128) {
                    textboxLog.Text += Environment.NewLine + "WARNING - N<128: some characters (including lower-case letters) will not be recognized";
                } else if (n < 255) {
                    textboxLog.Text += Environment.NewLine + "WARNING - N<255: some extended ASCII characters will not be recognized";
                } else if (n * n > Prime.getMaxInt) {
                    textboxLog.Text += Environment.NewLine + "WARNING - N>sqrt(" + Prime.getMaxInt + "): some calculations may overflow and produce invalid results";
                }

                //Display Prime Candidates
                textboxCandidates.Text = Prime.getCandidates((p - 1) * (q - 1));

                //Toggle GroupBox3
                groupBox3.Show();
            }

            if (p == q) {
                textboxLog.Text += Environment.NewLine + "P and Q cannot be equal.";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            //Clear TextBoxes
            textboxP.Clear();
            textboxQ.Clear();
            textboxLog.Clear();
            textboxLog.Text = Prime.toString();

            //Disable Groups
            groupbox2.Hide();
        }
    }
}
