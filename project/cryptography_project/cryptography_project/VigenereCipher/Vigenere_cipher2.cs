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

namespace cryptography_project.VigenereCipher
{
    public partial class Vigenere_cipher2 : Form
    {
        static bool enc = true;
        string path;
        string readText;

        string decreptionText = "";
        string encreptionText = "";
        static String alphabets = "abcdefghijklmnopqrstuvwxyz";

        public static String vigenere_encreption(String plain_text, String key)
        {
            String cipher_text = "";
            int n, n_key, j = -1;

            foreach (char c in plain_text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (j < key.Length - 1)
                    {
                        j++;
                        n = (int)c - (int)'a';
                        n_key = (int)key[j] - (int)'a';

                        cipher_text += Convert.ToChar(((n + n_key) % 26) + (int)'a');

                    }
                    else
                    {
                        j = 0;
                        n = (int)c - (int)'a';
                        n_key = (int)key[j] - (int)'a';

                        cipher_text += Convert.ToChar(((n + n_key) % 26) + (int)'a');

                    }
                    //Console.WriteLine(j);
                }
                else
                {
                    cipher_text += c;
                }

            }

            return cipher_text;
        }
        public static String vigenere_decreption(String cipher_text, String key)
        {
            String plain_text = "";
            int n, n_key, j = -1;
            int y;
            foreach (char c in cipher_text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (j < key.Length - 1)
                    {
                        j++;
                        n = (int)c - (int)'a';
                        n_key = (int)key[j] - (int)'a';
                        y = n - n_key;
                        if (y < 0)
                            y = y + 26;
                        plain_text += Convert.ToChar((y % 26) + (int)'a');

                    }
                    else
                    {
                        j = 0;
                        n = (int)c - (int)'a';
                        n_key = (int)key[j] - (int)'a';
                        y = n - n_key;
                        if (y < 0)
                            y = y + 26;
                        plain_text += Convert.ToChar((y % 26) + (int)'a');
                    }
                }
                else
                {
                    plain_text += c;
                }


            }
            return plain_text;
        }

        public Vigenere_cipher2()
        {
            InitializeComponent();
        }

        private void btn_encry_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && t.Text != "")
                {
                    if (enc == true)
                    {
                        Console.WriteLine("-------------1");
                        //encreptionText = vigenere_encreption(readText, txt_key.Text);
                        encreptionText = vigenere_encreption(readText, txt_key.Text);
                        Console.WriteLine("-------------2");
                        enc = false;
                        Console.WriteLine(enc);
                        Console.WriteLine(encreptionText);
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

        private void btn_decry_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text != "" && t.Text != "")
                {
                    if (enc != true)
                    {
                        //decreptionText = vigenere_decreption(encreptionText, txt_key.Text);
                        Console.WriteLine("-------------1");
                        Console.WriteLine(encreptionText);
                        decreptionText = vigenere_decreption(encreptionText, txt_key.Text);
                        Console.WriteLine("-------------2");
                        enc = true;
                        t.Text = decreptionText;
                        Console.WriteLine("-------------3");
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

        private void btn_save_dec_Click(object sender, EventArgs e)
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
                MessageBox.Show("File Saved\nPath File :" + fileName, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            About_Algorithm_vig2 m = new About_Algorithm_vig2();
            m.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            this.Close();
            m.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
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

        private void txt_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
