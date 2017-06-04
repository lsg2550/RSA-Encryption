using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption.rsa {
    public class GCD {
        public static int gcd(int m, int n) {
            if (m < n) {
                return gcd(n, m);
            }

            while (n != 0) {
                int temp = n;
                n = m % n;
                m = temp;
            }

            return m;
        }
    }
}
