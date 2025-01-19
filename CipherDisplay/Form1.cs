using CipherProects;
using CipherProjects;

namespace CipherDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaeserEncrypt_Click(object sender, EventArgs e)
        {
            int shift = (int)numericUpDownShift.Value;
            string input = txtCaeserInput.Text;
            string encrypted = CaeserCipher.Encryption(input, shift);
            txtCaeserOutput.Text = encrypted;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaeserDecrypt_Click(object sender, EventArgs e)
        {
            int shift = (int)numericUpDownShift.Value;
            string input = txtCaeserOutput.Text;
            string decrypted = CaeserCipher.Descryptioon(input, shift);
            txtCaeserInput.Text = decrypted;

        }

        private void btnAffineEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtAffineInput.Text;
            int a = (int)numericUpDownA.Value;
            int b = (int)numericUpDownB.Value;
            int m = 26;

            string encrypted = AffineCipher.Encrypt(input.ToLower(), a, b, m);
            txtAffineOutput.Text = encrypted;
        }

        private void btnAffineDecrypt_Click(object sender, EventArgs e)
        {
            string input = txtAffineOutput.Text;
            int a = (int)numericUpDownA.Value;
            int b = (int)numericUpDownB.Value;
            int m = 26;

            string decrypted = AffineCipher.Decrypt(input.ToLower(), a, b, m);
            txtAffineInput.Text = decrypted;
        }

        private void btnHillEncrypt_Click(object sender, EventArgs e)
        {
            int[,] keyMatrix = new int[2, 2]
              {
                    { int.Parse(txtKey11.Text), int.Parse(txtKey12.Text) },
                    { int.Parse(txtKey21.Text), int.Parse(txtKey22.Text) }
              };

            // Create an instance of HillCipher
            HillCipher cipher = new HillCipher(keyMatrix);
            string plaintext = txtHillInput.Text;

            // Encrypt the text
            string ciphertext = cipher.Encrypt(plaintext);
            txtHillOutput.Text = ciphertext;
        }

        private void btnHillDecrypt_Click(object sender, EventArgs e)
        {
            // Parse the key matrix from user input
            int[,] keyMatrix = new int[2, 2]
            {
        { int.Parse(txtKey11.Text), int.Parse(txtKey12.Text) },
        { int.Parse(txtKey21.Text), int.Parse(txtKey22.Text) }
            };

            // Create an instance of HillCipher
            HillCipher cipher = new HillCipher(keyMatrix);
            string ciphertext = txtHillOutput.Text;

            // Decrypt the text
            string plaintext = cipher.Decrypt(ciphertext);
            txtHillInput.Text = plaintext;
        }

        private void tbgHill_Click(object sender, EventArgs e)
        {

        }

        private void btnADFGVXEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtADFGVXKey.Text.Trim();
            string inputText = txtADFGVXInput.Text.Trim();
            ADFGVXCipher adfgvxCipher = new ADFGVXCipher(key);

            string encryptedText = adfgvxCipher.Encrypt(inputText);
            txtADFGVXOutput.Text = encryptedText;
        }

        private void btnADFGVXDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtADFGVXKey.Text.Trim();
            string decryptInputText = txtADFGVXOutput.Text.Trim();
            ADFGVXCipher adfgvxCipher = new ADFGVXCipher(key);

            string decryptedText = adfgvxCipher.Decrypt(decryptInputText);
            txtADFGVXInput.Text = decryptedText;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayfairEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtPlayfairKey.Text;
            string inputText = txtPlayfairInput.Text;

            PlayfairCipher playfair = new PlayfairCipher(key);
            string encryptedText = playfair.Encrypt(inputText);

            txtPlayfairOutput.Text = encryptedText;
        }

        private void btnPlayfairDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtPlayfairKey.Text;
            string inputText = txtPlayfairOutput.Text;

            PlayfairCipher playfair = new PlayfairCipher(key);
            string decryptedText = playfair.Decrypt(inputText);

            txtPlayfairInput.Text = decryptedText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVernamEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtVernamKey.Text;
            string inputText = txtVernamInput.Text;

            VernamCipher vernam = new VernamCipher(key);
            string encryptedText = vernam.Encrypt(inputText);

            txtVernamOutput.Text = encryptedText;
        }

        private void btnVernamDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtVernamKey.Text;
            string inputText = txtVernamOutput.Text;

            VernamCipher vernam = new VernamCipher(key);
            string decryptedText = vernam.Decrypt(inputText);

            txtVernamInput.Text = decryptedText;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnVigenere_Encrypt_Click(object sender, EventArgs e)
        {
            string key = txtVigenereKey.Text;
            string inputText = txtVigenereInput.Text;

            VigenereCipher vigenere = new VigenereCipher(key);
            string encryptedText = vigenere.Encrypt(inputText);

            txtVigenereOutput.Text = encryptedText;
        }

        private void btnVigenere_Decrypt_Click(object sender, EventArgs e)
        {
            string key = txtVigenereKey.Text;
            string inputText = txtVigenereOutput.Text;

            VigenereCipher vigenere = new VigenereCipher(key);
            string decryptedText = vigenere.Decrypt(inputText);

            txtVigenereInput.Text = decryptedText;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnAffineHill_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrixA = {
            { int.Parse(txtAffineHillA11.Text), int.Parse(txtAffineHillA12.Text) },
            { int.Parse(txtAffineHillA21.Text), int.Parse(txtAffineHillA22.Text) }
        };
                int[,] matrixB = Helper.CreateMatrixB(txtAffineHillB1N.Text, txtAffineHillB2N.Text);

                string inputText = txtAffineHillInput.Text;
                AffineHillCipher cipher = new AffineHillCipher();
                string encryptedText = cipher.Encryption(inputText, matrixA, matrixB);

                txtAffineHillOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnAffineHill_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrixA = {
              { int.Parse(txtAffineHillA11.Text), int.Parse(txtAffineHillA12.Text) },
            { int.Parse(txtAffineHillA21.Text), int.Parse(txtAffineHillA22.Text) }
        };
                int[,] matrixB = Helper.CreateMatrixB(txtAffineHillB1N.Text, txtAffineHillB2N.Text);

                string inputText = txtAffineHillOutput.Text;
                AffineHillCipher cipher = new AffineHillCipher();
                string decryptedText = cipher.Decryption(inputText, matrixA, matrixB);

                txtAffineHillInput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnComputeSHA_Click(object sender, EventArgs e)
        {
            string input = txtSHAInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter text to compute hash.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SHA sha = new SHA();
            string hashResult = sha.ComputeSHA512Hash(input);

            txtSHAResult.Text = hashResult;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                SHA sha = new SHA();
                string hashResult = sha.ComputeFileSHA512Hash(filePath);

                txtSHAResult.Text = hashResult;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string text1 = txtText1.Text;
            string text2 = txtText2.Text;

            if (text1 == text2)
            {
                MessageBox.Show("The texts are identical.");
            }
            else
            {
                MessageBox.Show("The texts are different.");
            }
        }
    }
}
