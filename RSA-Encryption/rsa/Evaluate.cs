using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Encryption.rsa {
    public class Evaluate {

        public static int eval(string input) {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToInt32(table.Compute(input, string.Empty));
        }

    }
}
