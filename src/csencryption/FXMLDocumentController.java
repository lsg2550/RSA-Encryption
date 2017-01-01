package csencryption;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;

public class FXMLDocumentController implements Initializable {

    @FXML
    private TextField pm1, pm2, message, userE, userD;
    @FXML
    private Button genKey, genKey1, encryptT, decryptT, clear, testRP, testPrime;
    @FXML
    private TextArea testArea, puKey, prKey;
    @FXML
    private Label labelE, labelD;

    private int e, d, N, r, K, p, q, encryption, decryption;

    @FXML
    private void genAutoKeys() {
        p = Integer.parseInt(pm1.getText());
        q = Integer.parseInt(pm2.getText());
        if (isPrime(p) == true && isPrime(q) == true) {
            getNr();
            genAuto();
        } else {
            puKey.setText("You must have changed the values of one of the prime numbers to a non-prime number.");
        }
    }

    private void genAuto() {
        for (int i = 2; i <= r; i++) {
            if (gcd(i, r) == 1) {
                e = i;
                break;
            }
        }
        for (int i = 2; i <= r; i++) {
            if (e * i % r == 1 && e != i) {
                d = i;
                break;
            }
        }

        puKey.setText("(" + e + ", " + N + ")");
        prKey.setText("(" + d + ", " + N + ")");
    }

    @FXML
    private void generateKEYS() {
        puKey.setText("(" + e + ", " + N + ")");
        prKey.setText("(" + d + ", " + N + ")");
    }

    @FXML
    private void testRP() {
        try {
            getNr();
            int tempE = Integer.parseInt(userE.getText());
            int tempD = Integer.parseInt(userD.getText());

            if (gcd(tempE, r) == 1 && (tempE * tempD % r == 1) && e != tempD) {
                e = tempE;
                d = tempD;
                puKey.setText("e and d are relatively prime to " + r + ", please select Generate Keys.");
                genKey1.setVisible(true);
            } else if (gcd(tempE, r) != 1 || (tempE * tempD % r == 1) && e != tempD) {
                puKey.setText("e is not relatively prime to " + r + ".");
            } else if (gcd(tempE, r) == 1 && (tempE * tempD % r != 1) && e != tempD) {
                puKey.setText("d is not relatively prime to " + r + ".");
            }
        } catch (Exception ex) {
            puKey.setText("One of the textfields are not filled.");
        }
    }

    @FXML
    private void gen_pq() {
        try {
            p = Integer.parseInt(pm1.getText());
            q = Integer.parseInt(pm2.getText());

            puKey.wrapTextProperty().setValue(Boolean.TRUE);
            prKey.wrapTextProperty().setValue(Boolean.TRUE);

            if (isPrime(p) == true && isPrime(q) == true) {
                genKey.setVisible(true);
                labelE.setVisible(true);
                labelD.setVisible(true);
                userE.setVisible(true);
                userD.setVisible(true);
                testRP.setVisible(true);
                puKey.setText("Both p and q are prime, to auto-generate your keys, please select Auto-Gen Keys. "
                        + "\n\nTo use your own values of e and d, please enter numbers that are relatively prime to " + (p - 1) * (q - 1) + ".");
                prKey.setText("");
            } else if (isPrime(p) == true && isPrime(q) == false) {
                puKey.setText("");
                prKey.setText("q is not a prime number (TextField over Private Key TextArea)");
            } else if (isPrime(p) == false && isPrime(q) == true) {
                puKey.setText("p is not a prime number (TextField over Public Key TextArea)");
                prKey.setText("");
            } else if (isPrime(p) == false && isPrime(q) == false) {
                puKey.setText("p and q are not prime numbers");
                prKey.setText("");
            }
        } catch (Exception ex) {
            puKey.setText("One of the textfields are not filled.");
        }
    }

    @FXML
    private void Encrypt() {
        int temp = powerMod(Integer.parseInt(message.getText()), e, N);
        encryption = temp;

        testArea.appendText("Encryption: " + temp + "\n");
    }

    @FXML
    private void Decrypt() {
        int temp = powerMod(encryption, d, N);

        testArea.appendText("Decryption: " + temp + "\n");
    }

    @FXML
    private void clear() {
        testArea.clear();
    }

    private void getNr() {
        N = p * q;
        r = (p - 1) * (q - 1);
    }

    private boolean isPrime(int n) {
        if (n % 2 == 0) {
            return false;
        }
        for (int i = 3; i * i <= n; i += 2) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    private int mod(int m, int n) {
        try {
            return (int) (m - n * Math.floor(m / n));
        } catch (Exception ex) {
            return (int) (n - m * Math.floor(n / m));
        }
    }

    private int gcd(int m, int n) {
        while (m != n) {
            if (m == 1 || n == 1) {
                return 1;
            } else if (m < n) {
                n = mod(n, m);
            } else {
                m = mod(m, n);
            }
        }
        return m;
    }

    private int powerMod(int x, int p, int N) {
        int A = 1;
        int m = p;
        int t = x;

        while (m > 0) {
            int k = ((int) Math.floor(m / 2));
            r = m - 2 * k;
            if (r == 1) {
                A = mod(A * t, N);
            }
            t = mod(t * t, N);
            m = k;
        }
        return A;
    }

    @Override
    public void initialize(URL url, ResourceBundle rb) {
    }
}
