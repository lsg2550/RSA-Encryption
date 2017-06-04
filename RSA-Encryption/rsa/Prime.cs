using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption.rsa {
    public class Prime {

        private static int MAX_INT;

        public static void init() {
            MAX_INT = maxInt();
        }

        public static bool isPrime(int num) {
            int temp = num, prime = 1;

            if (num > MAX_INT) {
                return false;
            }
            if (num <= 1) {
                return false;
            }

            int i = 1;
            while ((temp > 1) && (++i <= Math.Sqrt(num))) {
                while (temp % i == 0) {
                    temp /= i;

                    if (prime == 1) {
                        prime = 0;
                    }
                }
            }

            if (prime == 1) {
                return true;
            } else {
                return false;
            }
        }

        public static string getFactors(int num) {
            int temp = num, prime = 1;
            string output = "";

            if (num > MAX_INT) {
                return "";
            }
            if (num <= 1) {
                return "";
            }

            int i = 1;
            while ((temp > 1) && (++i <= Math.Sqrt(num))) {
                while (temp % i == 0) {
                    temp /= i;

                    if (prime == 0) {
                        output += "*";
                    }
                    if (prime == 1) {
                        prime = 0;
                    }

                    output += i;
                }
            }

            if (prime == 1) {
                return "";
            } else {
                return output;
            }
        }

        public static string getCandidates(int textboxR) {
            string temp = "", line = "";
            int r = textboxR, n = r + 1;

            int counter = 0;
            while (counter < 30 && n < MAX_INT) {
                if (line.Length > 50) {
                    temp += line + Environment.NewLine;
                    line = "";
                }

                line += n + " ";
                n = n + r;
                counter++;
            }

            return temp + line;
        }

        private static int maxInt() {
            int bits = 1, prev = 0, sumM1 = 1, sum = 2;

            while (sumM1 < sum) {
                bits++;
                prev = sum;
                sumM1 += sum;
                sum = sumM1 + 1;
            }

            int MAX_INT = prev - 1;
            return MAX_INT;
        }

        public static int getMaxInt {
            get {
                return MAX_INT;
            }
        }

        public static string toString() {
            return "MAX INT: " + getMaxInt; //Logging;
        }
    }
}
