using cryptography_project.MultiplicativeCipher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptography_project
{
    public partial class Multiplicative : Form
    {
        static bool enc = true;
        string path;
        string readText;
        
        string decreptionText="";
        string encreptionText="";
        public static String multiplicative_encreption(String plane_text, int key)
        {
            String cipher_text = "";
            char c1;
            int n;//a = 97
            
            foreach (char c in plane_text)//a
            {
                if((c >='a'&&c <='z')||(c >= 'A' && c <= 'Z'))
                {
                    n = (int)c - (int)'a';      //convert char into 0:26
                    n = ((n * key) % 26) + (int)'a';  //encreption to the number
                    //Console.WriteLine("hey "+n);
                    c1 = Convert.ToChar(n); //convert number char in its place
                    cipher_text += c1;
                }
                else
                {
                    cipher_text += c;
                }
            }


            return cipher_text;
        }

        public static String multiplicative_decreption(String cipher_text, int key)
        {
            String plain_text = "";
            char c1;
            int n;
            foreach (char c in cipher_text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    n = (int)c - (int)'a';
                    //equation is p=(c*k^-1)%26
                    n = (n * modInverse(key, 26) % 26) + (int)'a';  //decreption process
                    c1 = Convert.ToChar(n);
                    plain_text += c1;
                }
                else
                {
                    plain_text += c;
                }
            }


            return plain_text;
        }



        static int modInverse(int a, int n)
        {
            int i = n, v = 0, d = 1;
            while (a > 0)
            {
                int t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }
        static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        public Multiplicative()
        {
            InitializeComponent();
            t.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && GCD(Convert.ToInt32(txt_key.Text), 26) == 1 && t.Text != "")
                {
                    if (enc == true)
                    {
                        encreptionText = multiplicative_encreption(readText, Convert.ToInt32(txt_key.Text));
                        enc = false;
                        t.Text = encreptionText;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Key \n\nChoice file ,please", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            t.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            //t.Text = path;
            
            try
            {
                if (File.Exists(path))
                {
                    // Read all the content in one string
                    // and display the string
                    string str = File.ReadAllText(path);
                    Console.WriteLine(str);
                    t.AppendText(str);
                    readText = str;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dec_Click(object sender, EventArgs e)
        {
            encreptionText = multiplicative_decreption(decreptionText, 5);
            t.Text = encreptionText;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Home m = new Home();
            this.Close();
            m.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            string fileName = @"C:\Users\A\Desktop\my_file.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(encreptionText);
                    fs.Write(title, 0, title.Length);

                }
                MessageBox.Show("File Saved\nPath File :"+ fileName, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void btn_decry_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && GCD(Convert.ToInt32(txt_key.Text), 26) == 1 && t.Text != "")
                {
                    if (enc != true)
                    {
                        decreptionText = multiplicative_decreption(encreptionText, Convert.ToInt32(txt_key.Text));
                        enc = true;
                        t.Text = decreptionText;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Key \n\nChoice file ,please", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
           
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            About_Algorithm_mul m = new About_Algorithm_mul();
            m.ShowDialog();
        }
    }
}
