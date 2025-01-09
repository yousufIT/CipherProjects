
namespace CipherDisplay
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tbgCaeser = new TabPage();
            label1 = new Label();
            numericUpDownShift = new NumericUpDown();
            lblCaeserInput = new Label();
            txtCaeserInput = new TextBox();
            lblCaeserOutput = new Label();
            txtCaeserOutput = new TextBox();
            btnCaeserEncrypt = new Button();
            btnCaeserDecrypt = new Button();
            tbgAffine = new TabPage();
            numericUpDownB = new NumericUpDown();
            numericUpDownA = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            lblAffineInput = new Label();
            txtAffineInput = new TextBox();
            lblAffineOutput = new Label();
            txtAffineOutput = new TextBox();
            btnAffineEncrypt = new Button();
            btnAffineDecrypt = new Button();
            tbgHill = new TabPage();
            label6 = new Label();
            txtKey12 = new TextBox();
            label7 = new Label();
            txtKey22 = new TextBox();
            label4 = new Label();
            txtKey11 = new TextBox();
            label5 = new Label();
            txtKey21 = new TextBox();
            lblHillInput = new Label();
            txtHillInput = new TextBox();
            lblHillOutput = new Label();
            txtHillOutput = new TextBox();
            btnHillEncrypt = new Button();
            btnHillDecrypt = new Button();
            tbgAffineHill = new TabPage();
            txtAffineHillB2N = new TextBox();
            btnAffineHill_Decrypt = new Button();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtAffineHillB1N = new TextBox();
            txtAffineHillA22 = new TextBox();
            txtAffineHillA21 = new TextBox();
            txtAffineHillA12 = new TextBox();
            txtAffineHillA11 = new TextBox();
            txtAffineHillOutput = new TextBox();
            btnAffineHill_Encrypt = new Button();
            label14 = new Label();
            txtAffineHillInput = new TextBox();
            tbgADFGVX = new TabPage();
            label8 = new Label();
            txtADFGVXKey = new TextBox();
            lblADFGVXInput = new Label();
            txtADFGVXInput = new TextBox();
            lblADFGVXOutput = new Label();
            txtADFGVXOutput = new TextBox();
            btnADFGVXEncrypt = new Button();
            btnADFGVXDecrypt = new Button();
            tbgPlayfair = new TabPage();
            label9 = new Label();
            txtPlayfairKey = new TextBox();
            lblPlayfairInput = new Label();
            txtPlayfairInput = new TextBox();
            lblPlayfairOutput = new Label();
            txtPlayfairOutput = new TextBox();
            btnPlayfairEncrypt = new Button();
            btnPlayfairDecrypt = new Button();
            tbgVernam = new TabPage();
            label10 = new Label();
            txtVernamKey = new TextBox();
            lblVernamInput = new Label();
            txtVernamInput = new TextBox();
            lblVernamOutput = new Label();
            txtVernamOutput = new TextBox();
            btnVernamEncrypt = new Button();
            btnVernamDecrypt = new Button();
            tbgVigenere = new TabPage();
            txtVigenereKey = new TextBox();
            txtVigenereOutput = new TextBox();
            txtVigenereInput = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnVigenere_Decrypt = new Button();
            btnVigenere_Encrypt = new Button();
            tbSHA = new TabPage();
            label25 = new Label();
            lblSHA = new Label();
            txtSHAResult = new TextBox();
            txtSHAInput = new TextBox();
            btnSelectFile = new Button();
            btnComputeSHA = new Button();
            tabControl1.SuspendLayout();
            tbgCaeser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShift).BeginInit();
            tbgAffine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            tbgHill.SuspendLayout();
            tbgAffineHill.SuspendLayout();
            tbgADFGVX.SuspendLayout();
            tbgPlayfair.SuspendLayout();
            tbgVernam.SuspendLayout();
            tbgVigenere.SuspendLayout();
            tbSHA.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbgCaeser);
            tabControl1.Controls.Add(tbgAffine);
            tabControl1.Controls.Add(tbgHill);
            tabControl1.Controls.Add(tbgAffineHill);
            tabControl1.Controls.Add(tbgADFGVX);
            tabControl1.Controls.Add(tbgPlayfair);
            tabControl1.Controls.Add(tbgVernam);
            tabControl1.Controls.Add(tbgVigenere);
            tabControl1.Controls.Add(tbSHA);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(952, 489);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // tbgCaeser
            // 
            tbgCaeser.Controls.Add(label1);
            tbgCaeser.Controls.Add(numericUpDownShift);
            tbgCaeser.Controls.Add(lblCaeserInput);
            tbgCaeser.Controls.Add(txtCaeserInput);
            tbgCaeser.Controls.Add(lblCaeserOutput);
            tbgCaeser.Controls.Add(txtCaeserOutput);
            tbgCaeser.Controls.Add(btnCaeserEncrypt);
            tbgCaeser.Controls.Add(btnCaeserDecrypt);
            tbgCaeser.Location = new Point(4, 29);
            tbgCaeser.Name = "tbgCaeser";
            tbgCaeser.Padding = new Padding(3);
            tbgCaeser.Size = new Size(944, 456);
            tbgCaeser.TabIndex = 0;
            tbgCaeser.Text = "CaeserCipher";
            tbgCaeser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 23);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 7;
            label1.Text = "k :";
            label1.Click += label1_Click;
            // 
            // numericUpDownShift
            // 
            numericUpDownShift.Location = new Point(600, 21);
            numericUpDownShift.Name = "numericUpDownShift";
            numericUpDownShift.Size = new Size(150, 27);
            numericUpDownShift.TabIndex = 6;
            // 
            // lblCaeserInput
            // 
            lblCaeserInput.AutoSize = true;
            lblCaeserInput.Location = new Point(23, 23);
            lblCaeserInput.Name = "lblCaeserInput";
            lblCaeserInput.Size = new Size(113, 20);
            lblCaeserInput.TabIndex = 0;
            lblCaeserInput.Text = "Encryption Text:";
            // 
            // txtCaeserInput
            // 
            txtCaeserInput.Location = new Point(150, 20);
            txtCaeserInput.Name = "txtCaeserInput";
            txtCaeserInput.Size = new Size(415, 27);
            txtCaeserInput.TabIndex = 1;
            // 
            // lblCaeserOutput
            // 
            lblCaeserOutput.AutoSize = true;
            lblCaeserOutput.Location = new Point(23, 63);
            lblCaeserOutput.Name = "lblCaeserOutput";
            lblCaeserOutput.Size = new Size(116, 20);
            lblCaeserOutput.TabIndex = 2;
            lblCaeserOutput.Text = "Decryption Text:";
            // 
            // txtCaeserOutput
            // 
            txtCaeserOutput.Location = new Point(150, 60);
            txtCaeserOutput.Name = "txtCaeserOutput";
            txtCaeserOutput.Size = new Size(600, 27);
            txtCaeserOutput.TabIndex = 3;
            // 
            // btnCaeserEncrypt
            // 
            btnCaeserEncrypt.Location = new Point(150, 100);
            btnCaeserEncrypt.Name = "btnCaeserEncrypt";
            btnCaeserEncrypt.Size = new Size(120, 30);
            btnCaeserEncrypt.TabIndex = 4;
            btnCaeserEncrypt.Text = "Encrypt";
            btnCaeserEncrypt.UseVisualStyleBackColor = true;
            btnCaeserEncrypt.Click += btnCaeserEncrypt_Click;
            // 
            // btnCaeserDecrypt
            // 
            btnCaeserDecrypt.Location = new Point(280, 100);
            btnCaeserDecrypt.Name = "btnCaeserDecrypt";
            btnCaeserDecrypt.Size = new Size(120, 30);
            btnCaeserDecrypt.TabIndex = 5;
            btnCaeserDecrypt.Text = "Decrypt";
            btnCaeserDecrypt.UseVisualStyleBackColor = true;
            btnCaeserDecrypt.Click += btnCaeserDecrypt_Click;
            // 
            // tbgAffine
            // 
            tbgAffine.Controls.Add(numericUpDownB);
            tbgAffine.Controls.Add(numericUpDownA);
            tbgAffine.Controls.Add(label3);
            tbgAffine.Controls.Add(label2);
            tbgAffine.Controls.Add(lblAffineInput);
            tbgAffine.Controls.Add(txtAffineInput);
            tbgAffine.Controls.Add(lblAffineOutput);
            tbgAffine.Controls.Add(txtAffineOutput);
            tbgAffine.Controls.Add(btnAffineEncrypt);
            tbgAffine.Controls.Add(btnAffineDecrypt);
            tbgAffine.Location = new Point(4, 29);
            tbgAffine.Name = "tbgAffine";
            tbgAffine.Size = new Size(944, 456);
            tbgAffine.TabIndex = 1;
            tbgAffine.Text = "AffineCipher";
            tbgAffine.UseVisualStyleBackColor = true;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(651, 61);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(150, 27);
            numericUpDownB.TabIndex = 9;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(651, 21);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(150, 27);
            numericUpDownA.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 20);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 7;
            label3.Text = "a :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 60);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "b :";
            // 
            // lblAffineInput
            // 
            lblAffineInput.AutoSize = true;
            lblAffineInput.Location = new Point(20, 20);
            lblAffineInput.Name = "lblAffineInput";
            lblAffineInput.Size = new Size(113, 20);
            lblAffineInput.TabIndex = 0;
            lblAffineInput.Text = "Encryption Text:";
            // 
            // txtAffineInput
            // 
            txtAffineInput.Location = new Point(149, 20);
            txtAffineInput.Name = "txtAffineInput";
            txtAffineInput.Size = new Size(415, 27);
            txtAffineInput.TabIndex = 1;
            // 
            // lblAffineOutput
            // 
            lblAffineOutput.AutoSize = true;
            lblAffineOutput.Location = new Point(20, 60);
            lblAffineOutput.Name = "lblAffineOutput";
            lblAffineOutput.Size = new Size(116, 20);
            lblAffineOutput.TabIndex = 2;
            lblAffineOutput.Text = "Decryption Text:";
            // 
            // txtAffineOutput
            // 
            txtAffineOutput.Location = new Point(149, 60);
            txtAffineOutput.Name = "txtAffineOutput";
            txtAffineOutput.Size = new Size(415, 27);
            txtAffineOutput.TabIndex = 3;
            // 
            // btnAffineEncrypt
            // 
            btnAffineEncrypt.Location = new Point(149, 100);
            btnAffineEncrypt.Name = "btnAffineEncrypt";
            btnAffineEncrypt.Size = new Size(120, 30);
            btnAffineEncrypt.TabIndex = 4;
            btnAffineEncrypt.Text = "Encrypt";
            btnAffineEncrypt.UseVisualStyleBackColor = true;
            btnAffineEncrypt.Click += btnAffineEncrypt_Click;
            // 
            // btnAffineDecrypt
            // 
            btnAffineDecrypt.Location = new Point(279, 100);
            btnAffineDecrypt.Name = "btnAffineDecrypt";
            btnAffineDecrypt.Size = new Size(120, 30);
            btnAffineDecrypt.TabIndex = 5;
            btnAffineDecrypt.Text = "Decrypt";
            btnAffineDecrypt.UseVisualStyleBackColor = true;
            btnAffineDecrypt.Click += btnAffineDecrypt_Click;
            // 
            // tbgHill
            // 
            tbgHill.Controls.Add(label6);
            tbgHill.Controls.Add(txtKey12);
            tbgHill.Controls.Add(label7);
            tbgHill.Controls.Add(txtKey22);
            tbgHill.Controls.Add(label4);
            tbgHill.Controls.Add(txtKey11);
            tbgHill.Controls.Add(label5);
            tbgHill.Controls.Add(txtKey21);
            tbgHill.Controls.Add(lblHillInput);
            tbgHill.Controls.Add(txtHillInput);
            tbgHill.Controls.Add(lblHillOutput);
            tbgHill.Controls.Add(txtHillOutput);
            tbgHill.Controls.Add(btnHillEncrypt);
            tbgHill.Controls.Add(btnHillDecrypt);
            tbgHill.Location = new Point(4, 29);
            tbgHill.Name = "tbgHill";
            tbgHill.Size = new Size(944, 456);
            tbgHill.TabIndex = 2;
            tbgHill.Text = "HillCipher";
            tbgHill.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 105);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 10;
            label6.Text = "[1,2] :";
            // 
            // txtKey12
            // 
            txtKey12.Location = new Point(475, 105);
            txtKey12.Name = "txtKey12";
            txtKey12.Size = new Size(208, 27);
            txtKey12.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 145);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 12;
            label7.Text = "[2,2] :";
            // 
            // txtKey22
            // 
            txtKey22.Location = new Point(475, 145);
            txtKey22.Name = "txtKey22";
            txtKey22.Size = new Size(208, 27);
            txtKey22.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 105);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "[1,1] :";
            // 
            // txtKey11
            // 
            txtKey11.Location = new Point(130, 105);
            txtKey11.Name = "txtKey11";
            txtKey11.Size = new Size(208, 27);
            txtKey11.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 145);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 8;
            label5.Text = "[2,1] :";
            // 
            // txtKey21
            // 
            txtKey21.Location = new Point(130, 145);
            txtKey21.Name = "txtKey21";
            txtKey21.Size = new Size(208, 27);
            txtKey21.TabIndex = 9;
            // 
            // lblHillInput
            // 
            lblHillInput.AutoSize = true;
            lblHillInput.Location = new Point(20, 20);
            lblHillInput.Name = "lblHillInput";
            lblHillInput.Size = new Size(113, 20);
            lblHillInput.TabIndex = 0;
            lblHillInput.Text = "Encryption Text:";
            // 
            // txtHillInput
            // 
            txtHillInput.Location = new Point(154, 20);
            txtHillInput.Name = "txtHillInput";
            txtHillInput.Size = new Size(600, 27);
            txtHillInput.TabIndex = 1;
            // 
            // lblHillOutput
            // 
            lblHillOutput.AutoSize = true;
            lblHillOutput.Location = new Point(20, 60);
            lblHillOutput.Name = "lblHillOutput";
            lblHillOutput.Size = new Size(116, 20);
            lblHillOutput.TabIndex = 2;
            lblHillOutput.Text = "Decryption Text:";
            // 
            // txtHillOutput
            // 
            txtHillOutput.Location = new Point(154, 60);
            txtHillOutput.Name = "txtHillOutput";
            txtHillOutput.Size = new Size(600, 27);
            txtHillOutput.TabIndex = 3;
            // 
            // btnHillEncrypt
            // 
            btnHillEncrypt.Location = new Point(269, 221);
            btnHillEncrypt.Name = "btnHillEncrypt";
            btnHillEncrypt.Size = new Size(120, 30);
            btnHillEncrypt.TabIndex = 4;
            btnHillEncrypt.Text = "Encrypt";
            btnHillEncrypt.UseVisualStyleBackColor = true;
            btnHillEncrypt.Click += btnHillEncrypt_Click;
            // 
            // btnHillDecrypt
            // 
            btnHillDecrypt.Location = new Point(399, 221);
            btnHillDecrypt.Name = "btnHillDecrypt";
            btnHillDecrypt.Size = new Size(120, 30);
            btnHillDecrypt.TabIndex = 5;
            btnHillDecrypt.Text = "Decrypt";
            btnHillDecrypt.UseVisualStyleBackColor = true;
            btnHillDecrypt.Click += btnHillDecrypt_Click;
            // 
            // tbgAffineHill
            // 
            tbgAffineHill.Controls.Add(txtAffineHillB2N);
            tbgAffineHill.Controls.Add(btnAffineHill_Decrypt);
            tbgAffineHill.Controls.Add(label22);
            tbgAffineHill.Controls.Add(label20);
            tbgAffineHill.Controls.Add(label19);
            tbgAffineHill.Controls.Add(label18);
            tbgAffineHill.Controls.Add(label17);
            tbgAffineHill.Controls.Add(label16);
            tbgAffineHill.Controls.Add(label15);
            tbgAffineHill.Controls.Add(txtAffineHillB1N);
            tbgAffineHill.Controls.Add(txtAffineHillA22);
            tbgAffineHill.Controls.Add(txtAffineHillA21);
            tbgAffineHill.Controls.Add(txtAffineHillA12);
            tbgAffineHill.Controls.Add(txtAffineHillA11);
            tbgAffineHill.Controls.Add(txtAffineHillOutput);
            tbgAffineHill.Controls.Add(btnAffineHill_Encrypt);
            tbgAffineHill.Controls.Add(label14);
            tbgAffineHill.Controls.Add(txtAffineHillInput);
            tbgAffineHill.Location = new Point(4, 29);
            tbgAffineHill.Name = "tbgAffineHill";
            tbgAffineHill.Size = new Size(944, 456);
            tbgAffineHill.TabIndex = 7;
            tbgAffineHill.Text = "Affine&HillCipher";
            tbgAffineHill.UseVisualStyleBackColor = true;
            // 
            // txtAffineHillB2N
            // 
            txtAffineHillB2N.Location = new Point(503, 189);
            txtAffineHillB2N.Name = "txtAffineHillB2N";
            txtAffineHillB2N.Size = new Size(125, 27);
            txtAffineHillB2N.TabIndex = 22;
            // 
            // btnAffineHill_Decrypt
            // 
            btnAffineHill_Decrypt.Location = new Point(453, 260);
            btnAffineHill_Decrypt.Name = "btnAffineHill_Decrypt";
            btnAffineHill_Decrypt.Size = new Size(120, 29);
            btnAffineHill_Decrypt.TabIndex = 21;
            btnAffineHill_Decrypt.Text = "Decrypt";
            btnAffineHill_Decrypt.UseVisualStyleBackColor = true;
            btnAffineHill_Decrypt.Click += btnAffineHill_Decrypt_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(438, 189);
            label22.Name = "label22";
            label22.Size = new Size(26, 20);
            label22.TabIndex = 19;
            label22.Text = "B2";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(438, 120);
            label20.Name = "label20";
            label20.Size = new Size(26, 20);
            label20.TabIndex = 17;
            label20.Text = "B1";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(215, 188);
            label19.Name = "label19";
            label19.Size = new Size(35, 20);
            label19.TabIndex = 16;
            label19.Text = "A22";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 185);
            label18.Name = "label18";
            label18.Size = new Size(35, 20);
            label18.TabIndex = 15;
            label18.Text = "A21";
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(215, 119);
            label17.Name = "label17";
            label17.Size = new Size(35, 20);
            label17.TabIndex = 14;
            label17.Text = "A12";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 116);
            label16.Name = "label16";
            label16.Size = new Size(35, 20);
            label16.TabIndex = 13;
            label16.Text = "A11";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 60);
            label15.Name = "label15";
            label15.Size = new Size(116, 20);
            label15.TabIndex = 12;
            label15.Text = "Decryption Text:";
            // 
            // txtAffineHillB1N
            // 
            txtAffineHillB1N.Location = new Point(503, 117);
            txtAffineHillB1N.Name = "txtAffineHillB1N";
            txtAffineHillB1N.Size = new Size(125, 27);
            txtAffineHillB1N.TabIndex = 8;
            // 
            // txtAffineHillA22
            // 
            txtAffineHillA22.Location = new Point(276, 185);
            txtAffineHillA22.Name = "txtAffineHillA22";
            txtAffineHillA22.Size = new Size(125, 27);
            txtAffineHillA22.TabIndex = 7;
            // 
            // txtAffineHillA21
            // 
            txtAffineHillA21.Location = new Point(77, 185);
            txtAffineHillA21.Name = "txtAffineHillA21";
            txtAffineHillA21.Size = new Size(125, 27);
            txtAffineHillA21.TabIndex = 6;
            // 
            // txtAffineHillA12
            // 
            txtAffineHillA12.Location = new Point(276, 116);
            txtAffineHillA12.Name = "txtAffineHillA12";
            txtAffineHillA12.Size = new Size(125, 27);
            txtAffineHillA12.TabIndex = 5;
            // 
            // txtAffineHillA11
            // 
            txtAffineHillA11.Location = new Point(77, 116);
            txtAffineHillA11.Name = "txtAffineHillA11";
            txtAffineHillA11.Size = new Size(125, 27);
            txtAffineHillA11.TabIndex = 4;
            // 
            // txtAffineHillOutput
            // 
            txtAffineHillOutput.Location = new Point(153, 60);
            txtAffineHillOutput.Name = "txtAffineHillOutput";
            txtAffineHillOutput.Size = new Size(600, 27);
            txtAffineHillOutput.TabIndex = 3;
            // 
            // btnAffineHill_Encrypt
            // 
            btnAffineHill_Encrypt.Location = new Point(304, 260);
            btnAffineHill_Encrypt.Name = "btnAffineHill_Encrypt";
            btnAffineHill_Encrypt.Size = new Size(120, 29);
            btnAffineHill_Encrypt.TabIndex = 2;
            btnAffineHill_Encrypt.Text = "Encrypt";
            btnAffineHill_Encrypt.UseVisualStyleBackColor = true;
            btnAffineHill_Encrypt.Click += btnAffineHill_Encrypt_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 20);
            label14.Name = "label14";
            label14.Size = new Size(113, 20);
            label14.TabIndex = 1;
            label14.Text = "Encryption Text:";
            // 
            // txtAffineHillInput
            // 
            txtAffineHillInput.Location = new Point(153, 20);
            txtAffineHillInput.Name = "txtAffineHillInput";
            txtAffineHillInput.Size = new Size(600, 27);
            txtAffineHillInput.TabIndex = 0;
            // 
            // tbgADFGVX
            // 
            tbgADFGVX.Controls.Add(label8);
            tbgADFGVX.Controls.Add(txtADFGVXKey);
            tbgADFGVX.Controls.Add(lblADFGVXInput);
            tbgADFGVX.Controls.Add(txtADFGVXInput);
            tbgADFGVX.Controls.Add(lblADFGVXOutput);
            tbgADFGVX.Controls.Add(txtADFGVXOutput);
            tbgADFGVX.Controls.Add(btnADFGVXEncrypt);
            tbgADFGVX.Controls.Add(btnADFGVXDecrypt);
            tbgADFGVX.Location = new Point(4, 29);
            tbgADFGVX.Name = "tbgADFGVX";
            tbgADFGVX.Size = new Size(944, 456);
            tbgADFGVX.TabIndex = 3;
            tbgADFGVX.Text = "ADFGVXCipher";
            tbgADFGVX.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(485, 20);
            label8.Name = "label8";
            label8.Size = new Size(23, 20);
            label8.TabIndex = 6;
            label8.Text = "k :";
            // 
            // txtADFGVXKey
            // 
            txtADFGVXKey.Location = new Point(542, 20);
            txtADFGVXKey.Name = "txtADFGVXKey";
            txtADFGVXKey.Size = new Size(206, 27);
            txtADFGVXKey.TabIndex = 7;
            // 
            // lblADFGVXInput
            // 
            lblADFGVXInput.AutoSize = true;
            lblADFGVXInput.Location = new Point(20, 20);
            lblADFGVXInput.Name = "lblADFGVXInput";
            lblADFGVXInput.Size = new Size(113, 20);
            lblADFGVXInput.TabIndex = 0;
            lblADFGVXInput.Text = "Encryption Text:";
            // 
            // txtADFGVXInput
            // 
            txtADFGVXInput.Location = new Point(148, 20);
            txtADFGVXInput.Name = "txtADFGVXInput";
            txtADFGVXInput.Size = new Size(331, 27);
            txtADFGVXInput.TabIndex = 1;
            // 
            // lblADFGVXOutput
            // 
            lblADFGVXOutput.AutoSize = true;
            lblADFGVXOutput.Location = new Point(20, 60);
            lblADFGVXOutput.Name = "lblADFGVXOutput";
            lblADFGVXOutput.Size = new Size(116, 20);
            lblADFGVXOutput.TabIndex = 2;
            lblADFGVXOutput.Text = "Decryption Text:";
            // 
            // txtADFGVXOutput
            // 
            txtADFGVXOutput.Location = new Point(148, 60);
            txtADFGVXOutput.Name = "txtADFGVXOutput";
            txtADFGVXOutput.Size = new Size(600, 27);
            txtADFGVXOutput.TabIndex = 3;
            // 
            // btnADFGVXEncrypt
            // 
            btnADFGVXEncrypt.Location = new Point(148, 100);
            btnADFGVXEncrypt.Name = "btnADFGVXEncrypt";
            btnADFGVXEncrypt.Size = new Size(120, 30);
            btnADFGVXEncrypt.TabIndex = 4;
            btnADFGVXEncrypt.Text = "Encrypt";
            btnADFGVXEncrypt.UseVisualStyleBackColor = true;
            btnADFGVXEncrypt.Click += btnADFGVXEncrypt_Click;
            // 
            // btnADFGVXDecrypt
            // 
            btnADFGVXDecrypt.Location = new Point(278, 100);
            btnADFGVXDecrypt.Name = "btnADFGVXDecrypt";
            btnADFGVXDecrypt.Size = new Size(120, 30);
            btnADFGVXDecrypt.TabIndex = 5;
            btnADFGVXDecrypt.Text = "Decrypt";
            btnADFGVXDecrypt.UseVisualStyleBackColor = true;
            btnADFGVXDecrypt.Click += btnADFGVXDecrypt_Click;
            // 
            // tbgPlayfair
            // 
            tbgPlayfair.Controls.Add(label9);
            tbgPlayfair.Controls.Add(txtPlayfairKey);
            tbgPlayfair.Controls.Add(lblPlayfairInput);
            tbgPlayfair.Controls.Add(txtPlayfairInput);
            tbgPlayfair.Controls.Add(lblPlayfairOutput);
            tbgPlayfair.Controls.Add(txtPlayfairOutput);
            tbgPlayfair.Controls.Add(btnPlayfairEncrypt);
            tbgPlayfair.Controls.Add(btnPlayfairDecrypt);
            tbgPlayfair.Location = new Point(4, 29);
            tbgPlayfair.Name = "tbgPlayfair";
            tbgPlayfair.Size = new Size(944, 456);
            tbgPlayfair.TabIndex = 4;
            tbgPlayfair.Text = "PlayfairCipher";
            tbgPlayfair.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(505, 20);
            label9.Name = "label9";
            label9.Size = new Size(23, 20);
            label9.TabIndex = 6;
            label9.Text = "k :";
            label9.Click += label9_Click;
            // 
            // txtPlayfairKey
            // 
            txtPlayfairKey.Location = new Point(564, 20);
            txtPlayfairKey.Name = "txtPlayfairKey";
            txtPlayfairKey.Size = new Size(191, 27);
            txtPlayfairKey.TabIndex = 7;
            // 
            // lblPlayfairInput
            // 
            lblPlayfairInput.AutoSize = true;
            lblPlayfairInput.Location = new Point(20, 20);
            lblPlayfairInput.Name = "lblPlayfairInput";
            lblPlayfairInput.Size = new Size(113, 20);
            lblPlayfairInput.TabIndex = 0;
            lblPlayfairInput.Text = "Encryption Text:";
            // 
            // txtPlayfairInput
            // 
            txtPlayfairInput.Location = new Point(155, 20);
            txtPlayfairInput.Name = "txtPlayfairInput";
            txtPlayfairInput.Size = new Size(344, 27);
            txtPlayfairInput.TabIndex = 1;
            // 
            // lblPlayfairOutput
            // 
            lblPlayfairOutput.AutoSize = true;
            lblPlayfairOutput.Location = new Point(20, 60);
            lblPlayfairOutput.Name = "lblPlayfairOutput";
            lblPlayfairOutput.Size = new Size(116, 20);
            lblPlayfairOutput.TabIndex = 2;
            lblPlayfairOutput.Text = "Decryption Text:";
            // 
            // txtPlayfairOutput
            // 
            txtPlayfairOutput.Location = new Point(155, 60);
            txtPlayfairOutput.Name = "txtPlayfairOutput";
            txtPlayfairOutput.Size = new Size(600, 27);
            txtPlayfairOutput.TabIndex = 3;
            // 
            // btnPlayfairEncrypt
            // 
            btnPlayfairEncrypt.Location = new Point(155, 100);
            btnPlayfairEncrypt.Name = "btnPlayfairEncrypt";
            btnPlayfairEncrypt.Size = new Size(120, 30);
            btnPlayfairEncrypt.TabIndex = 4;
            btnPlayfairEncrypt.Text = "Encrypt";
            btnPlayfairEncrypt.UseVisualStyleBackColor = true;
            btnPlayfairEncrypt.Click += btnPlayfairEncrypt_Click;
            // 
            // btnPlayfairDecrypt
            // 
            btnPlayfairDecrypt.Location = new Point(285, 100);
            btnPlayfairDecrypt.Name = "btnPlayfairDecrypt";
            btnPlayfairDecrypt.Size = new Size(120, 30);
            btnPlayfairDecrypt.TabIndex = 5;
            btnPlayfairDecrypt.Text = "Decrypt";
            btnPlayfairDecrypt.UseVisualStyleBackColor = true;
            btnPlayfairDecrypt.Click += btnPlayfairDecrypt_Click;
            // 
            // tbgVernam
            // 
            tbgVernam.Controls.Add(label10);
            tbgVernam.Controls.Add(txtVernamKey);
            tbgVernam.Controls.Add(lblVernamInput);
            tbgVernam.Controls.Add(txtVernamInput);
            tbgVernam.Controls.Add(lblVernamOutput);
            tbgVernam.Controls.Add(txtVernamOutput);
            tbgVernam.Controls.Add(btnVernamEncrypt);
            tbgVernam.Controls.Add(btnVernamDecrypt);
            tbgVernam.Location = new Point(4, 29);
            tbgVernam.Name = "tbgVernam";
            tbgVernam.Size = new Size(944, 456);
            tbgVernam.TabIndex = 5;
            tbgVernam.Text = "VernamCipher";
            tbgVernam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(535, 20);
            label10.Name = "label10";
            label10.Size = new Size(23, 20);
            label10.TabIndex = 6;
            label10.Text = "k :";
            label10.Click += label10_Click;
            // 
            // txtVernamKey
            // 
            txtVernamKey.Location = new Point(592, 17);
            txtVernamKey.Name = "txtVernamKey";
            txtVernamKey.Size = new Size(166, 27);
            txtVernamKey.TabIndex = 7;
            txtVernamKey.TextChanged += textBox1_TextChanged;
            // 
            // lblVernamInput
            // 
            lblVernamInput.AutoSize = true;
            lblVernamInput.Location = new Point(20, 20);
            lblVernamInput.Name = "lblVernamInput";
            lblVernamInput.Size = new Size(113, 20);
            lblVernamInput.TabIndex = 0;
            lblVernamInput.Text = "Encryption Text:";
            // 
            // txtVernamInput
            // 
            txtVernamInput.Location = new Point(158, 20);
            txtVernamInput.Name = "txtVernamInput";
            txtVernamInput.Size = new Size(371, 27);
            txtVernamInput.TabIndex = 1;
            // 
            // lblVernamOutput
            // 
            lblVernamOutput.AutoSize = true;
            lblVernamOutput.Location = new Point(20, 60);
            lblVernamOutput.Name = "lblVernamOutput";
            lblVernamOutput.Size = new Size(116, 20);
            lblVernamOutput.TabIndex = 2;
            lblVernamOutput.Text = "Decryption Text:";
            // 
            // txtVernamOutput
            // 
            txtVernamOutput.Location = new Point(158, 60);
            txtVernamOutput.Name = "txtVernamOutput";
            txtVernamOutput.Size = new Size(600, 27);
            txtVernamOutput.TabIndex = 3;
            // 
            // btnVernamEncrypt
            // 
            btnVernamEncrypt.Location = new Point(158, 100);
            btnVernamEncrypt.Name = "btnVernamEncrypt";
            btnVernamEncrypt.Size = new Size(120, 30);
            btnVernamEncrypt.TabIndex = 4;
            btnVernamEncrypt.Text = "Encrypt";
            btnVernamEncrypt.UseVisualStyleBackColor = true;
            btnVernamEncrypt.Click += btnVernamEncrypt_Click;
            // 
            // btnVernamDecrypt
            // 
            btnVernamDecrypt.Location = new Point(288, 100);
            btnVernamDecrypt.Name = "btnVernamDecrypt";
            btnVernamDecrypt.Size = new Size(120, 30);
            btnVernamDecrypt.TabIndex = 5;
            btnVernamDecrypt.Text = "Decrypt";
            btnVernamDecrypt.UseVisualStyleBackColor = true;
            btnVernamDecrypt.Click += btnVernamDecrypt_Click;
            // 
            // tbgVigenere
            // 
            tbgVigenere.Controls.Add(txtVigenereKey);
            tbgVigenere.Controls.Add(txtVigenereOutput);
            tbgVigenere.Controls.Add(txtVigenereInput);
            tbgVigenere.Controls.Add(label13);
            tbgVigenere.Controls.Add(label12);
            tbgVigenere.Controls.Add(label11);
            tbgVigenere.Controls.Add(btnVigenere_Decrypt);
            tbgVigenere.Controls.Add(btnVigenere_Encrypt);
            tbgVigenere.Location = new Point(4, 29);
            tbgVigenere.Name = "tbgVigenere";
            tbgVigenere.Padding = new Padding(3);
            tbgVigenere.Size = new Size(944, 456);
            tbgVigenere.TabIndex = 6;
            tbgVigenere.Text = "VigenereCipher";
            tbgVigenere.UseVisualStyleBackColor = true;
            // 
            // txtVigenereKey
            // 
            txtVigenereKey.Location = new Point(601, 20);
            txtVigenereKey.Name = "txtVigenereKey";
            txtVigenereKey.Size = new Size(144, 27);
            txtVigenereKey.TabIndex = 7;
            // 
            // txtVigenereOutput
            // 
            txtVigenereOutput.Location = new Point(145, 60);
            txtVigenereOutput.Name = "txtVigenereOutput";
            txtVigenereOutput.Size = new Size(600, 27);
            txtVigenereOutput.TabIndex = 6;
            // 
            // txtVigenereInput
            // 
            txtVigenereInput.Location = new Point(145, 20);
            txtVigenereInput.Name = "txtVigenereInput";
            txtVigenereInput.Size = new Size(397, 27);
            txtVigenereInput.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(548, 20);
            label13.Name = "label13";
            label13.Size = new Size(23, 20);
            label13.TabIndex = 4;
            label13.Text = "k :";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 60);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 3;
            label12.Text = "Decryption Text:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 20);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 2;
            label11.Text = "Encryption Text:";
            // 
            // btnVigenere_Decrypt
            // 
            btnVigenere_Decrypt.Location = new Point(275, 100);
            btnVigenere_Decrypt.Name = "btnVigenere_Decrypt";
            btnVigenere_Decrypt.Size = new Size(120, 30);
            btnVigenere_Decrypt.TabIndex = 1;
            btnVigenere_Decrypt.Text = "Decrypt";
            btnVigenere_Decrypt.UseVisualStyleBackColor = true;
            btnVigenere_Decrypt.Click += btnVigenere_Decrypt_Click;
            // 
            // btnVigenere_Encrypt
            // 
            btnVigenere_Encrypt.Location = new Point(145, 100);
            btnVigenere_Encrypt.Name = "btnVigenere_Encrypt";
            btnVigenere_Encrypt.Size = new Size(120, 30);
            btnVigenere_Encrypt.TabIndex = 0;
            btnVigenere_Encrypt.Text = "Encrypt";
            btnVigenere_Encrypt.UseVisualStyleBackColor = true;
            btnVigenere_Encrypt.Click += btnVigenere_Encrypt_Click;
            // 
            // tbSHA
            // 
            tbSHA.Controls.Add(label25);
            tbSHA.Controls.Add(lblSHA);
            tbSHA.Controls.Add(txtSHAResult);
            tbSHA.Controls.Add(txtSHAInput);
            tbSHA.Controls.Add(btnSelectFile);
            tbSHA.Controls.Add(btnComputeSHA);
            tbSHA.Location = new Point(4, 29);
            tbSHA.Name = "tbSHA";
            tbSHA.Size = new Size(944, 456);
            tbSHA.TabIndex = 8;
            tbSHA.Text = "SHA";
            tbSHA.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(32, 106);
            label25.Name = "label25";
            label25.Size = new Size(82, 20);
            label25.TabIndex = 5;
            label25.Text = "Hash Value";
            label25.Click += label25_Click;
            // 
            // lblSHA
            // 
            lblSHA.AutoSize = true;
            lblSHA.Location = new Point(32, 29);
            lblSHA.Name = "lblSHA";
            lblSHA.Size = new Size(67, 20);
            lblSHA.TabIndex = 4;
            lblSHA.Text = "plaintext";
            // 
            // txtSHAResult
            // 
            txtSHAResult.Location = new Point(125, 99);
            txtSHAResult.Multiline = true;
            txtSHAResult.Name = "txtSHAResult";
            txtSHAResult.Size = new Size(622, 27);
            txtSHAResult.TabIndex = 3;
            // 
            // txtSHAInput
            // 
            txtSHAInput.Location = new Point(125, 22);
            txtSHAInput.Name = "txtSHAInput";
            txtSHAInput.Size = new Size(622, 27);
            txtSHAInput.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(489, 60);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(155, 29);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnComputeSHA
            // 
            btnComputeSHA.Location = new Point(230, 60);
            btnComputeSHA.Name = "btnComputeSHA";
            btnComputeSHA.Size = new Size(155, 29);
            btnComputeSHA.TabIndex = 0;
            btnComputeSHA.Text = "Compute Hash";
            btnComputeSHA.UseVisualStyleBackColor = true;
            btnComputeSHA.Click += btnComputeSHA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 489);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Cipher Display";
            tabControl1.ResumeLayout(false);
            tbgCaeser.ResumeLayout(false);
            tbgCaeser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShift).EndInit();
            tbgAffine.ResumeLayout(false);
            tbgAffine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            tbgHill.ResumeLayout(false);
            tbgHill.PerformLayout();
            tbgAffineHill.ResumeLayout(false);
            tbgAffineHill.PerformLayout();
            tbgADFGVX.ResumeLayout(false);
            tbgADFGVX.PerformLayout();
            tbgPlayfair.ResumeLayout(false);
            tbgPlayfair.PerformLayout();
            tbgVernam.ResumeLayout(false);
            tbgVernam.PerformLayout();
            tbgVigenere.ResumeLayout(false);
            tbgVigenere.PerformLayout();
            tbSHA.ResumeLayout(false);
            tbSHA.PerformLayout();
            ResumeLayout(false);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private TabControl tabControl1;
        private TabPage tbgCaeser;
        private TabPage tbgAffine;
        private TabPage tbgHill;
        private TabPage tbgADFGVX;
        private TabPage tbgPlayfair;
        private TabPage tbgVernam;

        private Label lblCaeserInput;
        private TextBox txtCaeserInput;
        private Label lblCaeserOutput;
        private TextBox txtCaeserOutput;
        private Button btnCaeserEncrypt;
        private Button btnCaeserDecrypt;

        private Label lblAffineInput;
        private TextBox txtAffineInput;
        private Label lblAffineOutput;
        private TextBox txtAffineOutput;
        private Button btnAffineEncrypt;
        private Button btnAffineDecrypt;

        private Label lblHillInput;
        private TextBox txtHillInput;
        private Label lblHillOutput;
        private TextBox txtHillOutput;
        private Button btnHillEncrypt;
        private Button btnHillDecrypt;

        private Label lblADFGVXInput;
        private TextBox txtADFGVXInput;
        private Label lblADFGVXOutput;
        private TextBox txtADFGVXOutput;
        private Button btnADFGVXEncrypt;
        private Button btnADFGVXDecrypt;

        private Label lblPlayfairInput;
        private TextBox txtPlayfairInput;
        private Label lblPlayfairOutput;
        private TextBox txtPlayfairOutput;
        private Button btnPlayfairEncrypt;
        private Button btnPlayfairDecrypt;

        private Label lblVernamInput;
        private TextBox txtVernamInput;
        private Label lblVernamOutput;
        private TextBox txtVernamOutput;
        private Button btnVernamEncrypt;
        private Button btnVernamDecrypt;
        private Label label1;
        private NumericUpDown numericUpDownShift;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownA;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtKey12;
        private Label label7;
        private TextBox txtKey22;
        private Label label4;
        private TextBox txtKey11;
        private Label label5;
        private TextBox txtKey21;
        private Label label8;
        private TextBox txtADFGVXKey;
        private Label label9;
        private TextBox txtPlayfairKey;
        private Label label10;
        private TextBox txtVernamKey;
        private TabPage tbgVigenere;
        private TextBox txtVigenereKey;
        private TextBox txtVigenereOutput;
        private TextBox txtVigenereInput;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnVigenere_Decrypt;
        private Button btnVigenere_Encrypt;
        private TabPage tbgAffineHill;
        private Button btnAffineHill_Decrypt;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtAffineHillB22;
        private TextBox txtAffineHillB21;
        private TextBox txtAffineHillB12;
        private TextBox txtAffineHillB1N;
        private TextBox txtAffineHillA22;
        private TextBox txtAffineHillA21;
        private TextBox txtAffineHillA12;
        private TextBox txtAffineHillA11;
        private TextBox txtAffineHillOutput;
        private Button btnAffineHill_Encrypt;
        private Label label14;
        private TextBox txtAffineHillInput;
        private TextBox txtAffineHillB2N;
        private TabPage tbSHA;
        private TextBox txtSHAResult;
        private TextBox txtSHAInput;
        private Button btnSelectFile;
        private Button btnComputeSHA;
        private Label label25;
        private Label lblSHA;
    }
}
