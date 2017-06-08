using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption.rsa {
    public class PowerMod {
        public static int powerMod(int x, int p, int N) {
            int A = 1, m = p, t = x; // Compute x^p mod N

            while (m > 0) {
                double k = Math.Floor((double)m / 2);

                int r = (int)(m - (2 * k));

                if (r == 1) {
                    A = (A * t) % N;
                }

                t = (t * t) % N;
                m = (int)k;
            }

            return A;
        }
    }
}
