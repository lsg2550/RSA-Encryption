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
                textboxN.Text = n + "";
                textboxR.Text = r + "";

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
                textboxCandidates.Text = Prime.getCandidates(r);

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
            textboxCandidates.Clear();
            textboxN.Clear();
            textboxR.Clear();
            textboxPrimeFactK.Clear();
            textboxProdOfK.Clear();
            textboxLog.Clear();
            textboxE.Clear();
            textboxD.Clear();
            textboxLog.Text = Prime.toString();

            //Disable Groups
            groupbox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void submitK_Click(object sender, EventArgs ex) {
            textboxPrimeFactK.Clear();
            textboxProdOfK.Clear();

            string factors = "";
            int k;

            if (!int.TryParse(textboxK.Text, out k)) {
            } else {
                if (Prime.isPrime(k)) {
                    textboxPrimeFactK.Text = k + " is a prime factor";
                } else {
                    factors = Prime.getFactors(k);
                    textboxPrimeFactK.Text = factors;
                }
            }

            int index = factors.LastIndexOf("*");
            //textboxLog.Text += Environment.NewLine + index; //Logging
            if (index != -1) {
                int e = Evaluate.eval(factors.Substring(0, index));
                //textboxLog.Text += Environment.NewLine + factors; //Logging
                int d = Evaluate.eval(factors.Substring(index + 1, factors.Length - index - 1));

                textboxProdOfK.Text = e + "*" + d;
                groupBox4.Show();
            }
        }

        private void buttonCheckED_Click(object sender, EventArgs e) {
            string temp = "";
            int eX, d, r, N;
            int k; //Temp

            //Check for non-integers errors
            if (int.TryParse(textboxE.Text, out k) && int.TryParse(textboxD.Text, out k)
                && int.TryParse(textboxR.Text, out k) && int.TryParse(textboxN.Text, out k)) {
                eX = int.Parse(textboxE.Text);
                d = int.Parse(textboxD.Text);
                r = int.Parse(textboxR.Text);
                N = int.Parse(textboxN.Text);
            } else {
                eX = -1;
                d = -1;
                r = -1;
                N = -1;
                temp += "A previous entry (e, d, r, N) is failing to parse, please check that there are no non-integer characters in their textboxes." + Environment.NewLine;
            }

            //bool
            bool EandN = false,
                DandN = false,
                EandR = false,
                DandR = false;


            temp += "e = " + eX + Environment.NewLine;
            temp += "d = " + d + Environment.NewLine;
            temp += "N = " + N + Environment.NewLine;
            temp += "r = " + r + Environment.NewLine;
            temp += "e*d = " + eX * d + Environment.NewLine;
            temp += "e*d mod r = " + (eX * d) % r + Environment.NewLine;


            if (GCD.gcd(eX, N) == 1) {
                temp += "e and N are relatively prime" + Environment.NewLine;
                EandN = true;
            } else {
                temp += "e and N are not relatively prime; gcd(e,N) = " + GCD.gcd(eX, N) + Environment.NewLine;
            }
            if (GCD.gcd(d, N) == 1) {
                temp += "d and N are relatively prime" + Environment.NewLine;
                DandN = true;
            } else {
                temp += "d and N are not relatively prime; gcd(d,N) = " + GCD.gcd(d, N) + Environment.NewLine;
            }
            if (GCD.gcd(eX, r) == 1) {
                temp += "e and r are relatively prime" + Environment.NewLine;
                EandR = true;
            } else {
                temp += "e and r are not relatively prime; gcd(e,r) = " + GCD.gcd(eX, r) + Environment.NewLine;
            }
            if (GCD.gcd(d, r) == 1) {
                temp += "d and r are relatively prime" + Environment.NewLine;
                DandR = true;
            } else {
                temp += "d and r are not relatively prime; gcd(d,r) = " + GCD.gcd(d, r) + Environment.NewLine;
            }

            textboxLog.Text = temp;

            //if all checks for relative primality are true, then show the new groupbox
            if (EandN && DandN && EandR && DandR) {
                groupBox5.Show();
            }

        }

        private void buttonEncDec_Click(object sender, EventArgs e) {
            Prime.encrypt(textboxE, textboxD, textboxN, textBoxMsg, textboxEncDec, checkboxEncDec.Checked);
        }
    }
}
