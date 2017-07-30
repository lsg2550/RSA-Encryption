using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                return output + "*" + temp;
            }
        }

        public static void encrypt(TextBox textboxE, TextBox textboxD, TextBox textboxN, TextBox textboxMsg, TextBox textboxEncDec, bool encOrDec) {
            //Clear Previous Entry
            textboxEncDec.Text = "";

            int k; //Temp
            int e, d, N;

            if (int.TryParse(textboxE.Text, out k) && int.TryParse(textboxD.Text, out k) && int.TryParse(textboxN.Text, out k)) {
                e = int.Parse(textboxE.Text);
                d = int.Parse(textboxD.Text);
                N = int.Parse(textboxN.Text);
            } else {
                e = -1;
                d = -1;
                N = -1;
                textboxMsg.Text = "There was an error in parsing (e, d, N) please check for non-integer characters in those textboxes.";
                return;
            }

            //Message
            string s = textboxMsg.Text;

            int blocksize = 0, max = 255;
            while (max < N && max < MAX_INT) {
                max *= 1001;
                blocksize++;
            }

            // if N<128, decryption of some regular ASCII characters will not work
            // if N<255, decryption of extended ASCII characters will not work
            // allow user to proceed after issuing warning in CheckED
            if (blocksize == 0) {
                blocksize = 1;
            }

            if (encOrDec) { //Enc = True; Start of Encrypt
                string message = "";
                int counter = 0;
                char characterCode;

                while (counter < s.Length) {
                    for (int j = 0; j < blocksize && counter < s.Length; j++) {
                        characterCode = s.ToCharArray()[counter];
                        string temp = "";

                        //Console.WriteLine(t + " is: " + (int)t); //Logging

                        //Add leading 0 as necessary so blocks have uniform size
                        if (characterCode < 100) {
                            temp = "0" + (int)characterCode;
                        }

                        if (!temp.Equals("")) {
                            message += temp;
                        } else {
                            message += (int)characterCode;
                        }

                        counter++;
                    }
                    message += " ";
                }

                //textboxEncDec.Text = message; //Displays the character ASCII codes - Logging

                //Encryption Process
                string encryptedMessage = "", subBlocks;
                counter = 0;

                while (counter < message.Length) {
                    subBlocks = message.Substring(counter, 3 * blocksize);

                    //Remove leading 0 if necessary so C# doesn't get confused when it tries to understand the number
                    while (subBlocks.Substring(0, 1) == "0") {
                        subBlocks = subBlocks.Substring(1, subBlocks.Length - 1);
                    }

                    counter += 1 + (3 * blocksize);
                    encryptedMessage += PowerMod.powerMod(int.Parse(subBlocks), e, N) + " ";
                }

                textboxEncDec.Text = encryptedMessage;
            } else { //Dec = False - Start of Decrypt
                string encryptedMessage = textboxMsg.Text, decryptedASCIIMessage = "", decryptedMessage = "";
                int position = 0, counter = 0;

                while (encryptedMessage.Length > 0) {
                    string encryptedMessageSubBlock = "";
                    position = encryptedMessage.IndexOf(" ");

                    encryptedMessageSubBlock = encryptedMessage.Substring(0, position);

                    counter = 1 + position;

                    encryptedMessage = encryptedMessage.Substring(position + 1, encryptedMessage.Length - position - 1);

                    decryptedASCIIMessage += PowerMod.powerMod(int.Parse(encryptedMessageSubBlock), d, N) + " ";
                }

                //textboxEncDec.Text = decryptedASCIIMessage; //Encrypted to Decrypted ASCII character codes - Logging

                //ASCII Code -> Characters
                encryptedMessage = ""; //Reusing the encryptedMessage object
                counter = 0;
                int width;

                while (decryptedASCIIMessage.Length > 0) {
                    position = decryptedASCIIMessage.IndexOf(" ");
                    encryptedMessage = decryptedASCIIMessage.Substring(0, position);

                    while (encryptedMessage.Length > 0) {
                        if (encryptedMessage.Length % 3 == 0) {
                            width = 3;
                        } else {
                            width = 2;
                        }

                        s = encryptedMessage.Substring(0, width);

                        //Remove leading 0 if necessary so C# doesn't get confused when it tries to understand the number
                        while (s.ToCharArray()[0] == '0') {
                            s = s.Substring(1, s.Length - 1);
                        }

                        decryptedMessage += Convert.ToChar(int.Parse(s)).ToString();
                        encryptedMessage = encryptedMessage.Substring(width, encryptedMessage.Length - position);
                    }

                    counter = 1 + position;
                    decryptedASCIIMessage = decryptedASCIIMessage.Substring(position + 1, decryptedASCIIMessage.Length - position - 1);
                }

                textboxEncDec.Text = decryptedMessage;
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
